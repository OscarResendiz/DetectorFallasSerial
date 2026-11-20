namespace DetectorFallasSerial
{
    partial class FormConfigSerialPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            closeLabel = new Label();
            titleLabel = new Label();
            titleIcon = new Panel();
            basicCard = new Panel();
            basicTitle = new Label();
            portLabel = new Label();
            ComboPuerto = new ComboBox();
            refreshButton = new Button();
            cancelButton = new Button();
            baudLabel = new Label();
            saveButton = new Button();
            ComboVelocidad = new ComboBox();
            parametersTitle = new Label();
            parametersCard = new Panel();
            dataBitsLabel = new Label();
            ComboBitsDatos = new ComboBox();
            parityLabel = new Label();
            ComboParidad = new ComboBox();
            stopBitsLabel = new Label();
            ComboBitsParo = new ComboBox();
            flowControlLabel = new Label();
            flowControlCombo = new ComboBox();
            statusLabel = new Label();
            headerPanel.SuspendLayout();
            basicCard.SuspendLayout();
            parametersCard.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(18, 23, 29);
            headerPanel.Controls.Add(closeLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(titleIcon);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(940, 58);
            headerPanel.TabIndex = 0;
            // 
            // closeLabel
            // 
            closeLabel.Font = new Font("Segoe UI", 12F);
            closeLabel.ForeColor = Color.FromArgb(236, 239, 242);
            closeLabel.Location = new Point(904, 18);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(24, 24);
            closeLabel.TabIndex = 2;
            closeLabel.Text = "×";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F);
            titleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            titleLabel.Location = new Point(59, 18);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(308, 30);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Configuración de Puerto Serial";
            // 
            // titleIcon
            // 
            titleIcon.BackColor = Color.FromArgb(49, 112, 160);
            titleIcon.Location = new Point(26, 32);
            titleIcon.Name = "titleIcon";
            titleIcon.Size = new Size(18, 18);
            titleIcon.TabIndex = 0;
            // 
            // basicCard
            // 
            basicCard.BackColor = Color.FromArgb(27, 34, 43);
            basicCard.BorderStyle = BorderStyle.FixedSingle;
            basicCard.Controls.Add(basicTitle);
            basicCard.Controls.Add(portLabel);
            basicCard.Controls.Add(ComboPuerto);
            basicCard.Controls.Add(refreshButton);
            basicCard.Controls.Add(cancelButton);
            basicCard.Controls.Add(baudLabel);
            basicCard.Controls.Add(saveButton);
            basicCard.Controls.Add(ComboVelocidad);
            basicCard.Location = new Point(28, 79);
            basicCard.Name = "basicCard";
            basicCard.Size = new Size(884, 205);
            basicCard.TabIndex = 1;
            // 
            // basicTitle
            // 
            basicTitle.AutoSize = true;
            basicTitle.Font = new Font("Segoe UI", 12F);
            basicTitle.ForeColor = Color.FromArgb(236, 239, 242);
            basicTitle.Location = new Point(12, 14);
            basicTitle.Name = "basicTitle";
            basicTitle.Size = new Size(192, 21);
            basicTitle.TabIndex = 0;
            basicTitle.Text = "CONFIGURACIÓN BÁSICA";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Font = new Font("Segoe UI", 11F);
            portLabel.ForeColor = Color.FromArgb(236, 239, 242);
            portLabel.Location = new Point(18, 51);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(102, 20);
            portLabel.TabIndex = 1;
            portLabel.Text = "Puerto (COM):";
            // 
            // ComboPuerto
            // 
            ComboPuerto.BackColor = Color.FromArgb(35, 41, 49);
            ComboPuerto.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPuerto.FlatStyle = FlatStyle.Flat;
            ComboPuerto.Font = new Font("Segoe UI", 11F);
            ComboPuerto.ForeColor = Color.FromArgb(236, 239, 242);
            ComboPuerto.Items.AddRange(new object[] { "COM3", "COM1", "COM4" });
            ComboPuerto.Location = new Point(18, 74);
            ComboPuerto.Name = "ComboPuerto";
            ComboPuerto.Size = new Size(355, 28);
            ComboPuerto.TabIndex = 2;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(35, 41, 49);
            refreshButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI Symbol", 12F);
            refreshButton.ForeColor = Color.FromArgb(236, 239, 242);
            refreshButton.Location = new Point(391, 72);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(34, 32);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "⟳";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(47, 55, 65);
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 11F);
            cancelButton.ForeColor = Color.FromArgb(242, 244, 246);
            cancelButton.Location = new Point(705, 72);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(155, 34);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // baudLabel
            // 
            baudLabel.AutoSize = true;
            baudLabel.Font = new Font("Segoe UI", 11F);
            baudLabel.ForeColor = Color.FromArgb(236, 239, 242);
            baudLabel.Location = new Point(18, 127);
            baudLabel.Name = "baudLabel";
            baudLabel.Size = new Size(145, 20);
            baudLabel.TabIndex = 4;
            baudLabel.Text = "Baudios (Velocidad):";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(35, 112, 112);
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 11F);
            saveButton.ForeColor = Color.FromArgb(242, 244, 246);
            saveButton.Location = new Point(705, 14);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(155, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "Guardar y cerrar";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // ComboVelocidad
            // 
            ComboVelocidad.BackColor = Color.FromArgb(35, 41, 49);
            ComboVelocidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboVelocidad.FlatStyle = FlatStyle.Flat;
            ComboVelocidad.Font = new Font("Segoe UI", 11F);
            ComboVelocidad.ForeColor = Color.FromArgb(236, 239, 242);
            ComboVelocidad.Items.AddRange(new object[] { "2400", "4800", "9600", "14400", "19200", "38400", "43000", "57600", "76800", "115200", "128000", "230400", "256000", "460800", "921600", "1382400" });
            ComboVelocidad.Location = new Point(18, 150);
            ComboVelocidad.Name = "ComboVelocidad";
            ComboVelocidad.Size = new Size(355, 28);
            ComboVelocidad.TabIndex = 5;
            // 
            // parametersTitle
            // 
            parametersTitle.AutoSize = true;
            parametersTitle.Font = new Font("Segoe UI", 12F);
            parametersTitle.ForeColor = Color.FromArgb(236, 239, 242);
            parametersTitle.Location = new Point(28, 305);
            parametersTitle.Name = "parametersTitle";
            parametersTitle.Size = new Size(257, 21);
            parametersTitle.TabIndex = 0;
            parametersTitle.Text = "PARÁMETROS DE COMUNICACIÓN";
            // 
            // parametersCard
            // 
            parametersCard.BackColor = Color.FromArgb(27, 34, 43);
            parametersCard.BorderStyle = BorderStyle.FixedSingle;
            parametersCard.Controls.Add(dataBitsLabel);
            parametersCard.Controls.Add(ComboBitsDatos);
            parametersCard.Controls.Add(parityLabel);
            parametersCard.Controls.Add(ComboParidad);
            parametersCard.Controls.Add(stopBitsLabel);
            parametersCard.Controls.Add(ComboBitsParo);
            parametersCard.Controls.Add(flowControlLabel);
            parametersCard.Controls.Add(flowControlCombo);
            parametersCard.Location = new Point(28, 334);
            parametersCard.Name = "parametersCard";
            parametersCard.Size = new Size(884, 168);
            parametersCard.TabIndex = 2;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Font = new Font("Segoe UI", 11F);
            dataBitsLabel.ForeColor = Color.FromArgb(236, 239, 242);
            dataBitsLabel.Location = new Point(18, 18);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(100, 20);
            dataBitsLabel.TabIndex = 1;
            dataBitsLabel.Text = "Bits de Datos:";
            // 
            // ComboBitsDatos
            // 
            ComboBitsDatos.BackColor = Color.FromArgb(35, 41, 49);
            ComboBitsDatos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBitsDatos.FlatStyle = FlatStyle.Flat;
            ComboBitsDatos.Font = new Font("Segoe UI", 11F);
            ComboBitsDatos.ForeColor = Color.FromArgb(236, 239, 242);
            ComboBitsDatos.Items.AddRange(new object[] { "5", "6", "7", "8" });
            ComboBitsDatos.Location = new Point(18, 41);
            ComboBitsDatos.Name = "ComboBitsDatos";
            ComboBitsDatos.Size = new Size(405, 28);
            ComboBitsDatos.TabIndex = 2;
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Font = new Font("Segoe UI", 11F);
            parityLabel.ForeColor = Color.FromArgb(236, 239, 242);
            parityLabel.Location = new Point(446, 18);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(62, 20);
            parityLabel.TabIndex = 3;
            parityLabel.Text = "Paridad:";
            // 
            // ComboParidad
            // 
            ComboParidad.BackColor = Color.FromArgb(35, 41, 49);
            ComboParidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboParidad.FlatStyle = FlatStyle.Flat;
            ComboParidad.Font = new Font("Segoe UI", 11F);
            ComboParidad.ForeColor = Color.FromArgb(236, 239, 242);
            ComboParidad.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            ComboParidad.Location = new Point(446, 41);
            ComboParidad.Name = "ComboParidad";
            ComboParidad.Size = new Size(405, 28);
            ComboParidad.TabIndex = 4;
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Font = new Font("Segoe UI", 11F);
            stopBitsLabel.ForeColor = Color.FromArgb(236, 239, 242);
            stopBitsLabel.Location = new Point(18, 91);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new Size(106, 20);
            stopBitsLabel.TabIndex = 5;
            stopBitsLabel.Text = "Bits de Parada:";
            // 
            // ComboBitsParo
            // 
            ComboBitsParo.BackColor = Color.FromArgb(35, 41, 49);
            ComboBitsParo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBitsParo.FlatStyle = FlatStyle.Flat;
            ComboBitsParo.Font = new Font("Segoe UI", 11F);
            ComboBitsParo.ForeColor = Color.FromArgb(236, 239, 242);
            ComboBitsParo.Items.AddRange(new object[] { "None", "One", "Two", "OnePointFive" });
            ComboBitsParo.Location = new Point(18, 114);
            ComboBitsParo.Name = "ComboBitsParo";
            ComboBitsParo.Size = new Size(405, 28);
            ComboBitsParo.TabIndex = 6;
            // 
            // flowControlLabel
            // 
            flowControlLabel.AutoSize = true;
            flowControlLabel.Font = new Font("Segoe UI", 11F);
            flowControlLabel.ForeColor = Color.FromArgb(236, 239, 242);
            flowControlLabel.Location = new Point(446, 91);
            flowControlLabel.Name = "flowControlLabel";
            flowControlLabel.Size = new Size(118, 20);
            flowControlLabel.TabIndex = 7;
            flowControlLabel.Text = "Control de Flujo:";
            // 
            // flowControlCombo
            // 
            flowControlCombo.BackColor = Color.FromArgb(35, 41, 49);
            flowControlCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            flowControlCombo.FlatStyle = FlatStyle.Flat;
            flowControlCombo.Font = new Font("Segoe UI", 11F);
            flowControlCombo.ForeColor = Color.FromArgb(236, 239, 242);
            flowControlCombo.Items.AddRange(new object[] { "Ninguno", "RTS/CTS", "Xon/Xoff" });
            flowControlCombo.Location = new Point(446, 114);
            flowControlCombo.Name = "flowControlCombo";
            flowControlCombo.Size = new Size(405, 28);
            flowControlCombo.TabIndex = 8;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.FromArgb(18, 23, 29);
            statusLabel.Dock = DockStyle.Bottom;
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(236, 239, 242);
            statusLabel.Location = new Point(0, 516);
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(7, 0, 0, 0);
            statusLabel.Size = new Size(940, 28);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Configuración de Puerto | COM3: 115200, 8, N, 1 | Estado: Conectado";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormConfigSerialPort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 23, 29);
            CancelButton = cancelButton;
            ClientSize = new Size(940, 544);
            ControlBox = false;
            Controls.Add(headerPanel);
            Controls.Add(basicCard);
            Controls.Add(parametersTitle);
            Controls.Add(parametersCard);
            Controls.Add(statusLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormConfigSerialPort";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONFIGURACIÓN DE PUERTO SERIAL - DETECTOR DE FALLAS";
            Load += FormConfigSerialPort_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            basicCard.ResumeLayout(false);
            basicCard.PerformLayout();
            parametersCard.ResumeLayout(false);
            parametersCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Label closeLabel;
        private Label titleLabel;
        private Panel titleIcon;
        private Panel basicCard;
        private Label basicTitle;
        private Label portLabel;
        private ComboBox ComboPuerto;
        private Button refreshButton;
        private Label baudLabel;
        private ComboBox ComboVelocidad;
        private Label parametersTitle;
        private Panel parametersCard;
        private Label dataBitsLabel;
        private ComboBox ComboBitsDatos;
        private Label parityLabel;
        private ComboBox ComboParidad;
        private Label stopBitsLabel;
        private ComboBox ComboBitsParo;
        private Label flowControlLabel;
        private ComboBox flowControlCombo;
        private Button cancelButton;
        private Button saveButton;
        private Label statusLabel;
    }
}