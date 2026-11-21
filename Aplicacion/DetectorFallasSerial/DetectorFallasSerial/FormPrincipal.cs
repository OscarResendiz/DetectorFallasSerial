using DetectorFallasSerial.PuertoSerial;
using DetectorFallasSerial.LLMS.ChatGpt;
using System.IO.Ports;


namespace DetectorFallasSerial
{
    public partial class FormPrincipal : Form
    {
        private SerialPort? PuertoSerial;
        private bool LecturaSerialPausada = false;
        private ChatGptClient? _chatGptClient;

        private SerialPortDto ConfiguracionSerial = null;
        public FormPrincipal()
        {
            InitializeComponent();
            connectionStatusLabel.Text = "Desconectado";
            connectionStatusLabel.ForeColor = Color.Red;

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            FormConfigSerialPort dlg = new FormConfigSerialPort();
            dlg.ShowDialog(this);
            FormPrincipal_Load(null, null); // Refresh the serial port configuration after closing the dialog
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargaPuertos();
            LeerDatosSerial();
        }
        private void LeerDatosSerial()
        {
            ConfiguracionSerial = ManejadorConfiguracionSerial.CargarConfiguracion("SerialConfig.config");
            portComboBox.SelectedItem = ConfiguracionSerial.SerialPort;
            baudComboBox.SelectedItem = ConfiguracionSerial.Velocidad;
        }
        private void CargaPuertos()
        {
            string[] puertos = System.IO.Ports.SerialPort.GetPortNames();
            portComboBox.Items.Clear();
            portComboBox.Items.AddRange(puertos);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (portComboBox.SelectedItem == null || baudComboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un puerto y una velocidad de baudios antes de conectar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HabilitarControles(!Conectar());
        }
        private void HabilitarControles(bool habilitar)
        {
            portComboBox.Enabled = habilitar;
            baudComboBox.Enabled = habilitar;
            connectButton.Enabled = habilitar;
            disconnectButton.Enabled = !habilitar;
        }
        private bool Conectar()
        {
            try
            {
                // SerialPortDto config = ManejadorConfiguracionSerial.CargarConfiguracion("JtxToolA9.config");
                if (PuertoSerial == null)
                {
                    PuertoSerial = new SerialPort(ConfiguracionSerial.SerialPort, int.Parse(ConfiguracionSerial.Velocidad), (Parity)Enum.Parse(typeof(Parity), ConfiguracionSerial.Paridad), int.Parse(ConfiguracionSerial.BitsDatos), (StopBits)Enum.Parse(typeof(StopBits), ConfiguracionSerial.BitsParada));
                    PuertoSerial.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                }
                else if (PuertoSerial.IsOpen)
                {
                    PuertoSerial.Close();
                }
                PuertoSerial.PortName = portComboBox.SelectedItem.ToString(); //config.SerialPort;
                PuertoSerial.BaudRate = int.Parse(baudComboBox.SelectedItem.ToString()); //config.Velocidad);
                PuertoSerial.Parity = (Parity)Enum.Parse(typeof(Parity), ConfiguracionSerial.Paridad);
                PuertoSerial.DataBits = int.Parse(ConfiguracionSerial.BitsDatos);
                PuertoSerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ConfiguracionSerial.BitsParada);
                PuertoSerial.Open();
                connectionStatusLabel.Text = "Conectado";
                connectionStatusLabel.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar al puerto serial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string datos = PuertoSerial?.ReadExisting() ?? string.Empty; // Read the data from the serial port
            //serialOutputTextBox.AppendText(datos); // Append the data to the TextBox
            if (PuertoSerial == null || !PuertoSerial.IsOpen)
                return;
            if (LecturaSerialPausada)
                return;
            string datos = PuertoSerial.ReadExisting();
            if (string.IsNullOrEmpty(datos))
                return;

            if (serialOutputTextBox.IsDisposed || !serialOutputTextBox.IsHandleCreated)
                return;
            datos = datos.Trim();
            if (datos == "")
                return;
            string normalizada = datos.Replace("\r\n", "\n")
                                        .Replace("\r", "\n")
                                        .Replace("\n", Environment.NewLine);
            if (serialOutputTextBox.InvokeRequired)
            {
                serialOutputTextBox.BeginInvoke(new Action(() =>
                {
                    serialOutputTextBox.AppendText(normalizada);
                }));
            }
            else
            {
                serialOutputTextBox.AppendText(normalizada);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                PuertoSerial.Close();
                HabilitarControles(true);
                connectionStatusLabel.Text = "Desconectado";
                connectionStatusLabel.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar del puerto serial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            LecturaSerialPausada = !LecturaSerialPausada;
            if (LecturaSerialPausada)
            {
                pauseButton.Text = "Reanudar Lectura";
            }
            else
            {
                pauseButton.Text = "Pausar Lectura";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            serialOutputTextBox.Text = "";
        }

        private void GuardarLogBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, serialOutputTextBox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, promptTextBox.Text);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                promptTextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private async void analyzeButton_Click(object sender, EventArgs e)
        {
            try
            {
                analyzeButton.Enabled = false;
                statusLabel.Text = "Consultando a ChatGPT...";

                var modelo = modelComboBox.SelectedItem?.ToString()
                    ?? "gpt-4o-mini";

                if (modelo == "GPT-4o")
                {
                    modelo = "gpt-4o";
                }
                else
                {
                    modelo = "gpt-4o-mini";
                }

                _chatGptClient?.Dispose();
                _chatGptClient = new ChatGptClient(model: modelo);

                var descripcion = promptTextBox.Text.Trim();
                var datosSerial = serialOutputTextBox.Text.Trim();
                var consulta = $"Analiza el siguiente caso tecnico:\n\n" +
                    $"Descripcion o solicitud:\n{descripcion}\n\n" +
                    $"Datos capturados por el puerto serial:\n{datosSerial}";

                var respuesta = await _chatGptClient.ConsultarAsync(consulta);
                diagnosisTextBox.Text = respuesta;
                statusLabel.Text = "Consulta completada";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error al consultar a ChatGPT";
                MessageBox.Show(
                    ex.Message,
                    "Error de ChatGPT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                analyzeButton.Enabled = true;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _chatGptClient?.Dispose();
            base.OnFormClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, diagnosisTextBox.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            diagnosisTextBox.Text = "";
        }
    }
}
