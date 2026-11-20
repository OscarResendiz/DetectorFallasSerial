using DetectorFallasSerial.PuertoSerial;
using System.IO.Ports;


namespace DetectorFallasSerial
{
    public partial class FormPrincipal : Form
    {
        private SerialPort? PuertoSerial;
        private bool LecturaSerialPausada = false;

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

            if (serialOutputTextBox.InvokeRequired)
            {
                serialOutputTextBox.BeginInvoke(new Action(() =>
                {
                    serialOutputTextBox.AppendText(datos);
                }));
            }
            else
            {
                serialOutputTextBox.AppendText(datos);
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
    }
}
