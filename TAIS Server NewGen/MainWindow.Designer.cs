namespace TAIS_Server_NewGen
{
    partial class MainWindow
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.amadeusTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.btnCebuPacificError = new System.Windows.Forms.Button();
            this.txtBoxCebuPacErrorPath = new System.Windows.Forms.TextBox();
            this.txtBoxSabreErrorPath = new System.Windows.Forms.TextBox();
            this.txtBoxAmadeusErrorPath = new System.Windows.Forms.TextBox();
            this.txtBoxLogs = new System.Windows.Forms.TextBox();
            this.txtBoxOtherInfoPath = new System.Windows.Forms.TextBox();
            this.txtBoxSpecialClientLocationPath = new System.Windows.Forms.TextBox();
            this.txtBoxSabreLocationPath = new System.Windows.Forms.TextBox();
            this.txtBoxCebuPacificLocationPath = new System.Windows.Forms.TextBox();
            this.txtBoxIASALocationPath = new System.Windows.Forms.TextBox();
            this.txtBoxIATALocationPath = new System.Windows.Forms.TextBox();
            this.txtBoxCebuPacificProcessedPath = new System.Windows.Forms.TextBox();
            this.txtBoxSabreProcessedPath = new System.Windows.Forms.TextBox();
            this.txtBoxAmadeusProcessedPath = new System.Windows.Forms.TextBox();
            this.txtBoxCebuPacificSourcePath = new System.Windows.Forms.TextBox();
            this.txtBoxSabreSourcePath = new System.Windows.Forms.TextBox();
            this.txtBoxAmadeusSource = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.btnSabreError = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAmadeusError = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnLogs = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.btnOtherInfoPath = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSpecialClientLocation = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.btnSabreLocationPath = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnCebuPacificLocationPath = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btnIATALocationPath = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCebuPacificProcessed = new System.Windows.Forms.Button();
            this.btnSabreProcessedPath = new System.Windows.Forms.Button();
            this.btnAmadeusProcessedPath = new System.Windows.Forms.Button();
            this.btnCebuPacificSourcePath = new System.Windows.Forms.Button();
            this.btnSabreSourcePath = new System.Windows.Forms.Button();
            this.btnAmadeusSource = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGW1 = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBoxClient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // amadeusTimer
            // 
            this.amadeusTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Running";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TAIS Server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.btnCebuPacificError);
            this.tabPage1.Controls.Add(this.txtBoxCebuPacErrorPath);
            this.tabPage1.Controls.Add(this.txtBoxSabreErrorPath);
            this.tabPage1.Controls.Add(this.txtBoxAmadeusErrorPath);
            this.tabPage1.Controls.Add(this.txtBoxLogs);
            this.tabPage1.Controls.Add(this.txtBoxOtherInfoPath);
            this.tabPage1.Controls.Add(this.txtBoxSpecialClientLocationPath);
            this.tabPage1.Controls.Add(this.txtBoxSabreLocationPath);
            this.tabPage1.Controls.Add(this.txtBoxCebuPacificLocationPath);
            this.tabPage1.Controls.Add(this.txtBoxIASALocationPath);
            this.tabPage1.Controls.Add(this.txtBoxIATALocationPath);
            this.tabPage1.Controls.Add(this.txtBoxCebuPacificProcessedPath);
            this.tabPage1.Controls.Add(this.txtBoxSabreProcessedPath);
            this.tabPage1.Controls.Add(this.txtBoxAmadeusProcessedPath);
            this.tabPage1.Controls.Add(this.txtBoxCebuPacificSourcePath);
            this.tabPage1.Controls.Add(this.txtBoxSabreSourcePath);
            this.tabPage1.Controls.Add(this.txtBoxAmadeusSource);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.btnSabreError);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnAmadeusError);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.btnLogs);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.btnOtherInfoPath);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.btnSpecialClientLocation);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.btnSabreLocationPath);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.btnCebuPacificLocationPath);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.btnIATALocationPath);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.btnHide);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.btnCebuPacificProcessed);
            this.tabPage1.Controls.Add(this.btnSabreProcessedPath);
            this.tabPage1.Controls.Add(this.btnAmadeusProcessedPath);
            this.tabPage1.Controls.Add(this.btnCebuPacificSourcePath);
            this.tabPage1.Controls.Add(this.btnSabreSourcePath);
            this.tabPage1.Controls.Add(this.btnAmadeusSource);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::TAIS_Server_NewGen.Properties.Resources.ellipsis;
            this.pictureBox.Location = new System.Drawing.Point(541, 284);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(36, 31);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label47.Location = new System.Drawing.Point(385, 210);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(117, 13);
            this.label47.TabIndex = 64;
            this.label47.Text = "Cebu Pacific Error Path";
            // 
            // btnCebuPacificError
            // 
            this.btnCebuPacificError.BackColor = System.Drawing.SystemColors.Control;
            this.btnCebuPacificError.FlatAppearance.BorderSize = 0;
            this.btnCebuPacificError.Location = new System.Drawing.Point(536, 207);
            this.btnCebuPacificError.Name = "btnCebuPacificError";
            this.btnCebuPacificError.Size = new System.Drawing.Size(31, 20);
            this.btnCebuPacificError.TabIndex = 63;
            this.btnCebuPacificError.Text = ". . .";
            this.btnCebuPacificError.UseVisualStyleBackColor = false;
            this.btnCebuPacificError.Click += new System.EventHandler(this.btnCebuPacificError_Click);
            // 
            // txtBoxCebuPacErrorPath
            // 
            this.txtBoxCebuPacErrorPath.BackColor = System.Drawing.Color.White;
            this.txtBoxCebuPacErrorPath.Enabled = false;
            this.txtBoxCebuPacErrorPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxCebuPacErrorPath.Location = new System.Drawing.Point(384, 232);
            this.txtBoxCebuPacErrorPath.Name = "txtBoxCebuPacErrorPath";
            this.txtBoxCebuPacErrorPath.Size = new System.Drawing.Size(183, 20);
            this.txtBoxCebuPacErrorPath.TabIndex = 62;
            // 
            // txtBoxSabreErrorPath
            // 
            this.txtBoxSabreErrorPath.BackColor = System.Drawing.Color.White;
            this.txtBoxSabreErrorPath.Enabled = false;
            this.txtBoxSabreErrorPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSabreErrorPath.Location = new System.Drawing.Point(196, 232);
            this.txtBoxSabreErrorPath.Name = "txtBoxSabreErrorPath";
            this.txtBoxSabreErrorPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSabreErrorPath.TabIndex = 59;
            // 
            // txtBoxAmadeusErrorPath
            // 
            this.txtBoxAmadeusErrorPath.BackColor = System.Drawing.Color.White;
            this.txtBoxAmadeusErrorPath.Enabled = false;
            this.txtBoxAmadeusErrorPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxAmadeusErrorPath.Location = new System.Drawing.Point(8, 232);
            this.txtBoxAmadeusErrorPath.Name = "txtBoxAmadeusErrorPath";
            this.txtBoxAmadeusErrorPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxAmadeusErrorPath.TabIndex = 56;
            // 
            // txtBoxLogs
            // 
            this.txtBoxLogs.BackColor = System.Drawing.Color.White;
            this.txtBoxLogs.Enabled = false;
            this.txtBoxLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxLogs.Location = new System.Drawing.Point(8, 282);
            this.txtBoxLogs.Name = "txtBoxLogs";
            this.txtBoxLogs.Size = new System.Drawing.Size(182, 20);
            this.txtBoxLogs.TabIndex = 40;
            // 
            // txtBoxOtherInfoPath
            // 
            this.txtBoxOtherInfoPath.BackColor = System.Drawing.Color.White;
            this.txtBoxOtherInfoPath.Enabled = false;
            this.txtBoxOtherInfoPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxOtherInfoPath.Location = new System.Drawing.Point(384, 181);
            this.txtBoxOtherInfoPath.Name = "txtBoxOtherInfoPath";
            this.txtBoxOtherInfoPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxOtherInfoPath.TabIndex = 37;
            // 
            // txtBoxSpecialClientLocationPath
            // 
            this.txtBoxSpecialClientLocationPath.BackColor = System.Drawing.Color.White;
            this.txtBoxSpecialClientLocationPath.Enabled = false;
            this.txtBoxSpecialClientLocationPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSpecialClientLocationPath.Location = new System.Drawing.Point(196, 181);
            this.txtBoxSpecialClientLocationPath.Name = "txtBoxSpecialClientLocationPath";
            this.txtBoxSpecialClientLocationPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSpecialClientLocationPath.TabIndex = 34;
            // 
            // txtBoxSabreLocationPath
            // 
            this.txtBoxSabreLocationPath.BackColor = System.Drawing.Color.White;
            this.txtBoxSabreLocationPath.Enabled = false;
            this.txtBoxSabreLocationPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSabreLocationPath.Location = new System.Drawing.Point(196, 133);
            this.txtBoxSabreLocationPath.Name = "txtBoxSabreLocationPath";
            this.txtBoxSabreLocationPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSabreLocationPath.TabIndex = 31;
            // 
            // txtBoxCebuPacificLocationPath
            // 
            this.txtBoxCebuPacificLocationPath.BackColor = System.Drawing.Color.White;
            this.txtBoxCebuPacificLocationPath.Enabled = false;
            this.txtBoxCebuPacificLocationPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxCebuPacificLocationPath.Location = new System.Drawing.Point(384, 133);
            this.txtBoxCebuPacificLocationPath.Name = "txtBoxCebuPacificLocationPath";
            this.txtBoxCebuPacificLocationPath.Size = new System.Drawing.Size(183, 20);
            this.txtBoxCebuPacificLocationPath.TabIndex = 28;
            // 
            // txtBoxIASALocationPath
            // 
            this.txtBoxIASALocationPath.BackColor = System.Drawing.Color.White;
            this.txtBoxIASALocationPath.Enabled = false;
            this.txtBoxIASALocationPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxIASALocationPath.Location = new System.Drawing.Point(8, 181);
            this.txtBoxIASALocationPath.Name = "txtBoxIASALocationPath";
            this.txtBoxIASALocationPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxIASALocationPath.TabIndex = 25;
            // 
            // txtBoxIATALocationPath
            // 
            this.txtBoxIATALocationPath.BackColor = System.Drawing.Color.White;
            this.txtBoxIATALocationPath.Enabled = false;
            this.txtBoxIATALocationPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxIATALocationPath.Location = new System.Drawing.Point(8, 133);
            this.txtBoxIATALocationPath.Name = "txtBoxIATALocationPath";
            this.txtBoxIATALocationPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxIATALocationPath.TabIndex = 22;
            // 
            // txtBoxCebuPacificProcessedPath
            // 
            this.txtBoxCebuPacificProcessedPath.BackColor = System.Drawing.Color.White;
            this.txtBoxCebuPacificProcessedPath.Enabled = false;
            this.txtBoxCebuPacificProcessedPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxCebuPacificProcessedPath.Location = new System.Drawing.Point(384, 81);
            this.txtBoxCebuPacificProcessedPath.Name = "txtBoxCebuPacificProcessedPath";
            this.txtBoxCebuPacificProcessedPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxCebuPacificProcessedPath.TabIndex = 10;
            // 
            // txtBoxSabreProcessedPath
            // 
            this.txtBoxSabreProcessedPath.BackColor = System.Drawing.Color.White;
            this.txtBoxSabreProcessedPath.Enabled = false;
            this.txtBoxSabreProcessedPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSabreProcessedPath.Location = new System.Drawing.Point(196, 81);
            this.txtBoxSabreProcessedPath.Name = "txtBoxSabreProcessedPath";
            this.txtBoxSabreProcessedPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSabreProcessedPath.TabIndex = 8;
            // 
            // txtBoxAmadeusProcessedPath
            // 
            this.txtBoxAmadeusProcessedPath.BackColor = System.Drawing.Color.White;
            this.txtBoxAmadeusProcessedPath.Enabled = false;
            this.txtBoxAmadeusProcessedPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxAmadeusProcessedPath.Location = new System.Drawing.Point(8, 81);
            this.txtBoxAmadeusProcessedPath.Name = "txtBoxAmadeusProcessedPath";
            this.txtBoxAmadeusProcessedPath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxAmadeusProcessedPath.TabIndex = 6;
            this.txtBoxAmadeusProcessedPath.TextChanged += new System.EventHandler(this.txtBoxAmadeusProcessedPath_TextChanged);
            // 
            // txtBoxCebuPacificSourcePath
            // 
            this.txtBoxCebuPacificSourcePath.BackColor = System.Drawing.Color.White;
            this.txtBoxCebuPacificSourcePath.Enabled = false;
            this.txtBoxCebuPacificSourcePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxCebuPacificSourcePath.Location = new System.Drawing.Point(384, 33);
            this.txtBoxCebuPacificSourcePath.Name = "txtBoxCebuPacificSourcePath";
            this.txtBoxCebuPacificSourcePath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxCebuPacificSourcePath.TabIndex = 4;
            // 
            // txtBoxSabreSourcePath
            // 
            this.txtBoxSabreSourcePath.BackColor = System.Drawing.Color.White;
            this.txtBoxSabreSourcePath.Enabled = false;
            this.txtBoxSabreSourcePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSabreSourcePath.Location = new System.Drawing.Point(196, 34);
            this.txtBoxSabreSourcePath.Name = "txtBoxSabreSourcePath";
            this.txtBoxSabreSourcePath.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSabreSourcePath.TabIndex = 2;
            // 
            // txtBoxAmadeusSource
            // 
            this.txtBoxAmadeusSource.BackColor = System.Drawing.Color.White;
            this.txtBoxAmadeusSource.Enabled = false;
            this.txtBoxAmadeusSource.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxAmadeusSource.Location = new System.Drawing.Point(8, 34);
            this.txtBoxAmadeusSource.Name = "txtBoxAmadeusSource";
            this.txtBoxAmadeusSource.Size = new System.Drawing.Size(182, 20);
            this.txtBoxAmadeusSource.TabIndex = 0;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label46.Location = new System.Drawing.Point(197, 214);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 13);
            this.label46.TabIndex = 61;
            this.label46.Text = "Sabre Error Path";
            // 
            // btnSabreError
            // 
            this.btnSabreError.BackColor = System.Drawing.SystemColors.Control;
            this.btnSabreError.FlatAppearance.BorderSize = 0;
            this.btnSabreError.Location = new System.Drawing.Point(347, 206);
            this.btnSabreError.Name = "btnSabreError";
            this.btnSabreError.Size = new System.Drawing.Size(31, 20);
            this.btnSabreError.TabIndex = 60;
            this.btnSabreError.Text = ". . .";
            this.btnSabreError.UseVisualStyleBackColor = false;
            this.btnSabreError.Click += new System.EventHandler(this.btnSabreError_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Amadeus Error Path";
            // 
            // btnAmadeusError
            // 
            this.btnAmadeusError.BackColor = System.Drawing.SystemColors.Control;
            this.btnAmadeusError.FlatAppearance.BorderSize = 0;
            this.btnAmadeusError.Location = new System.Drawing.Point(159, 207);
            this.btnAmadeusError.Name = "btnAmadeusError";
            this.btnAmadeusError.Size = new System.Drawing.Size(31, 20);
            this.btnAmadeusError.TabIndex = 57;
            this.btnAmadeusError.Text = ". . .";
            this.btnAmadeusError.UseVisualStyleBackColor = false;
            this.btnAmadeusError.Click += new System.EventHandler(this.btnAmadeusError_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(6, 266);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(30, 13);
            this.label45.TabIndex = 55;
            this.label45.Text = "Logs";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label44.Location = new System.Drawing.Point(385, 165);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 13);
            this.label44.TabIndex = 54;
            this.label44.Text = "Other";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label43.Location = new System.Drawing.Point(197, 165);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(115, 13);
            this.label43.TabIndex = 53;
            this.label43.Text = "Special Client Location";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label42.Location = new System.Drawing.Point(197, 114);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(104, 13);
            this.label42.TabIndex = 52;
            this.label42.Text = "Sabre Location Path";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label41.Location = new System.Drawing.Point(385, 114);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(136, 13);
            this.label41.TabIndex = 51;
            this.label41.Text = "Cebu Pacific Location Path";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(9, 165);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(100, 13);
            this.label40.TabIndex = 50;
            this.label40.Text = "IASA Location Path";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label39.Location = new System.Drawing.Point(8, 114);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 13);
            this.label39.TabIndex = 49;
            this.label39.Text = "IATA Location Path";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label38.Location = new System.Drawing.Point(385, 62);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(145, 13);
            this.label38.TabIndex = 48;
            this.label38.Text = "Cebu Pacific Processed Path";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label37.Location = new System.Drawing.Point(197, 62);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 13);
            this.label37.TabIndex = 47;
            this.label37.Text = "Sabre Processed Path";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label36.Location = new System.Drawing.Point(8, 65);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(129, 13);
            this.label36.TabIndex = 46;
            this.label36.Text = "Amadeus Processed Path";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label35.Location = new System.Drawing.Point(385, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(129, 13);
            this.label35.TabIndex = 45;
            this.label35.Text = "Cebu Pacific Source Path";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label34.Location = new System.Drawing.Point(197, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Sabre Source Path";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(8, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "Amadeus Source Path";
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.Location = new System.Drawing.Point(159, 258);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(31, 20);
            this.btnLogs.TabIndex = 42;
            this.btnLogs.Text = ". . .";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(8, 500);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 13);
            this.label31.TabIndex = 41;
            // 
            // btnOtherInfoPath
            // 
            this.btnOtherInfoPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnOtherInfoPath.FlatAppearance.BorderSize = 0;
            this.btnOtherInfoPath.Location = new System.Drawing.Point(536, 158);
            this.btnOtherInfoPath.Name = "btnOtherInfoPath";
            this.btnOtherInfoPath.Size = new System.Drawing.Size(31, 20);
            this.btnOtherInfoPath.TabIndex = 39;
            this.btnOtherInfoPath.Text = ". . .";
            this.btnOtherInfoPath.UseVisualStyleBackColor = false;
            this.btnOtherInfoPath.Click += new System.EventHandler(this.btnOtherInfoPath_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(8, 461);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 13);
            this.label30.TabIndex = 38;
            // 
            // btnSpecialClientLocation
            // 
            this.btnSpecialClientLocation.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpecialClientLocation.FlatAppearance.BorderSize = 0;
            this.btnSpecialClientLocation.Location = new System.Drawing.Point(347, 158);
            this.btnSpecialClientLocation.Name = "btnSpecialClientLocation";
            this.btnSpecialClientLocation.Size = new System.Drawing.Size(31, 20);
            this.btnSpecialClientLocation.TabIndex = 36;
            this.btnSpecialClientLocation.Text = ". . .";
            this.btnSpecialClientLocation.UseVisualStyleBackColor = false;
            this.btnSpecialClientLocation.Click += new System.EventHandler(this.btnSpecialClientLocation_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(8, 422);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 13);
            this.label29.TabIndex = 35;
            // 
            // btnSabreLocationPath
            // 
            this.btnSabreLocationPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnSabreLocationPath.FlatAppearance.BorderSize = 0;
            this.btnSabreLocationPath.Location = new System.Drawing.Point(347, 110);
            this.btnSabreLocationPath.Name = "btnSabreLocationPath";
            this.btnSabreLocationPath.Size = new System.Drawing.Size(31, 20);
            this.btnSabreLocationPath.TabIndex = 33;
            this.btnSabreLocationPath.Text = ". . .";
            this.btnSabreLocationPath.UseVisualStyleBackColor = false;
            this.btnSabreLocationPath.Click += new System.EventHandler(this.btnSabreLocationPath_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(8, 382);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 13);
            this.label28.TabIndex = 32;
            // 
            // btnCebuPacificLocationPath
            // 
            this.btnCebuPacificLocationPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnCebuPacificLocationPath.FlatAppearance.BorderSize = 0;
            this.btnCebuPacificLocationPath.Location = new System.Drawing.Point(535, 110);
            this.btnCebuPacificLocationPath.Name = "btnCebuPacificLocationPath";
            this.btnCebuPacificLocationPath.Size = new System.Drawing.Size(31, 20);
            this.btnCebuPacificLocationPath.TabIndex = 30;
            this.btnCebuPacificLocationPath.Text = ". . .";
            this.btnCebuPacificLocationPath.UseVisualStyleBackColor = false;
            this.btnCebuPacificLocationPath.Click += new System.EventHandler(this.btnCebuPacificLocationPath_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(8, 342);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 29;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Control;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.Location = new System.Drawing.Point(159, 158);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(31, 20);
            this.button19.TabIndex = 27;
            this.button19.Text = ". . .";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(8, 302);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 26;
            // 
            // btnIATALocationPath
            // 
            this.btnIATALocationPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnIATALocationPath.FlatAppearance.BorderSize = 0;
            this.btnIATALocationPath.Location = new System.Drawing.Point(159, 110);
            this.btnIATALocationPath.Name = "btnIATALocationPath";
            this.btnIATALocationPath.Size = new System.Drawing.Size(31, 20);
            this.btnIATALocationPath.TabIndex = 24;
            this.btnIATALocationPath.Text = ". . .";
            this.btnIATALocationPath.UseVisualStyleBackColor = false;
            this.btnIATALocationPath.Click += new System.EventHandler(this.btnIATALocationPath_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(8, 259);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 23;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(186)))));
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(288, 277);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(82, 22);
            this.btnHide.TabIndex = 20;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Salmon;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(453, 277);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 22);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Location = new System.Drawing.Point(200, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 22);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCebuPacificProcessed
            // 
            this.btnCebuPacificProcessed.BackColor = System.Drawing.SystemColors.Control;
            this.btnCebuPacificProcessed.FlatAppearance.BorderSize = 0;
            this.btnCebuPacificProcessed.Location = new System.Drawing.Point(536, 58);
            this.btnCebuPacificProcessed.Name = "btnCebuPacificProcessed";
            this.btnCebuPacificProcessed.Size = new System.Drawing.Size(31, 20);
            this.btnCebuPacificProcessed.TabIndex = 17;
            this.btnCebuPacificProcessed.Text = ". . .";
            this.btnCebuPacificProcessed.UseVisualStyleBackColor = false;
            this.btnCebuPacificProcessed.Click += new System.EventHandler(this.btnCebuPacificProcessed_Click);
            // 
            // btnSabreProcessedPath
            // 
            this.btnSabreProcessedPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnSabreProcessedPath.FlatAppearance.BorderSize = 0;
            this.btnSabreProcessedPath.Location = new System.Drawing.Point(347, 58);
            this.btnSabreProcessedPath.Name = "btnSabreProcessedPath";
            this.btnSabreProcessedPath.Size = new System.Drawing.Size(31, 20);
            this.btnSabreProcessedPath.TabIndex = 16;
            this.btnSabreProcessedPath.Text = ". . .";
            this.btnSabreProcessedPath.UseVisualStyleBackColor = false;
            this.btnSabreProcessedPath.Click += new System.EventHandler(this.btnSabreProcessedPath_Click);
            // 
            // btnAmadeusProcessedPath
            // 
            this.btnAmadeusProcessedPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnAmadeusProcessedPath.FlatAppearance.BorderSize = 0;
            this.btnAmadeusProcessedPath.Location = new System.Drawing.Point(159, 58);
            this.btnAmadeusProcessedPath.Name = "btnAmadeusProcessedPath";
            this.btnAmadeusProcessedPath.Size = new System.Drawing.Size(31, 20);
            this.btnAmadeusProcessedPath.TabIndex = 15;
            this.btnAmadeusProcessedPath.Text = ". . .";
            this.btnAmadeusProcessedPath.UseVisualStyleBackColor = false;
            this.btnAmadeusProcessedPath.Click += new System.EventHandler(this.btnAmadeusProcessedPath_Click);
            // 
            // btnCebuPacificSourcePath
            // 
            this.btnCebuPacificSourcePath.BackColor = System.Drawing.SystemColors.Control;
            this.btnCebuPacificSourcePath.FlatAppearance.BorderSize = 0;
            this.btnCebuPacificSourcePath.Location = new System.Drawing.Point(535, 8);
            this.btnCebuPacificSourcePath.Name = "btnCebuPacificSourcePath";
            this.btnCebuPacificSourcePath.Size = new System.Drawing.Size(31, 20);
            this.btnCebuPacificSourcePath.TabIndex = 14;
            this.btnCebuPacificSourcePath.Text = ". . .";
            this.btnCebuPacificSourcePath.UseVisualStyleBackColor = false;
            this.btnCebuPacificSourcePath.Click += new System.EventHandler(this.btnCebuPacificSourcePath_Click);
            // 
            // btnSabreSourcePath
            // 
            this.btnSabreSourcePath.BackColor = System.Drawing.SystemColors.Control;
            this.btnSabreSourcePath.FlatAppearance.BorderSize = 0;
            this.btnSabreSourcePath.Location = new System.Drawing.Point(347, 8);
            this.btnSabreSourcePath.Name = "btnSabreSourcePath";
            this.btnSabreSourcePath.Size = new System.Drawing.Size(31, 20);
            this.btnSabreSourcePath.TabIndex = 13;
            this.btnSabreSourcePath.Text = ". . .";
            this.btnSabreSourcePath.UseVisualStyleBackColor = false;
            this.btnSabreSourcePath.Click += new System.EventHandler(this.btnSabreSourcePath_Click);
            // 
            // btnAmadeusSource
            // 
            this.btnAmadeusSource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAmadeusSource.FlatAppearance.BorderSize = 0;
            this.btnAmadeusSource.Location = new System.Drawing.Point(159, 8);
            this.btnAmadeusSource.Name = "btnAmadeusSource";
            this.btnAmadeusSource.Size = new System.Drawing.Size(31, 20);
            this.btnAmadeusSource.TabIndex = 12;
            this.btnAmadeusSource.Text = ". . .";
            this.btnAmadeusSource.UseVisualStyleBackColor = false;
            this.btnAmadeusSource.Click += new System.EventHandler(this.btnAmadeusSource_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 345);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.DGW1);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmbBoxClient);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Special Client Condition";
            // 
            // DGW1
            // 
            this.DGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGW1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGW1.Enabled = false;
            this.DGW1.Location = new System.Drawing.Point(11, 99);
            this.DGW1.Name = "DGW1";
            this.DGW1.Size = new System.Drawing.Size(332, 51);
            this.DGW1.TabIndex = 21;
            this.DGW1.Visible = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Salmon;
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(349, 156);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 20);
            this.button12.TabIndex = 20;
            this.button12.Text = "Delete";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(349, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 20);
            this.button11.TabIndex = 19;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.Enabled = false;
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(11, 156);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(332, 20);
            this.textBox8.TabIndex = 5;
            this.textBox8.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Enabled = false;
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(11, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(332, 20);
            this.textBox7.TabIndex = 2;
            this.textBox7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(8, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 4;
            // 
            // cmbBoxClient
            // 
            this.cmbBoxClient.BackColor = System.Drawing.SystemColors.Control;
            this.cmbBoxClient.Enabled = false;
            this.cmbBoxClient.ForeColor = System.Drawing.Color.Black;
            this.cmbBoxClient.FormattingEnabled = true;
            this.cmbBoxClient.Location = new System.Drawing.Point(11, 35);
            this.cmbBoxClient.Name = "cmbBoxClient";
            this.cmbBoxClient.Size = new System.Drawing.Size(332, 21);
            this.cmbBoxClient.TabIndex = 1;
            this.cmbBoxClient.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(8, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(586, 345);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIR Parser 4.3";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer amadeusTimer;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label label47;
        public System.Windows.Forms.Button btnCebuPacificError;
        public System.Windows.Forms.TextBox txtBoxCebuPacErrorPath;
        public System.Windows.Forms.TextBox txtBoxSabreErrorPath;
        public System.Windows.Forms.TextBox txtBoxAmadeusErrorPath;
        public System.Windows.Forms.TextBox txtBoxLogs;
        public System.Windows.Forms.TextBox txtBoxOtherInfoPath;
        public System.Windows.Forms.TextBox txtBoxSpecialClientLocationPath;
        public System.Windows.Forms.TextBox txtBoxSabreLocationPath;
        public System.Windows.Forms.TextBox txtBoxCebuPacificLocationPath;
        public System.Windows.Forms.TextBox txtBoxIASALocationPath;
        public System.Windows.Forms.TextBox txtBoxIATALocationPath;
        public System.Windows.Forms.TextBox txtBoxCebuPacificProcessedPath;
        public System.Windows.Forms.TextBox txtBoxSabreProcessedPath;
        public System.Windows.Forms.TextBox txtBoxAmadeusProcessedPath;
        public System.Windows.Forms.TextBox txtBoxCebuPacificSourcePath;
        public System.Windows.Forms.TextBox txtBoxSabreSourcePath;
        public System.Windows.Forms.TextBox txtBoxAmadeusSource;
        public System.Windows.Forms.Label label46;
        public System.Windows.Forms.Button btnSabreError;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnAmadeusError;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Label label45;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label label35;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Button btnLogs;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.Button btnOtherInfoPath;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Button btnSpecialClientLocation;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Button btnSabreLocationPath;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Button btnCebuPacificLocationPath;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Button button19;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Button btnIATALocationPath;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Button btnHide;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnCebuPacificProcessed;
        public System.Windows.Forms.Button btnSabreProcessedPath;
        public System.Windows.Forms.Button btnAmadeusProcessedPath;
        public System.Windows.Forms.Button btnCebuPacificSourcePath;
        public System.Windows.Forms.Button btnSabreSourcePath;
        public System.Windows.Forms.Button btnAmadeusSource;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbBoxClient;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView DGW1;
    }
}