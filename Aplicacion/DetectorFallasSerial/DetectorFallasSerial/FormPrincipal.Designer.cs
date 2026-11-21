namespace DetectorFallasSerial
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel serialSettingsLayout;
        private Panel portField;
        private Panel baudField;
        private Panel serialMonitorCard;
        private Panel promptCard;
        private Panel diagnosisCard;
        private Panel monitorHeader;
        private Panel promptHeader;
        private Panel diagnosisHeader;
        private FlowLayoutPanel serialActions;
        private FlowLayoutPanel monitorActions;
        private FlowLayoutPanel promptActions;
        private FlowLayoutPanel modelActions;
        private Label portLabel;
        private Label baudLabel;
        private Label connectionStatusLabel;
        private Label monitorTitleLabel;
        private Label promptTitleLabel;
        private Label diagnosisTitleLabel;
        private Label statusLabel;
        private ComboBox portComboBox;
        private ComboBox baudComboBox;
        private ComboBox modelComboBox;
        private Button configButton;
        private Button connectButton;
        private Button disconnectButton;
        private Button pauseButton;
        private Button clearButton;
        private Button analyzeButton;
        private Button openButton;
        private Button saveButton;
        private RichTextBox serialOutputTextBox;
        private RichTextBox promptTextBox;
        private RichTextBox diagnosisTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            serialSettingsLayout = new TableLayoutPanel();
            portField = new Panel();
            connectionStatusLabel = new Label();
            portLabel = new Label();
            portComboBox = new ComboBox();
            baudField = new Panel();
            baudComboBox = new ComboBox();
            baudLabel = new Label();
            serialActions = new FlowLayoutPanel();
            configButton = new Button();
            disconnectButton = new Button();
            connectButton = new Button();
            serialMonitorCard = new Panel();
            serialOutputTextBox = new RichTextBox();
            monitorHeader = new Panel();
            monitorTitleLabel = new Label();
            monitorActions = new FlowLayoutPanel();
            pauseButton = new Button();
            clearButton = new Button();
            GuardarLogBtn = new Button();
            analyzeButton = new Button();
            promptCard = new Panel();
            promptTextBox = new RichTextBox();
            promptHeader = new Panel();
            promptTitleLabel = new Label();
            promptActions = new FlowLayoutPanel();
            openButton = new Button();
            saveButton = new Button();
            modelActions = new FlowLayoutPanel();
            modelComboBox = new ComboBox();
            diagnosisCard = new Panel();
            diagnosisTextBox = new RichTextBox();
            diagnosisHeader = new Panel();
            button2 = new Button();
            button1 = new Button();
            diagnosisTitleLabel = new Label();
            statusLabel = new Label();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panel2 = new Panel();
            panel3 = new Panel();
            serialSettingsLayout.SuspendLayout();
            portField.SuspendLayout();
            baudField.SuspendLayout();
            serialActions.SuspendLayout();
            serialMonitorCard.SuspendLayout();
            monitorHeader.SuspendLayout();
            monitorActions.SuspendLayout();
            promptCard.SuspendLayout();
            promptHeader.SuspendLayout();
            promptActions.SuspendLayout();
            modelActions.SuspendLayout();
            diagnosisCard.SuspendLayout();
            diagnosisHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // serialSettingsLayout
            // 
            serialSettingsLayout.ColumnCount = 3;
            serialSettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            serialSettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            serialSettingsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            serialSettingsLayout.Controls.Add(portField, 0, 0);
            serialSettingsLayout.Controls.Add(baudField, 1, 0);
            serialSettingsLayout.Controls.Add(serialActions, 2, 0);
            serialSettingsLayout.Dock = DockStyle.Fill;
            serialSettingsLayout.Location = new Point(0, 0);
            serialSettingsLayout.Name = "serialSettingsLayout";
            serialSettingsLayout.RowCount = 1;
            serialSettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            serialSettingsLayout.Size = new Size(1048, 69);
            serialSettingsLayout.TabIndex = 0;
            // 
            // portField
            // 
            portField.BackColor = Color.Transparent;
            portField.Controls.Add(panel3);
            portField.Controls.Add(connectionStatusLabel);
            portField.Controls.Add(portLabel);
            portField.Controls.Add(portComboBox);
            portField.Dock = DockStyle.Fill;
            portField.Location = new Point(3, 3);
            portField.Name = "portField";
            portField.Padding = new Padding(2, 0, 8, 0);
            portField.Size = new Size(392, 63);
            portField.TabIndex = 0;
            // 
            // connectionStatusLabel
            // 
            connectionStatusLabel.Font = new Font("Segoe UI", 10F);
            connectionStatusLabel.ForeColor = Color.FromArgb(111, 215, 149);
            connectionStatusLabel.Location = new Point(252, 30);
            connectionStatusLabel.Name = "connectionStatusLabel";
            connectionStatusLabel.Size = new Size(140, 30);
            connectionStatusLabel.TabIndex = 0;
            connectionStatusLabel.Text = "●  CONECTADO";
            connectionStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // portLabel
            // 
            portLabel.Font = new Font("Segoe UI", 10F);
            portLabel.ForeColor = Color.FromArgb(236, 239, 242);
            portLabel.Location = new Point(74, 4);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(236, 26);
            portLabel.TabIndex = 2;
            portLabel.Text = "Puerto:";
            portLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // portComboBox
            // 
            portComboBox.BackColor = Color.FromArgb(35, 41, 49);
            portComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            portComboBox.FlatStyle = FlatStyle.Flat;
            portComboBox.Font = new Font("Segoe UI", 10F);
            portComboBox.ForeColor = Color.FromArgb(236, 239, 242);
            portComboBox.Items.AddRange(new object[] { "COM1", "COM3", "COM4" });
            portComboBox.Location = new Point(71, 35);
            portComboBox.Margin = new Padding(0);
            portComboBox.Name = "portComboBox";
            portComboBox.Size = new Size(150, 25);
            portComboBox.TabIndex = 1;
            // 
            // baudField
            // 
            baudField.BackColor = Color.Transparent;
            baudField.Controls.Add(baudComboBox);
            baudField.Controls.Add(baudLabel);
            baudField.Dock = DockStyle.Fill;
            baudField.Location = new Point(401, 3);
            baudField.Name = "baudField";
            baudField.Padding = new Padding(2, 0, 8, 0);
            baudField.Size = new Size(276, 63);
            baudField.TabIndex = 1;
            // 
            // baudComboBox
            // 
            baudComboBox.BackColor = Color.FromArgb(35, 41, 49);
            baudComboBox.Dock = DockStyle.Top;
            baudComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            baudComboBox.FlatStyle = FlatStyle.Flat;
            baudComboBox.Font = new Font("Segoe UI", 10F);
            baudComboBox.ForeColor = Color.FromArgb(236, 239, 242);
            baudComboBox.Items.AddRange(new object[] { "2400", "4800", "9600", "14400", "19200", "38400", "43000", "57600", "76800", "115200", "128000", "230400", "256000", "460800", "921600", "1382400" });
            baudComboBox.Location = new Point(2, 26);
            baudComboBox.Margin = new Padding(0);
            baudComboBox.Name = "baudComboBox";
            baudComboBox.Size = new Size(266, 25);
            baudComboBox.TabIndex = 1;
            // 
            // baudLabel
            // 
            baudLabel.Dock = DockStyle.Top;
            baudLabel.Font = new Font("Segoe UI", 10F);
            baudLabel.ForeColor = Color.FromArgb(236, 239, 242);
            baudLabel.Location = new Point(2, 0);
            baudLabel.Name = "baudLabel";
            baudLabel.Size = new Size(266, 26);
            baudLabel.TabIndex = 2;
            baudLabel.Text = "Baudios:";
            baudLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // serialActions
            // 
            serialActions.Controls.Add(configButton);
            serialActions.Controls.Add(disconnectButton);
            serialActions.Controls.Add(connectButton);
            serialActions.Dock = DockStyle.Fill;
            serialActions.FlowDirection = FlowDirection.RightToLeft;
            serialActions.Location = new Point(683, 3);
            serialActions.Name = "serialActions";
            serialActions.Padding = new Padding(0, 14, 0, 0);
            serialActions.Size = new Size(362, 63);
            serialActions.TabIndex = 0;
            serialActions.WrapContents = false;
            // 
            // configButton
            // 
            configButton.BackColor = Color.FromArgb(47, 55, 65);
            configButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            configButton.FlatStyle = FlatStyle.Flat;
            configButton.Font = new Font("Segoe UI", 10F);
            configButton.ForeColor = Color.FromArgb(242, 244, 246);
            configButton.Location = new Point(265, 14);
            configButton.Margin = new Padding(5, 0, 5, 0);
            configButton.Name = "configButton";
            configButton.Size = new Size(92, 34);
            configButton.TabIndex = 2;
            configButton.Text = "Config";
            configButton.UseVisualStyleBackColor = false;
            configButton.Click += configButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = Color.FromArgb(47, 55, 65);
            disconnectButton.Enabled = false;
            disconnectButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            disconnectButton.FlatStyle = FlatStyle.Flat;
            disconnectButton.Font = new Font("Segoe UI", 10F);
            disconnectButton.ForeColor = Color.FromArgb(242, 244, 246);
            disconnectButton.Location = new Point(129, 14);
            disconnectButton.Margin = new Padding(5, 0, 5, 0);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(126, 34);
            disconnectButton.TabIndex = 0;
            disconnectButton.Text = "Desconectar";
            disconnectButton.UseVisualStyleBackColor = false;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // connectButton
            // 
            connectButton.BackColor = Color.FromArgb(35, 112, 112);
            connectButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Segoe UI", 10F);
            connectButton.ForeColor = Color.FromArgb(242, 244, 246);
            connectButton.Location = new Point(-7, 14);
            connectButton.Margin = new Padding(5, 0, 5, 0);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(126, 34);
            connectButton.TabIndex = 1;
            connectButton.Text = "Conectar";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // serialMonitorCard
            // 
            serialMonitorCard.BackColor = Color.FromArgb(35, 41, 49);
            serialMonitorCard.Controls.Add(serialOutputTextBox);
            serialMonitorCard.Controls.Add(monitorHeader);
            serialMonitorCard.Dock = DockStyle.Fill;
            serialMonitorCard.Location = new Point(0, 0);
            serialMonitorCard.Margin = new Padding(0, 8, 0, 12);
            serialMonitorCard.Name = "serialMonitorCard";
            serialMonitorCard.Padding = new Padding(14);
            serialMonitorCard.Size = new Size(1048, 259);
            serialMonitorCard.TabIndex = 1;
            // 
            // serialOutputTextBox
            // 
            serialOutputTextBox.BackColor = Color.FromArgb(19, 23, 29);
            serialOutputTextBox.BorderStyle = BorderStyle.None;
            serialOutputTextBox.DetectUrls = false;
            serialOutputTextBox.Dock = DockStyle.Fill;
            serialOutputTextBox.Font = new Font("Consolas", 11F);
            serialOutputTextBox.ForeColor = Color.Green;
            serialOutputTextBox.Location = new Point(14, 54);
            serialOutputTextBox.Margin = new Padding(0);
            serialOutputTextBox.Name = "serialOutputTextBox";
            serialOutputTextBox.ReadOnly = true;
            serialOutputTextBox.Size = new Size(1020, 191);
            serialOutputTextBox.TabIndex = 0;
            serialOutputTextBox.Text = resources.GetString("serialOutputTextBox.Text");
            // 
            // monitorHeader
            // 
            monitorHeader.Controls.Add(monitorTitleLabel);
            monitorHeader.Controls.Add(monitorActions);
            monitorHeader.Dock = DockStyle.Top;
            monitorHeader.Location = new Point(14, 14);
            monitorHeader.Name = "monitorHeader";
            monitorHeader.Size = new Size(1020, 40);
            monitorHeader.TabIndex = 0;
            // 
            // monitorTitleLabel
            // 
            monitorTitleLabel.Dock = DockStyle.Fill;
            monitorTitleLabel.Font = new Font("Segoe UI", 11F);
            monitorTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            monitorTitleLabel.Location = new Point(0, 0);
            monitorTitleLabel.Name = "monitorTitleLabel";
            monitorTitleLabel.Size = new Size(702, 40);
            monitorTitleLabel.TabIndex = 0;
            monitorTitleLabel.Text = "MONITOR DE LECTURA SERIAL (TELEMETRÍA)";
            monitorTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // monitorActions
            // 
            monitorActions.Controls.Add(pauseButton);
            monitorActions.Controls.Add(clearButton);
            monitorActions.Controls.Add(GuardarLogBtn);
            monitorActions.Dock = DockStyle.Right;
            monitorActions.Location = new Point(702, 0);
            monitorActions.Name = "monitorActions";
            monitorActions.Size = new Size(318, 40);
            monitorActions.TabIndex = 0;
            monitorActions.WrapContents = false;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.FromArgb(47, 55, 65);
            pauseButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Font = new Font("Segoe UI", 10F);
            pauseButton.ForeColor = Color.FromArgb(242, 244, 246);
            pauseButton.Location = new Point(5, 0);
            pauseButton.Margin = new Padding(5, 0, 5, 0);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(92, 34);
            pauseButton.TabIndex = 0;
            pauseButton.Text = "Pausar";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += pauseButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(47, 55, 65);
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 10F);
            clearButton.ForeColor = Color.FromArgb(242, 244, 246);
            clearButton.Location = new Point(107, 0);
            clearButton.Margin = new Padding(5, 0, 5, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(92, 34);
            clearButton.TabIndex = 1;
            clearButton.Text = "Limpiar";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // GuardarLogBtn
            // 
            GuardarLogBtn.BackColor = Color.FromArgb(47, 55, 65);
            GuardarLogBtn.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            GuardarLogBtn.FlatStyle = FlatStyle.Flat;
            GuardarLogBtn.Font = new Font("Segoe UI", 10F);
            GuardarLogBtn.ForeColor = Color.FromArgb(242, 244, 246);
            GuardarLogBtn.Location = new Point(209, 0);
            GuardarLogBtn.Margin = new Padding(5, 0, 5, 0);
            GuardarLogBtn.Name = "GuardarLogBtn";
            GuardarLogBtn.Size = new Size(100, 34);
            GuardarLogBtn.TabIndex = 3;
            GuardarLogBtn.Text = "Guardar log";
            GuardarLogBtn.UseVisualStyleBackColor = false;
            GuardarLogBtn.Click += GuardarLogBtn_Click;
            // 
            // analyzeButton
            // 
            analyzeButton.BackColor = Color.FromArgb(47, 55, 65);
            analyzeButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            analyzeButton.FlatStyle = FlatStyle.Flat;
            analyzeButton.Font = new Font("Segoe UI", 10F);
            analyzeButton.ForeColor = Color.FromArgb(242, 244, 246);
            analyzeButton.Location = new Point(207, 0);
            analyzeButton.Margin = new Padding(5, 0, 5, 0);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(129, 34);
            analyzeButton.TabIndex = 2;
            analyzeButton.Text = "Analizar con la IA";
            analyzeButton.UseVisualStyleBackColor = false;
            analyzeButton.Click += analyzeButton_Click;
            // 
            // promptCard
            // 
            promptCard.BackColor = Color.FromArgb(35, 41, 49);
            promptCard.Controls.Add(promptTextBox);
            promptCard.Controls.Add(promptHeader);
            promptCard.Dock = DockStyle.Fill;
            promptCard.Location = new Point(0, 0);
            promptCard.Margin = new Padding(0, 0, 7, 0);
            promptCard.Name = "promptCard";
            promptCard.Padding = new Padding(14);
            promptCard.Size = new Size(566, 501);
            promptCard.TabIndex = 0;
            // 
            // promptTextBox
            // 
            promptTextBox.BackColor = Color.FromArgb(19, 23, 29);
            promptTextBox.BorderStyle = BorderStyle.None;
            promptTextBox.DetectUrls = false;
            promptTextBox.Dock = DockStyle.Fill;
            promptTextBox.Font = new Font("Segoe UI", 12F);
            promptTextBox.ForeColor = Color.FromArgb(0, 192, 192);
            promptTextBox.Location = new Point(14, 90);
            promptTextBox.Margin = new Padding(0);
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(538, 397);
            promptTextBox.TabIndex = 0;
            promptTextBox.Text = "Describe el comportamiento del equipo aquí o usa una plantilla... (ej. 'Consumo 1.85A al conectar cargador')";
            // 
            // promptHeader
            // 
            promptHeader.Controls.Add(promptTitleLabel);
            promptHeader.Controls.Add(promptActions);
            promptHeader.Dock = DockStyle.Top;
            promptHeader.Location = new Point(14, 14);
            promptHeader.Name = "promptHeader";
            promptHeader.Size = new Size(538, 76);
            promptHeader.TabIndex = 0;
            // 
            // promptTitleLabel
            // 
            promptTitleLabel.Dock = DockStyle.Top;
            promptTitleLabel.Font = new Font("Segoe UI", 11F);
            promptTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            promptTitleLabel.Location = new Point(0, 0);
            promptTitleLabel.Name = "promptTitleLabel";
            promptTitleLabel.Size = new Size(538, 30);
            promptTitleLabel.TabIndex = 0;
            promptTitleLabel.Text = "CONSULTA TÉCNICA (PROMPT)";
            promptTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // promptActions
            // 
            promptActions.Controls.Add(openButton);
            promptActions.Controls.Add(saveButton);
            promptActions.Controls.Add(analyzeButton);
            promptActions.Controls.Add(modelActions);
            promptActions.Dock = DockStyle.Bottom;
            promptActions.Location = new Point(0, 40);
            promptActions.Name = "promptActions";
            promptActions.Size = new Size(538, 36);
            promptActions.TabIndex = 0;
            promptActions.WrapContents = false;
            // 
            // openButton
            // 
            openButton.BackColor = Color.FromArgb(47, 55, 65);
            openButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Segoe UI", 10F);
            openButton.ForeColor = Color.FromArgb(242, 244, 246);
            openButton.Location = new Point(5, 0);
            openButton.Margin = new Padding(5, 0, 5, 0);
            openButton.Name = "openButton";
            openButton.Size = new Size(86, 34);
            openButton.TabIndex = 0;
            openButton.Text = "Abrir";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(47, 55, 65);
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 10F);
            saveButton.ForeColor = Color.FromArgb(242, 244, 246);
            saveButton.Location = new Point(101, 0);
            saveButton.Margin = new Padding(5, 0, 5, 0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // modelActions
            // 
            modelActions.Controls.Add(modelComboBox);
            modelActions.Location = new Point(344, 3);
            modelActions.Name = "modelActions";
            modelActions.Padding = new Padding(0, 0, 0, 2);
            modelActions.Size = new Size(222, 43);
            modelActions.TabIndex = 0;
            modelActions.WrapContents = false;
            // 
            // modelComboBox
            // 
            modelComboBox.BackColor = Color.FromArgb(25, 30, 37);
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelComboBox.FlatStyle = FlatStyle.Flat;
            modelActions.SetFlowBreak(modelComboBox, true);
            modelComboBox.Font = new Font("Segoe UI", 10F);
            modelComboBox.ForeColor = Color.FromArgb(236, 239, 242);
            modelComboBox.Items.AddRange(new object[] { "GPT-4o-mini", "GPT-4o" });
            modelComboBox.Location = new Point(0, 0);
            modelComboBox.Margin = new Padding(0);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(197, 25);
            modelComboBox.TabIndex = 0;
            // 
            // diagnosisCard
            // 
            diagnosisCard.BackColor = Color.FromArgb(35, 41, 49);
            diagnosisCard.Controls.Add(diagnosisTextBox);
            diagnosisCard.Controls.Add(diagnosisHeader);
            diagnosisCard.Dock = DockStyle.Fill;
            diagnosisCard.Location = new Point(0, 0);
            diagnosisCard.Margin = new Padding(7, 0, 0, 0);
            diagnosisCard.Name = "diagnosisCard";
            diagnosisCard.Padding = new Padding(14);
            diagnosisCard.Size = new Size(478, 501);
            diagnosisCard.TabIndex = 1;
            // 
            // diagnosisTextBox
            // 
            diagnosisTextBox.BackColor = Color.FromArgb(19, 23, 29);
            diagnosisTextBox.BorderStyle = BorderStyle.None;
            diagnosisTextBox.DetectUrls = false;
            diagnosisTextBox.Dock = DockStyle.Fill;
            diagnosisTextBox.Font = new Font("Segoe UI", 12F);
            diagnosisTextBox.ForeColor = Color.Teal;
            diagnosisTextBox.Location = new Point(14, 57);
            diagnosisTextBox.Margin = new Padding(0);
            diagnosisTextBox.Name = "diagnosisTextBox";
            diagnosisTextBox.ReadOnly = true;
            diagnosisTextBox.Size = new Size(450, 430);
            diagnosisTextBox.TabIndex = 0;
            diagnosisTextBox.Text = resources.GetString("diagnosisTextBox.Text");
            // 
            // diagnosisHeader
            // 
            diagnosisHeader.Controls.Add(button2);
            diagnosisHeader.Controls.Add(button1);
            diagnosisHeader.Controls.Add(diagnosisTitleLabel);
            diagnosisHeader.Dock = DockStyle.Top;
            diagnosisHeader.Location = new Point(14, 14);
            diagnosisHeader.Name = "diagnosisHeader";
            diagnosisHeader.Size = new Size(450, 43);
            diagnosisHeader.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(47, 55, 65);
            button2.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.FromArgb(242, 244, 246);
            button2.Location = new Point(340, 4);
            button2.Margin = new Padding(5, 0, 5, 0);
            button2.Name = "button2";
            button2.Size = new Size(92, 34);
            button2.TabIndex = 3;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(47, 55, 65);
            button1.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.FromArgb(242, 244, 246);
            button1.Location = new Point(177, 4);
            button1.Margin = new Padding(5, 0, 5, 0);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 2;
            button1.Text = "Guardar respuesta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // diagnosisTitleLabel
            // 
            diagnosisTitleLabel.Dock = DockStyle.Left;
            diagnosisTitleLabel.Font = new Font("Segoe UI", 11F);
            diagnosisTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            diagnosisTitleLabel.Location = new Point(0, 0);
            diagnosisTitleLabel.Name = "diagnosisTitleLabel";
            diagnosisTitleLabel.Size = new Size(178, 43);
            diagnosisTitleLabel.TabIndex = 0;
            diagnosisTitleLabel.Text = "DIAGNÓSTICO DE IA";
            diagnosisTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Bottom;
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(197, 203, 210);
            statusLabel.Location = new Point(0, 833);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(1048, 27);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Estado: Listo  |  Puerto COM3 (115200, 8, N, 1)  |  Última respuesta: 1.4s";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 833);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 69);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(serialMonitorCard);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1048, 764);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(promptCard);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(diagnosisCard);
            splitContainer2.Size = new Size(1048, 501);
            splitContainer2.SplitterDistance = 566;
            splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(serialSettingsLayout);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 69);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(66, 63);
            panel3.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 23, 29);
            ClientSize = new Size(1048, 860);
            Controls.Add(panel1);
            Controls.Add(statusLabel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 720);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DETECTOR DE FALLAS - DIAGNÓSTICO SERIAL & IA";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            serialSettingsLayout.ResumeLayout(false);
            portField.ResumeLayout(false);
            baudField.ResumeLayout(false);
            serialActions.ResumeLayout(false);
            serialMonitorCard.ResumeLayout(false);
            monitorHeader.ResumeLayout(false);
            monitorActions.ResumeLayout(false);
            promptCard.ResumeLayout(false);
            promptHeader.ResumeLayout(false);
            promptActions.ResumeLayout(false);
            modelActions.ResumeLayout(false);
            diagnosisCard.ResumeLayout(false);
            diagnosisHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button GuardarLogBtn;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button1;
        private Button button2;
        private Panel panel3;
    }
}
