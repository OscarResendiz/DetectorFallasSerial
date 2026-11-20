namespace DetectorFallasSerial
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel serialSettingsLayout;
        private TableLayoutPanel bottomLayout;
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
        private Button templatesButton;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainLayout = new TableLayoutPanel();
            serialSettingsLayout = new TableLayoutPanel();
            portField = new Panel();
            connectionStatusLabel = new Label();
            portComboBox = new ComboBox();
            portLabel = new Label();
            baudField = new Panel();
            baudComboBox = new ComboBox();
            baudLabel = new Label();
            serialActions = new FlowLayoutPanel();
            disconnectButton = new Button();
            connectButton = new Button();
            configButton = new Button();
            serialMonitorCard = new Panel();
            serialOutputTextBox = new RichTextBox();
            monitorHeader = new Panel();
            monitorTitleLabel = new Label();
            monitorActions = new FlowLayoutPanel();
            pauseButton = new Button();
            clearButton = new Button();
            analyzeButton = new Button();
            bottomLayout = new TableLayoutPanel();
            promptCard = new Panel();
            promptTextBox = new RichTextBox();
            promptHeader = new Panel();
            promptTitleLabel = new Label();
            promptActions = new FlowLayoutPanel();
            openButton = new Button();
            saveButton = new Button();
            templatesButton = new Button();
            diagnosisCard = new Panel();
            diagnosisTextBox = new RichTextBox();
            diagnosisHeader = new Panel();
            diagnosisTitleLabel = new Label();
            modelActions = new FlowLayoutPanel();
            modelComboBox = new ComboBox();
            statusLabel = new Label();
            mainLayout.SuspendLayout();
            serialSettingsLayout.SuspendLayout();
            portField.SuspendLayout();
            baudField.SuspendLayout();
            serialActions.SuspendLayout();
            serialMonitorCard.SuspendLayout();
            monitorHeader.SuspendLayout();
            monitorActions.SuspendLayout();
            bottomLayout.SuspendLayout();
            promptCard.SuspendLayout();
            promptHeader.SuspendLayout();
            promptActions.SuspendLayout();
            diagnosisCard.SuspendLayout();
            diagnosisHeader.SuspendLayout();
            modelActions.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(18, 23, 29);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(serialSettingsLayout, 0, 0);
            mainLayout.Controls.Add(serialMonitorCard, 0, 1);
            mainLayout.Controls.Add(bottomLayout, 0, 2);
            mainLayout.Controls.Add(statusLabel, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(18, 12, 18, 10);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            mainLayout.Size = new Size(1120, 860);
            mainLayout.TabIndex = 0;
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
            serialSettingsLayout.Location = new Point(21, 15);
            serialSettingsLayout.Name = "serialSettingsLayout";
            serialSettingsLayout.RowCount = 1;
            serialSettingsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            serialSettingsLayout.Size = new Size(1078, 66);
            serialSettingsLayout.TabIndex = 0;
            // 
            // portField
            // 
            portField.BackColor = Color.Transparent;
            portField.Controls.Add(connectionStatusLabel);
            portField.Controls.Add(portComboBox);
            portField.Controls.Add(portLabel);
            portField.Dock = DockStyle.Fill;
            portField.Location = new Point(3, 3);
            portField.Name = "portField";
            portField.Padding = new Padding(2, 0, 8, 0);
            portField.Size = new Size(403, 60);
            portField.TabIndex = 0;
            // 
            // connectionStatusLabel
            // 
            connectionStatusLabel.Font = new Font("Segoe UI", 10F);
            connectionStatusLabel.ForeColor = Color.FromArgb(111, 215, 149);
            connectionStatusLabel.Location = new Point(166, 29);
            connectionStatusLabel.Name = "connectionStatusLabel";
            connectionStatusLabel.Size = new Size(140, 30);
            connectionStatusLabel.TabIndex = 0;
            connectionStatusLabel.Text = "●  CONECTADO";
            connectionStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // portComboBox
            // 
            portComboBox.BackColor = Color.FromArgb(35, 41, 49);
            portComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            portComboBox.FlatStyle = FlatStyle.Flat;
            portComboBox.Font = new Font("Segoe UI", 10F);
            portComboBox.ForeColor = Color.FromArgb(236, 239, 242);
            portComboBox.Items.AddRange(new object[] { "COM1", "COM3", "COM4" });
            portComboBox.Location = new Point(2, 29);
            portComboBox.Margin = new Padding(0);
            portComboBox.Name = "portComboBox";
            portComboBox.Size = new Size(150, 25);
            portComboBox.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.Dock = DockStyle.Top;
            portLabel.Font = new Font("Segoe UI", 10F);
            portLabel.ForeColor = Color.FromArgb(236, 239, 242);
            portLabel.Location = new Point(2, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(393, 26);
            portLabel.TabIndex = 2;
            portLabel.Text = "Puerto:";
            portLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // baudField
            // 
            baudField.BackColor = Color.Transparent;
            baudField.Controls.Add(baudComboBox);
            baudField.Controls.Add(baudLabel);
            baudField.Dock = DockStyle.Fill;
            baudField.Location = new Point(412, 3);
            baudField.Name = "baudField";
            baudField.Padding = new Padding(2, 0, 8, 0);
            baudField.Size = new Size(285, 60);
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
            baudComboBox.Items.AddRange(new object[] { "9600", "57600", "115200", "230400" });
            baudComboBox.Location = new Point(2, 26);
            baudComboBox.Margin = new Padding(0);
            baudComboBox.Name = "baudComboBox";
            baudComboBox.Size = new Size(275, 25);
            baudComboBox.TabIndex = 1;
            // 
            // baudLabel
            // 
            baudLabel.Dock = DockStyle.Top;
            baudLabel.Font = new Font("Segoe UI", 10F);
            baudLabel.ForeColor = Color.FromArgb(236, 239, 242);
            baudLabel.Location = new Point(2, 0);
            baudLabel.Name = "baudLabel";
            baudLabel.Size = new Size(275, 26);
            baudLabel.TabIndex = 2;
            baudLabel.Text = "Baudios:";
            baudLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // serialActions
            // 
            serialActions.Controls.Add(disconnectButton);
            serialActions.Controls.Add(connectButton);
            serialActions.Controls.Add(configButton);
            serialActions.Dock = DockStyle.Fill;
            serialActions.FlowDirection = FlowDirection.RightToLeft;
            serialActions.Location = new Point(703, 3);
            serialActions.Name = "serialActions";
            serialActions.Padding = new Padding(0, 14, 0, 0);
            serialActions.Size = new Size(372, 60);
            serialActions.TabIndex = 0;
            serialActions.WrapContents = false;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = Color.FromArgb(47, 55, 65);
            disconnectButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            disconnectButton.FlatStyle = FlatStyle.Flat;
            disconnectButton.Font = new Font("Segoe UI", 10F);
            disconnectButton.ForeColor = Color.FromArgb(242, 244, 246);
            disconnectButton.Location = new Point(241, 14);
            disconnectButton.Margin = new Padding(5, 0, 5, 0);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(126, 34);
            disconnectButton.TabIndex = 0;
            disconnectButton.Text = "Desconectar";
            disconnectButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            connectButton.BackColor = Color.FromArgb(35, 112, 112);
            connectButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Segoe UI", 10F);
            connectButton.ForeColor = Color.FromArgb(242, 244, 246);
            connectButton.Location = new Point(105, 14);
            connectButton.Margin = new Padding(5, 0, 5, 0);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(126, 34);
            connectButton.TabIndex = 1;
            connectButton.Text = "Conectar";
            connectButton.UseVisualStyleBackColor = false;
            // 
            // configButton
            // 
            configButton.BackColor = Color.FromArgb(47, 55, 65);
            configButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            configButton.FlatStyle = FlatStyle.Flat;
            configButton.Font = new Font("Segoe UI", 10F);
            configButton.ForeColor = Color.FromArgb(242, 244, 246);
            configButton.Location = new Point(3, 14);
            configButton.Margin = new Padding(5, 0, 5, 0);
            configButton.Name = "configButton";
            configButton.Size = new Size(92, 34);
            configButton.TabIndex = 2;
            configButton.Text = "Config";
            configButton.UseVisualStyleBackColor = false;
            // 
            // serialMonitorCard
            // 
            serialMonitorCard.BackColor = Color.FromArgb(35, 41, 49);
            serialMonitorCard.Controls.Add(serialOutputTextBox);
            serialMonitorCard.Controls.Add(monitorHeader);
            serialMonitorCard.Dock = DockStyle.Fill;
            serialMonitorCard.Location = new Point(18, 92);
            serialMonitorCard.Margin = new Padding(0, 8, 0, 12);
            serialMonitorCard.Name = "serialMonitorCard";
            serialMonitorCard.Padding = new Padding(14);
            serialMonitorCard.Size = new Size(1084, 305);
            serialMonitorCard.TabIndex = 1;
            // 
            // serialOutputTextBox
            // 
            serialOutputTextBox.BackColor = Color.FromArgb(19, 23, 29);
            serialOutputTextBox.BorderStyle = BorderStyle.None;
            serialOutputTextBox.DetectUrls = false;
            serialOutputTextBox.Dock = DockStyle.Fill;
            serialOutputTextBox.Font = new Font("Consolas", 11F);
            serialOutputTextBox.ForeColor = Color.FromArgb(227, 231, 235);
            serialOutputTextBox.Location = new Point(14, 54);
            serialOutputTextBox.Margin = new Padding(0);
            serialOutputTextBox.Name = "serialOutputTextBox";
            serialOutputTextBox.ReadOnly = true;
            serialOutputTextBox.Size = new Size(1056, 237);
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
            monitorHeader.Size = new Size(1056, 40);
            monitorHeader.TabIndex = 0;
            // 
            // monitorTitleLabel
            // 
            monitorTitleLabel.Dock = DockStyle.Fill;
            monitorTitleLabel.Font = new Font("Segoe UI", 11F);
            monitorTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            monitorTitleLabel.Location = new Point(0, 0);
            monitorTitleLabel.Name = "monitorTitleLabel";
            monitorTitleLabel.Size = new Size(856, 40);
            monitorTitleLabel.TabIndex = 0;
            monitorTitleLabel.Text = "MONITOR DE LECTURA SERIAL (TELEMETRÍA)";
            monitorTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // monitorActions
            // 
            monitorActions.Controls.Add(pauseButton);
            monitorActions.Controls.Add(clearButton);
            monitorActions.Controls.Add(analyzeButton);
            monitorActions.Dock = DockStyle.Right;
            monitorActions.Location = new Point(856, 0);
            monitorActions.Name = "monitorActions";
            monitorActions.Size = new Size(200, 40);
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
            // 
            // analyzeButton
            // 
            analyzeButton.BackColor = Color.FromArgb(47, 55, 65);
            analyzeButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            analyzeButton.FlatStyle = FlatStyle.Flat;
            analyzeButton.Font = new Font("Segoe UI", 10F);
            analyzeButton.ForeColor = Color.FromArgb(242, 244, 246);
            analyzeButton.Location = new Point(209, 0);
            analyzeButton.Margin = new Padding(5, 0, 5, 0);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(100, 34);
            analyzeButton.TabIndex = 2;
            analyzeButton.Text = "Analizar";
            analyzeButton.UseVisualStyleBackColor = false;
            // 
            // bottomLayout
            // 
            bottomLayout.BackColor = Color.Transparent;
            bottomLayout.ColumnCount = 2;
            bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottomLayout.Controls.Add(promptCard, 0, 0);
            bottomLayout.Controls.Add(diagnosisCard, 1, 0);
            bottomLayout.Dock = DockStyle.Fill;
            bottomLayout.Location = new Point(18, 409);
            bottomLayout.Margin = new Padding(0);
            bottomLayout.Name = "bottomLayout";
            bottomLayout.RowCount = 1;
            bottomLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomLayout.Size = new Size(1084, 414);
            bottomLayout.TabIndex = 0;
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
            promptCard.Size = new Size(535, 414);
            promptCard.TabIndex = 0;
            // 
            // promptTextBox
            // 
            promptTextBox.BackColor = Color.FromArgb(19, 23, 29);
            promptTextBox.BorderStyle = BorderStyle.None;
            promptTextBox.DetectUrls = false;
            promptTextBox.Dock = DockStyle.Fill;
            promptTextBox.Font = new Font("Segoe UI", 12F);
            promptTextBox.ForeColor = Color.FromArgb(145, 153, 163);
            promptTextBox.Location = new Point(14, 90);
            promptTextBox.Margin = new Padding(0);
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(507, 310);
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
            promptHeader.Size = new Size(507, 76);
            promptHeader.TabIndex = 0;
            // 
            // promptTitleLabel
            // 
            promptTitleLabel.Dock = DockStyle.Top;
            promptTitleLabel.Font = new Font("Segoe UI", 11F);
            promptTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            promptTitleLabel.Location = new Point(0, 0);
            promptTitleLabel.Name = "promptTitleLabel";
            promptTitleLabel.Size = new Size(507, 30);
            promptTitleLabel.TabIndex = 0;
            promptTitleLabel.Text = "CONSULTA TÉCNICA (PROMPT)";
            promptTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // promptActions
            // 
            promptActions.Controls.Add(openButton);
            promptActions.Controls.Add(saveButton);
            promptActions.Controls.Add(templatesButton);
            promptActions.Dock = DockStyle.Bottom;
            promptActions.Location = new Point(0, 40);
            promptActions.Name = "promptActions";
            promptActions.Size = new Size(507, 36);
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
            // 
            // templatesButton
            // 
            templatesButton.BackColor = Color.FromArgb(47, 55, 65);
            templatesButton.FlatAppearance.BorderColor = Color.FromArgb(65, 73, 83);
            templatesButton.FlatStyle = FlatStyle.Flat;
            templatesButton.Font = new Font("Segoe UI", 10F);
            templatesButton.ForeColor = Color.FromArgb(242, 244, 246);
            templatesButton.Location = new Point(207, 0);
            templatesButton.Margin = new Padding(5, 0, 5, 0);
            templatesButton.Name = "templatesButton";
            templatesButton.Size = new Size(112, 34);
            templatesButton.TabIndex = 2;
            templatesButton.Text = "Plantillas";
            templatesButton.UseVisualStyleBackColor = false;
            // 
            // diagnosisCard
            // 
            diagnosisCard.BackColor = Color.FromArgb(35, 41, 49);
            diagnosisCard.Controls.Add(diagnosisTextBox);
            diagnosisCard.Controls.Add(diagnosisHeader);
            diagnosisCard.Dock = DockStyle.Fill;
            diagnosisCard.Location = new Point(549, 0);
            diagnosisCard.Margin = new Padding(7, 0, 0, 0);
            diagnosisCard.Name = "diagnosisCard";
            diagnosisCard.Padding = new Padding(14);
            diagnosisCard.Size = new Size(535, 414);
            diagnosisCard.TabIndex = 1;
            // 
            // diagnosisTextBox
            // 
            diagnosisTextBox.BackColor = Color.FromArgb(19, 23, 29);
            diagnosisTextBox.BorderStyle = BorderStyle.None;
            diagnosisTextBox.DetectUrls = false;
            diagnosisTextBox.Dock = DockStyle.Fill;
            diagnosisTextBox.Font = new Font("Segoe UI", 12F);
            diagnosisTextBox.ForeColor = Color.FromArgb(227, 231, 235);
            diagnosisTextBox.Location = new Point(14, 44);
            diagnosisTextBox.Margin = new Padding(0);
            diagnosisTextBox.Name = "diagnosisTextBox";
            diagnosisTextBox.ReadOnly = true;
            diagnosisTextBox.Size = new Size(507, 356);
            diagnosisTextBox.TabIndex = 0;
            diagnosisTextBox.Text = resources.GetString("diagnosisTextBox.Text");
            // 
            // diagnosisHeader
            // 
            diagnosisHeader.Controls.Add(diagnosisTitleLabel);
            diagnosisHeader.Controls.Add(modelActions);
            diagnosisHeader.Dock = DockStyle.Top;
            diagnosisHeader.Location = new Point(14, 14);
            diagnosisHeader.Name = "diagnosisHeader";
            diagnosisHeader.Size = new Size(507, 30);
            diagnosisHeader.TabIndex = 0;
            // 
            // diagnosisTitleLabel
            // 
            diagnosisTitleLabel.Dock = DockStyle.Left;
            diagnosisTitleLabel.Font = new Font("Segoe UI", 11F);
            diagnosisTitleLabel.ForeColor = Color.FromArgb(236, 239, 242);
            diagnosisTitleLabel.Location = new Point(0, 0);
            diagnosisTitleLabel.Name = "diagnosisTitleLabel";
            diagnosisTitleLabel.Size = new Size(178, 30);
            diagnosisTitleLabel.TabIndex = 0;
            diagnosisTitleLabel.Text = "DIAGNÓSTICO DE IA";
            diagnosisTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // modelActions
            // 
            modelActions.Controls.Add(modelComboBox);
            modelActions.Dock = DockStyle.Right;
            modelActions.Location = new Point(222, 0);
            modelActions.Name = "modelActions";
            modelActions.Padding = new Padding(0, 0, 0, 2);
            modelActions.Size = new Size(285, 30);
            modelActions.TabIndex = 0;
            modelActions.WrapContents = false;
            // 
            // modelComboBox
            // 
            modelComboBox.BackColor = Color.FromArgb(25, 30, 37);
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelComboBox.FlatStyle = FlatStyle.Flat;
            modelComboBox.Font = new Font("Segoe UI", 10F);
            modelComboBox.ForeColor = Color.FromArgb(236, 239, 242);
            modelComboBox.Items.AddRange(new object[] { "Modelo Activo: [ Gemini Pro 1.5 ]", "GPT-4o", "Llama 3 70B", "Claude 3.5 Sonnet" });
            modelComboBox.Location = new Point(0, 0);
            modelComboBox.Margin = new Padding(0);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(285, 25);
            modelComboBox.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(197, 203, 210);
            statusLabel.Location = new Point(21, 823);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(1078, 27);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Estado: Listo  |  Puerto COM3 (115200, 8, N, 1)  |  Última respuesta: 1.4s";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 23, 29);
            ClientSize = new Size(1120, 860);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 720);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DETECTOR DE FALLAS - DIAGNÓSTICO SERIAL & IA";
            mainLayout.ResumeLayout(false);
            serialSettingsLayout.ResumeLayout(false);
            portField.ResumeLayout(false);
            baudField.ResumeLayout(false);
            serialActions.ResumeLayout(false);
            serialMonitorCard.ResumeLayout(false);
            monitorHeader.ResumeLayout(false);
            monitorActions.ResumeLayout(false);
            bottomLayout.ResumeLayout(false);
            promptCard.ResumeLayout(false);
            promptHeader.ResumeLayout(false);
            promptActions.ResumeLayout(false);
            diagnosisCard.ResumeLayout(false);
            diagnosisHeader.ResumeLayout(false);
            modelActions.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
