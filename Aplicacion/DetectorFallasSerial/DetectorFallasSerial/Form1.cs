namespace DetectorFallasSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            FormConfigSerialPort dlg=new FormConfigSerialPort();
            dlg.ShowDialog(this);
        }
    }
}
