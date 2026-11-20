using DetectorFallasSerial.PuertoSerial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DetectorFallasSerial
{
    public partial class FormConfigSerialPort : Form
    {
        private string NombreArchivo { get; set; } = "SerialConfig.config";
        public FormConfigSerialPort()
        {
            InitializeComponent();
        }
        private void FormConfigSerialPort_Load(object sender, EventArgs e)
        {
            CargaPuertos();
            LeerDatos();
        }
        private void CargaPuertos()
        {
            string[] puertos = System.IO.Ports.SerialPort.GetPortNames();
            ComboPuerto.Items.Clear();
            ComboPuerto.Items.AddRange(puertos);
        }
        private void LeerDatos()
        {
            var config = ManejadorConfiguracionSerial.CargarConfiguracion(NombreArchivo);
            ComboPuerto.SelectedItem = config.SerialPort;
            ComboVelocidad.SelectedItem = config.Velocidad;
            ComboParidad.SelectedItem = config.Paridad;
            ComboBitsDatos.SelectedItem = config.BitsDatos;
            ComboBitsParo.SelectedItem = config.BitsParada;
            flowControlCombo.SelectedItem = config.FlowControl;
            //TxtRetardo.Text = config.retardo;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            GuardaDatos();
            this.Close();
        }
        private void GuardaDatos()
        {
            var config = new SerialPortDto
            {
                SerialPort = ComboPuerto.SelectedItem?.ToString() ?? string.Empty,
                Velocidad = ComboVelocidad.SelectedItem?.ToString() ?? string.Empty,
                Paridad = ComboParidad.SelectedItem?.ToString() ?? string.Empty,
                BitsDatos = ComboBitsDatos.SelectedItem?.ToString() ?? string.Empty,
                BitsParada = ComboBitsParo.SelectedItem?.ToString() ?? string.Empty,
                FlowControl = flowControlCombo.SelectedItem?.ToString() ?? string.Empty,
                //retardo = TxtRetardo.Text
            };
            ManejadorConfiguracionSerial.GuardarConfiguracion(config, NombreArchivo);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            CargaPuertos();
        }
    }
}
