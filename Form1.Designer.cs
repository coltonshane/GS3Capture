namespace FlyCapture2SimpleGUI_CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCameraControl = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFrameRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimestamp = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRawSize = new System.Windows.Forms.Label();
            this.nudBufferFrames = new System.Windows.Forms.NumericUpDown();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.lblBufferSeconds = new System.Windows.Forms.Label();
            this.lblBufferGB = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFramesBuffered = new System.Windows.Forms.Label();
            this.nudDD = new System.Windows.Forms.NumericUpDown();
            this.lblDD = new System.Windows.Forms.Label();
            this.chkAuto30Hz = new System.Windows.Forms.CheckBox();
            this.picBuffer = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkContSave = new System.Windows.Forms.CheckBox();
            this.nudDiv = new System.Windows.Forms.NumericUpDown();
            this.lblFPS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFPSd = new System.Windows.Forms.Label();
            this.lblPXd = new System.Windows.Forms.Label();
            this.lblBITd = new System.Windows.Forms.Label();
            this.lblShutterd = new System.Windows.Forms.Label();
            this.lblGaind = new System.Windows.Forms.Label();
            this.btnShutterDown = new System.Windows.Forms.Button();
            this.btnShutterUp = new System.Windows.Forms.Button();
            this.rdoShutterAngle = new System.Windows.Forms.RadioButton();
            this.rdoShutterTime = new System.Windows.Forms.RadioButton();
            this.pbShutter = new System.Windows.Forms.PictureBox();
            this.lblShutterl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRecording = new System.Windows.Forms.Label();
            this.lblGainl = new System.Windows.Forms.Label();
            this.rdoGainISO = new System.Windows.Forms.RadioButton();
            this.rdoGainDB = new System.Windows.Forms.RadioButton();
            this.btnGainUp = new System.Windows.Forms.Button();
            this.btnGainDown = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblFormatl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBlueUp = new System.Windows.Forms.Button();
            this.btnBlueDown = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRedUp = new System.Windows.Forms.Button();
            this.btnRedDown = new System.Windows.Forms.Button();
            this.lblBlued = new System.Windows.Forms.Label();
            this.lblRedd = new System.Windows.Forms.Label();
            this.lblColorTempd = new System.Windows.Forms.Label();
            this.chkWBSpot = new System.Windows.Forms.CheckBox();
            this.picHistFrame = new System.Windows.Forms.PictureBox();
            this.picHist = new System.Windows.Forms.PictureBox();
            this.lblHistl = new System.Windows.Forms.Label();
            this.chkHistOn = new System.Windows.Forms.CheckBox();
            this.btnBusUp = new System.Windows.Forms.Button();
            this.btnBusDown = new System.Windows.Forms.Button();
            this.lblBusd = new System.Windows.Forms.Label();
            this.btnBlueUpUp = new System.Windows.Forms.Button();
            this.btnBlueDownDown = new System.Windows.Forms.Button();
            this.btnRedDownDown = new System.Windows.Forms.Button();
            this.btnRedUpUp = new System.Windows.Forms.Button();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.lblDiag = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.chkRaw = new System.Windows.Forms.CheckBox();
            this.nudGamma = new System.Windows.Forms.NumericUpDown();
            this.lblGamma = new System.Windows.Forms.Label();
            this.btnGammaUp = new System.Windows.Forms.Button();
            this.btnGammaDown = new System.Windows.Forms.Button();
            this.chkClip = new System.Windows.Forms.CheckBox();
            this.btnBrightnessUp = new System.Windows.Forms.Button();
            this.btnBrightnessDown = new System.Windows.Forms.Button();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.btnContrastUp = new System.Windows.Forms.Button();
            this.btnContrastDown = new System.Windows.Forms.Button();
            this.lblContrast = new System.Windows.Forms.Label();
            this.nudContrast = new System.Windows.Forms.NumericUpDown();
            this.btnSaturationUp = new System.Windows.Forms.Button();
            this.btnSaturationDown = new System.Windows.Forms.Button();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.nudSaturation = new System.Windows.Forms.NumericUpDown();
            this.btnSharpnessUp = new System.Windows.Forms.Button();
            this.btnSharpnessDown = new System.Windows.Forms.Button();
            this.lblSharpness = new System.Windows.Forms.Label();
            this.nudSharpness = new System.Windows.Forms.NumericUpDown();
            this.lblBufferFrames = new System.Windows.Forms.Label();
            this.btnTrig = new System.Windows.Forms.Button();
            this.btnBufferUp = new System.Windows.Forms.Button();
            this.btnBufferDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBGSaveDivUp = new System.Windows.Forms.Button();
            this.btnBGSaveDivDn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.trkTrigger = new System.Windows.Forms.TrackBar();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.nudFR = new System.Windows.Forms.NumericUpDown();
            this.btnFRUp = new System.Windows.Forms.Button();
            this.btnFRDown = new System.Windows.Forms.Button();
            this.rdo30fps = new System.Windows.Forms.RadioButton();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.btnResUp = new System.Windows.Forms.Button();
            this.btnResDown = new System.Windows.Forms.Button();
            this.pnlShutter = new System.Windows.Forms.Panel();
            this.pnlGain = new System.Windows.Forms.Panel();
            this.rdo24fps = new System.Windows.Forms.RadioButton();
            this.pnlFR = new System.Windows.Forms.Panel();
            this.btnChangeFormat = new System.Windows.Forms.Button();
            this.pnlBit = new System.Windows.Forms.Panel();
            this.rdo12bit = new System.Windows.Forms.RadioButton();
            this.rdo8bit = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBufferFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShutter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSharpness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFR)).BeginInit();
            this.pnlShutter.SuspendLayout();
            this.pnlGain.SuspendLayout();
            this.pnlFR.SuspendLayout();
            this.pnlBit.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripButtonCameraControl});
            this.toolStrip1.Location = new System.Drawing.Point(937, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(120, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Play";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCameraControl
            // 
            this.toolStripButtonCameraControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCameraControl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCameraControl.Image")));
            this.toolStripButtonCameraControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCameraControl.Name = "toolStripButtonCameraControl";
            this.toolStripButtonCameraControl.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCameraControl.Text = "Controls";
            this.toolStripButtonCameraControl.Click += new System.EventHandler(this.toolStripButtonCameraControl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImageSize,
            this.toolStripStatusLabelFrameRate,
            this.toolStripStatusLabelTimestamp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 779);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1514, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelImageSize
            // 
            this.toolStripStatusLabelImageSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelImageSize.Name = "toolStripStatusLabelImageSize";
            this.toolStripStatusLabelImageSize.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabelImageSize.Text = "0x0";
            // 
            // toolStripStatusLabelFrameRate
            // 
            this.toolStripStatusLabelFrameRate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelFrameRate.Name = "toolStripStatusLabelFrameRate";
            this.toolStripStatusLabelFrameRate.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelFrameRate.Text = "0.00Hz";
            // 
            // toolStripStatusLabelTimestamp
            // 
            this.toolStripStatusLabelTimestamp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelTimestamp.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelTimestamp.Name = "toolStripStatusLabelTimestamp";
            this.toolStripStatusLabelTimestamp.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabelTimestamp.Text = "Camera not started";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1514, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCameraToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCameraToolStripMenuItem
            // 
            this.newCameraToolStripMenuItem.Name = "newCameraToolStripMenuItem";
            this.newCameraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newCameraToolStripMenuItem.Text = "New camera";
            this.newCameraToolStripMenuItem.Click += new System.EventHandler(this.OnNewCameraClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1152, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lblRawSize
            // 
            this.lblRawSize.AutoSize = true;
            this.lblRawSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRawSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawSize.ForeColor = System.Drawing.Color.White;
            this.lblRawSize.Location = new System.Drawing.Point(1189, 56);
            this.lblRawSize.Name = "lblRawSize";
            this.lblRawSize.Size = new System.Drawing.Size(129, 20);
            this.lblRawSize.TabIndex = 4;
            this.lblRawSize.Text = "Raw Image BPP:";
            // 
            // nudBufferFrames
            // 
            this.nudBufferFrames.BackColor = System.Drawing.Color.DimGray;
            this.nudBufferFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBufferFrames.ForeColor = System.Drawing.Color.White;
            this.nudBufferFrames.Location = new System.Drawing.Point(1258, 88);
            this.nudBufferFrames.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudBufferFrames.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBufferFrames.Name = "nudBufferFrames";
            this.nudBufferFrames.Size = new System.Drawing.Size(100, 38);
            this.nudBufferFrames.TabIndex = 7;
            this.nudBufferFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBufferFrames.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBufferFrames.ValueChanged += new System.EventHandler(this.nudBufferFrames_ValueChanged);
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferSize.ForeColor = System.Drawing.Color.White;
            this.lblBufferSize.Location = new System.Drawing.Point(1195, 100);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(57, 20);
            this.lblBufferSize.TabIndex = 9;
            this.lblBufferSize.Text = "Buffer:";
            this.lblBufferSize.Click += new System.EventHandler(this.lblBufferSize_Click);
            // 
            // lblBufferSeconds
            // 
            this.lblBufferSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferSeconds.ForeColor = System.Drawing.Color.White;
            this.lblBufferSeconds.Location = new System.Drawing.Point(1356, 183);
            this.lblBufferSeconds.Name = "lblBufferSeconds";
            this.lblBufferSeconds.Size = new System.Drawing.Size(138, 20);
            this.lblBufferSeconds.TabIndex = 10;
            this.lblBufferSeconds.Text = "[s]";
            this.lblBufferSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBufferGB
            // 
            this.lblBufferGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferGB.ForeColor = System.Drawing.Color.White;
            this.lblBufferGB.Location = new System.Drawing.Point(1372, 156);
            this.lblBufferGB.Name = "lblBufferGB";
            this.lblBufferGB.Size = new System.Drawing.Size(122, 20);
            this.lblBufferGB.TabIndex = 11;
            this.lblBufferGB.Text = "[GB]";
            this.lblBufferGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(1185, 392);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 50);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // lblFramesBuffered
            // 
            this.lblFramesBuffered.AutoSize = true;
            this.lblFramesBuffered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFramesBuffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFramesBuffered.ForeColor = System.Drawing.Color.White;
            this.lblFramesBuffered.Location = new System.Drawing.Point(1388, 251);
            this.lblFramesBuffered.Name = "lblFramesBuffered";
            this.lblFramesBuffered.Size = new System.Drawing.Size(102, 60);
            this.lblFramesBuffered.TabIndex = 13;
            this.lblFramesBuffered.Text = "Frame In: 0\r\nFrame Out: 0\r\nDiff: 0";
            this.lblFramesBuffered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudDD
            // 
            this.nudDD.BackColor = System.Drawing.Color.DimGray;
            this.nudDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDD.ForeColor = System.Drawing.Color.White;
            this.nudDD.Location = new System.Drawing.Point(495, 538);
            this.nudDD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDD.Name = "nudDD";
            this.nudDD.Size = new System.Drawing.Size(48, 26);
            this.nudDD.TabIndex = 16;
            this.nudDD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDD
            // 
            this.lblDD.AutoSize = true;
            this.lblDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDD.ForeColor = System.Drawing.Color.White;
            this.lblDD.Location = new System.Drawing.Point(373, 540);
            this.lblDD.Name = "lblDD";
            this.lblDD.Size = new System.Drawing.Size(116, 20);
            this.lblDD.TabIndex = 17;
            this.lblDD.Text = "Display Divider:";
            // 
            // chkAuto30Hz
            // 
            this.chkAuto30Hz.AutoSize = true;
            this.chkAuto30Hz.Checked = true;
            this.chkAuto30Hz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto30Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto30Hz.ForeColor = System.Drawing.Color.White;
            this.chkAuto30Hz.Location = new System.Drawing.Point(549, 540);
            this.chkAuto30Hz.Name = "chkAuto30Hz";
            this.chkAuto30Hz.Size = new System.Drawing.Size(104, 24);
            this.chkAuto30Hz.TabIndex = 18;
            this.chkAuto30Hz.Text = "Auto 30Hz";
            this.chkAuto30Hz.UseVisualStyleBackColor = true;
            // 
            // picBuffer
            // 
            this.picBuffer.BackColor = System.Drawing.Color.DimGray;
            this.picBuffer.Location = new System.Drawing.Point(1189, 218);
            this.picBuffer.Name = "picBuffer";
            this.picBuffer.Size = new System.Drawing.Size(301, 30);
            this.picBuffer.TabIndex = 19;
            this.picBuffer.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1185, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkContSave
            // 
            this.chkContSave.AutoSize = true;
            this.chkContSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkContSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContSave.ForeColor = System.Drawing.Color.White;
            this.chkContSave.Location = new System.Drawing.Point(1185, 518);
            this.chkContSave.Name = "chkContSave";
            this.chkContSave.Size = new System.Drawing.Size(218, 29);
            this.chkContSave.TabIndex = 26;
            this.chkContSave.Text = "Background Saving";
            this.chkContSave.UseVisualStyleBackColor = false;
            this.chkContSave.CheckedChanged += new System.EventHandler(this.chkContSave_CheckedChanged);
            // 
            // nudDiv
            // 
            this.nudDiv.BackColor = System.Drawing.Color.DimGray;
            this.nudDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiv.ForeColor = System.Drawing.Color.White;
            this.nudDiv.Location = new System.Drawing.Point(1295, 555);
            this.nudDiv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiv.Name = "nudDiv";
            this.nudDiv.Size = new System.Drawing.Size(63, 38);
            this.nudDiv.TabIndex = 32;
            this.nudDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDiv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiv.ValueChanged += new System.EventHandler(this.nudDiv_ValueChanged);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPS.ForeColor = System.Drawing.Color.White;
            this.lblFPS.Location = new System.Drawing.Point(452, 603);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(101, 25);
            this.lblFPS.TabIndex = 43;
            this.lblFPS.Text = "= 150 fps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "px";
            // 
            // lblFPSd
            // 
            this.lblFPSd.BackColor = System.Drawing.Color.Black;
            this.lblFPSd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFPSd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPSd.ForeColor = System.Drawing.Color.White;
            this.lblFPSd.Location = new System.Drawing.Point(282, 28);
            this.lblFPSd.Name = "lblFPSd";
            this.lblFPSd.Size = new System.Drawing.Size(116, 23);
            this.lblFPSd.TabIndex = 53;
            this.lblFPSd.Text = "150FPS";
            this.lblFPSd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPXd
            // 
            this.lblPXd.BackColor = System.Drawing.Color.Black;
            this.lblPXd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPXd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPXd.ForeColor = System.Drawing.Color.White;
            this.lblPXd.Location = new System.Drawing.Point(12, 28);
            this.lblPXd.Name = "lblPXd";
            this.lblPXd.Size = new System.Drawing.Size(142, 23);
            this.lblPXd.TabIndex = 54;
            this.lblPXd.Text = "1920x1200";
            this.lblPXd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBITd
            // 
            this.lblBITd.BackColor = System.Drawing.Color.Black;
            this.lblBITd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBITd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBITd.ForeColor = System.Drawing.Color.White;
            this.lblBITd.Location = new System.Drawing.Point(160, 28);
            this.lblBITd.Name = "lblBITd";
            this.lblBITd.Size = new System.Drawing.Size(116, 23);
            this.lblBITd.TabIndex = 55;
            this.lblBITd.Text = "8-bit";
            this.lblBITd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShutterd
            // 
            this.lblShutterd.BackColor = System.Drawing.Color.Black;
            this.lblShutterd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShutterd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutterd.ForeColor = System.Drawing.Color.White;
            this.lblShutterd.Location = new System.Drawing.Point(404, 28);
            this.lblShutterd.Name = "lblShutterd";
            this.lblShutterd.Size = new System.Drawing.Size(126, 23);
            this.lblShutterd.TabIndex = 56;
            this.lblShutterd.Text = "180º";
            this.lblShutterd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaind
            // 
            this.lblGaind.BackColor = System.Drawing.Color.Black;
            this.lblGaind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaind.ForeColor = System.Drawing.Color.White;
            this.lblGaind.Location = new System.Drawing.Point(536, 28);
            this.lblGaind.Name = "lblGaind";
            this.lblGaind.Size = new System.Drawing.Size(117, 23);
            this.lblGaind.TabIndex = 57;
            this.lblGaind.Text = "+0dB";
            this.lblGaind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutterDown
            // 
            this.btnShutterDown.BackColor = System.Drawing.Color.LightGray;
            this.btnShutterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterDown.Location = new System.Drawing.Point(907, 82);
            this.btnShutterDown.Name = "btnShutterDown";
            this.btnShutterDown.Size = new System.Drawing.Size(62, 38);
            this.btnShutterDown.TabIndex = 59;
            this.btnShutterDown.Text = "-";
            this.btnShutterDown.UseVisualStyleBackColor = false;
            this.btnShutterDown.Click += new System.EventHandler(this.btnShutterDown_Click);
            // 
            // btnShutterUp
            // 
            this.btnShutterUp.BackColor = System.Drawing.Color.LightGray;
            this.btnShutterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterUp.Location = new System.Drawing.Point(975, 82);
            this.btnShutterUp.Name = "btnShutterUp";
            this.btnShutterUp.Size = new System.Drawing.Size(62, 38);
            this.btnShutterUp.TabIndex = 60;
            this.btnShutterUp.Text = "+";
            this.btnShutterUp.UseVisualStyleBackColor = false;
            this.btnShutterUp.Click += new System.EventHandler(this.btnShutterUp_Click);
            // 
            // rdoShutterAngle
            // 
            this.rdoShutterAngle.AutoSize = true;
            this.rdoShutterAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoShutterAngle.Checked = true;
            this.rdoShutterAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoShutterAngle.ForeColor = System.Drawing.Color.White;
            this.rdoShutterAngle.Location = new System.Drawing.Point(17, 6);
            this.rdoShutterAngle.Name = "rdoShutterAngle";
            this.rdoShutterAngle.Size = new System.Drawing.Size(85, 29);
            this.rdoShutterAngle.TabIndex = 61;
            this.rdoShutterAngle.TabStop = true;
            this.rdoShutterAngle.Text = "Angle";
            this.rdoShutterAngle.UseVisualStyleBackColor = false;
            this.rdoShutterAngle.CheckedChanged += new System.EventHandler(this.rdoShutterAngle_CheckedChanged);
            // 
            // rdoShutterTime
            // 
            this.rdoShutterTime.AutoSize = true;
            this.rdoShutterTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoShutterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoShutterTime.ForeColor = System.Drawing.Color.White;
            this.rdoShutterTime.Location = new System.Drawing.Point(17, 41);
            this.rdoShutterTime.Name = "rdoShutterTime";
            this.rdoShutterTime.Size = new System.Drawing.Size(77, 29);
            this.rdoShutterTime.TabIndex = 62;
            this.rdoShutterTime.Text = "Time";
            this.rdoShutterTime.UseVisualStyleBackColor = false;
            this.rdoShutterTime.CheckedChanged += new System.EventHandler(this.rdoShutterTime_CheckedChanged);
            // 
            // pbShutter
            // 
            this.pbShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pbShutter.Location = new System.Drawing.Point(784, 54);
            this.pbShutter.Name = "pbShutter";
            this.pbShutter.Size = new System.Drawing.Size(378, 77);
            this.pbShutter.TabIndex = 63;
            this.pbShutter.TabStop = false;
            // 
            // lblShutterl
            // 
            this.lblShutterl.AutoSize = true;
            this.lblShutterl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShutterl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutterl.ForeColor = System.Drawing.Color.White;
            this.lblShutterl.Location = new System.Drawing.Point(786, 54);
            this.lblShutterl.Name = "lblShutterl";
            this.lblShutterl.Size = new System.Drawing.Size(66, 20);
            this.lblShutterl.TabIndex = 64;
            this.lblShutterl.Text = "Shutter:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(1170, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 746);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // lblRecording
            // 
            this.lblRecording.AutoSize = true;
            this.lblRecording.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecording.ForeColor = System.Drawing.Color.White;
            this.lblRecording.Location = new System.Drawing.Point(1170, 28);
            this.lblRecording.Name = "lblRecording";
            this.lblRecording.Size = new System.Drawing.Size(86, 20);
            this.lblRecording.TabIndex = 66;
            this.lblRecording.Text = "Recording:";
            // 
            // lblGainl
            // 
            this.lblGainl.AutoSize = true;
            this.lblGainl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGainl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainl.ForeColor = System.Drawing.Color.White;
            this.lblGainl.Location = new System.Drawing.Point(784, 137);
            this.lblGainl.Name = "lblGainl";
            this.lblGainl.Size = new System.Drawing.Size(47, 20);
            this.lblGainl.TabIndex = 72;
            this.lblGainl.Text = "Gain:";
            // 
            // rdoGainISO
            // 
            this.rdoGainISO.AutoSize = true;
            this.rdoGainISO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoGainISO.Enabled = false;
            this.rdoGainISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGainISO.ForeColor = System.Drawing.Color.White;
            this.rdoGainISO.Location = new System.Drawing.Point(14, 39);
            this.rdoGainISO.Name = "rdoGainISO";
            this.rdoGainISO.Size = new System.Drawing.Size(65, 29);
            this.rdoGainISO.TabIndex = 70;
            this.rdoGainISO.Text = "ISO";
            this.rdoGainISO.UseVisualStyleBackColor = false;
            // 
            // rdoGainDB
            // 
            this.rdoGainDB.AutoSize = true;
            this.rdoGainDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoGainDB.Checked = true;
            this.rdoGainDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGainDB.ForeColor = System.Drawing.Color.White;
            this.rdoGainDB.Location = new System.Drawing.Point(14, 4);
            this.rdoGainDB.Name = "rdoGainDB";
            this.rdoGainDB.Size = new System.Drawing.Size(56, 29);
            this.rdoGainDB.TabIndex = 69;
            this.rdoGainDB.TabStop = true;
            this.rdoGainDB.Text = "dB";
            this.rdoGainDB.UseVisualStyleBackColor = false;
            // 
            // btnGainUp
            // 
            this.btnGainUp.BackColor = System.Drawing.Color.LightGray;
            this.btnGainUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainUp.Location = new System.Drawing.Point(975, 165);
            this.btnGainUp.Name = "btnGainUp";
            this.btnGainUp.Size = new System.Drawing.Size(62, 38);
            this.btnGainUp.TabIndex = 68;
            this.btnGainUp.Text = "+";
            this.btnGainUp.UseVisualStyleBackColor = false;
            this.btnGainUp.Click += new System.EventHandler(this.btnGainUp_Click);
            // 
            // btnGainDown
            // 
            this.btnGainDown.BackColor = System.Drawing.Color.LightGray;
            this.btnGainDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainDown.Location = new System.Drawing.Point(907, 165);
            this.btnGainDown.Name = "btnGainDown";
            this.btnGainDown.Size = new System.Drawing.Size(62, 38);
            this.btnGainDown.TabIndex = 67;
            this.btnGainDown.Text = "-";
            this.btnGainDown.UseVisualStyleBackColor = false;
            this.btnGainDown.Click += new System.EventHandler(this.btnGainDown_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(784, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(378, 77);
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(12, 570);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(766, 204);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // lblFormatl
            // 
            this.lblFormatl.AutoSize = true;
            this.lblFormatl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatl.ForeColor = System.Drawing.Color.White;
            this.lblFormatl.Location = new System.Drawing.Point(12, 570);
            this.lblFormatl.Name = "lblFormatl";
            this.lblFormatl.Size = new System.Drawing.Size(64, 20);
            this.lblFormatl.TabIndex = 74;
            this.lblFormatl.Text = "Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(784, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "White Balance:";
            // 
            // btnBlueUp
            // 
            this.btnBlueUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueUp.Location = new System.Drawing.Point(913, 243);
            this.btnBlueUp.Name = "btnBlueUp";
            this.btnBlueUp.Size = new System.Drawing.Size(51, 38);
            this.btnBlueUp.TabIndex = 76;
            this.btnBlueUp.Text = "+";
            this.btnBlueUp.UseVisualStyleBackColor = false;
            this.btnBlueUp.Click += new System.EventHandler(this.btnBlueUp_Click);
            // 
            // btnBlueDown
            // 
            this.btnBlueDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDown.Location = new System.Drawing.Point(856, 243);
            this.btnBlueDown.Name = "btnBlueDown";
            this.btnBlueDown.Size = new System.Drawing.Size(51, 38);
            this.btnBlueDown.TabIndex = 75;
            this.btnBlueDown.Text = "-";
            this.btnBlueDown.UseVisualStyleBackColor = false;
            this.btnBlueDown.Click += new System.EventHandler(this.btnBlueDown_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox5.Location = new System.Drawing.Point(784, 220);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(378, 116);
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // btnRedUp
            // 
            this.btnRedUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedUp.Location = new System.Drawing.Point(913, 287);
            this.btnRedUp.Name = "btnRedUp";
            this.btnRedUp.Size = new System.Drawing.Size(51, 38);
            this.btnRedUp.TabIndex = 82;
            this.btnRedUp.Text = "+";
            this.btnRedUp.UseVisualStyleBackColor = false;
            this.btnRedUp.Click += new System.EventHandler(this.btnRedUp_Click);
            // 
            // btnRedDown
            // 
            this.btnRedDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDown.Location = new System.Drawing.Point(856, 287);
            this.btnRedDown.Name = "btnRedDown";
            this.btnRedDown.Size = new System.Drawing.Size(51, 38);
            this.btnRedDown.TabIndex = 81;
            this.btnRedDown.Text = "-";
            this.btnRedDown.UseVisualStyleBackColor = false;
            this.btnRedDown.Click += new System.EventHandler(this.btnRedDown_Click);
            // 
            // lblBlued
            // 
            this.lblBlued.BackColor = System.Drawing.Color.Black;
            this.lblBlued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBlued.Location = new System.Drawing.Point(133, 539);
            this.lblBlued.Name = "lblBlued";
            this.lblBlued.Size = new System.Drawing.Size(110, 23);
            this.lblBlued.TabIndex = 84;
            this.lblBlued.Text = "B +0.0%";
            this.lblBlued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRedd
            // 
            this.lblRedd.BackColor = System.Drawing.Color.Black;
            this.lblRedd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRedd.Location = new System.Drawing.Point(13, 539);
            this.lblRedd.Name = "lblRedd";
            this.lblRedd.Size = new System.Drawing.Size(114, 23);
            this.lblRedd.TabIndex = 83;
            this.lblRedd.Text = "R +0.0%";
            this.lblRedd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorTempd
            // 
            this.lblColorTempd.BackColor = System.Drawing.Color.Black;
            this.lblColorTempd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorTempd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorTempd.ForeColor = System.Drawing.Color.White;
            this.lblColorTempd.Location = new System.Drawing.Point(250, 538);
            this.lblColorTempd.Name = "lblColorTempd";
            this.lblColorTempd.Size = new System.Drawing.Size(117, 23);
            this.lblColorTempd.TabIndex = 85;
            this.lblColorTempd.Text = "???? K";
            this.lblColorTempd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkWBSpot
            // 
            this.chkWBSpot.AutoSize = true;
            this.chkWBSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkWBSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWBSpot.ForeColor = System.Drawing.Color.White;
            this.chkWBSpot.Location = new System.Drawing.Point(1075, 249);
            this.chkWBSpot.Name = "chkWBSpot";
            this.chkWBSpot.Size = new System.Drawing.Size(75, 29);
            this.chkWBSpot.TabIndex = 86;
            this.chkWBSpot.Text = "Spot";
            this.chkWBSpot.UseVisualStyleBackColor = false;
            // 
            // picHistFrame
            // 
            this.picHistFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.picHistFrame.Location = new System.Drawing.Point(784, 342);
            this.picHistFrame.Name = "picHistFrame";
            this.picHistFrame.Size = new System.Drawing.Size(378, 137);
            this.picHistFrame.TabIndex = 87;
            this.picHistFrame.TabStop = false;
            // 
            // picHist
            // 
            this.picHist.BackColor = System.Drawing.Color.Black;
            this.picHist.Location = new System.Drawing.Point(802, 365);
            this.picHist.Name = "picHist";
            this.picHist.Size = new System.Drawing.Size(255, 100);
            this.picHist.TabIndex = 88;
            this.picHist.TabStop = false;
            // 
            // lblHistl
            // 
            this.lblHistl.AutoSize = true;
            this.lblHistl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHistl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistl.ForeColor = System.Drawing.Color.White;
            this.lblHistl.Location = new System.Drawing.Point(784, 342);
            this.lblHistl.Name = "lblHistl";
            this.lblHistl.Size = new System.Drawing.Size(86, 20);
            this.lblHistl.TabIndex = 89;
            this.lblHistl.Text = "Histogram:";
            // 
            // chkHistOn
            // 
            this.chkHistOn.AutoSize = true;
            this.chkHistOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkHistOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHistOn.ForeColor = System.Drawing.Color.White;
            this.chkHistOn.Location = new System.Drawing.Point(1075, 353);
            this.chkHistOn.Name = "chkHistOn";
            this.chkHistOn.Size = new System.Drawing.Size(68, 29);
            this.chkHistOn.TabIndex = 90;
            this.chkHistOn.Text = "Fire";
            this.chkHistOn.UseVisualStyleBackColor = false;
            // 
            // btnBusUp
            // 
            this.btnBusUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBusUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusUp.Location = new System.Drawing.Point(384, 697);
            this.btnBusUp.Name = "btnBusUp";
            this.btnBusUp.Size = new System.Drawing.Size(62, 38);
            this.btnBusUp.TabIndex = 92;
            this.btnBusUp.Text = "+";
            this.btnBusUp.UseVisualStyleBackColor = false;
            this.btnBusUp.Click += new System.EventHandler(this.btnBusUp_Click);
            // 
            // btnBusDown
            // 
            this.btnBusDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBusDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusDown.Location = new System.Drawing.Point(316, 697);
            this.btnBusDown.Name = "btnBusDown";
            this.btnBusDown.Size = new System.Drawing.Size(62, 38);
            this.btnBusDown.TabIndex = 93;
            this.btnBusDown.Text = "-";
            this.btnBusDown.UseVisualStyleBackColor = false;
            this.btnBusDown.Click += new System.EventHandler(this.btnBusDown_Click);
            // 
            // lblBusd
            // 
            this.lblBusd.AutoSize = true;
            this.lblBusd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBusd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusd.ForeColor = System.Drawing.Color.White;
            this.lblBusd.Location = new System.Drawing.Point(452, 704);
            this.lblBusd.Name = "lblBusd";
            this.lblBusd.Size = new System.Drawing.Size(98, 25);
            this.lblBusd.TabIndex = 94;
            this.lblBusd.Text = "95% Bus";
            // 
            // btnBlueUpUp
            // 
            this.btnBlueUpUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueUpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueUpUp.Location = new System.Drawing.Point(970, 243);
            this.btnBlueUpUp.Name = "btnBlueUpUp";
            this.btnBlueUpUp.Size = new System.Drawing.Size(51, 38);
            this.btnBlueUpUp.TabIndex = 95;
            this.btnBlueUpUp.Text = "++";
            this.btnBlueUpUp.UseVisualStyleBackColor = false;
            this.btnBlueUpUp.Click += new System.EventHandler(this.btnBlueUpUp_Click);
            // 
            // btnBlueDownDown
            // 
            this.btnBlueDownDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueDownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDownDown.Location = new System.Drawing.Point(802, 243);
            this.btnBlueDownDown.Name = "btnBlueDownDown";
            this.btnBlueDownDown.Size = new System.Drawing.Size(48, 38);
            this.btnBlueDownDown.TabIndex = 96;
            this.btnBlueDownDown.Text = "--";
            this.btnBlueDownDown.UseVisualStyleBackColor = false;
            this.btnBlueDownDown.Click += new System.EventHandler(this.btnBlueDownDown_Click);
            // 
            // btnRedDownDown
            // 
            this.btnRedDownDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedDownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDownDown.Location = new System.Drawing.Point(802, 287);
            this.btnRedDownDown.Name = "btnRedDownDown";
            this.btnRedDownDown.Size = new System.Drawing.Size(48, 38);
            this.btnRedDownDown.TabIndex = 97;
            this.btnRedDownDown.Text = "--";
            this.btnRedDownDown.UseVisualStyleBackColor = false;
            this.btnRedDownDown.Click += new System.EventHandler(this.btnRedDownDown_Click);
            // 
            // btnRedUpUp
            // 
            this.btnRedUpUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedUpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedUpUp.Location = new System.Drawing.Point(970, 287);
            this.btnRedUpUp.Name = "btnRedUpUp";
            this.btnRedUpUp.Size = new System.Drawing.Size(51, 38);
            this.btnRedUpUp.TabIndex = 98;
            this.btnRedUpUp.Text = "++";
            this.btnRedUpUp.UseVisualStyleBackColor = false;
            this.btnRedUpUp.Click += new System.EventHandler(this.btnRedUpUp_Click);
            // 
            // txtDiag
            // 
            this.txtDiag.BackColor = System.Drawing.Color.DimGray;
            this.txtDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiag.ForeColor = System.Drawing.Color.White;
            this.txtDiag.Location = new System.Drawing.Point(1185, 630);
            this.txtDiag.Multiline = true;
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(305, 139);
            this.txtDiag.TabIndex = 99;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.ForeColor = System.Drawing.Color.White;
            this.lblDiag.Location = new System.Drawing.Point(1185, 607);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(183, 20);
            this.lblDiag.TabIndex = 100;
            this.lblDiag.Text = "Thread Diagnostics [ms]:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox6.Location = new System.Drawing.Point(784, 485);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(380, 289);
            this.pictureBox6.TabIndex = 101;
            this.pictureBox6.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(784, 485);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(67, 20);
            this.lblPreview.TabIndex = 102;
            this.lblPreview.Text = "Preview:";
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkRaw.Checked = true;
            this.chkRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRaw.ForeColor = System.Drawing.Color.White;
            this.chkRaw.Location = new System.Drawing.Point(790, 508);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(162, 29);
            this.chkRaw.TabIndex = 103;
            this.chkRaw.Text = "Debayer Only";
            this.chkRaw.UseVisualStyleBackColor = false;
            // 
            // nudGamma
            // 
            this.nudGamma.BackColor = System.Drawing.Color.DimGray;
            this.nudGamma.DecimalPlaces = 2;
            this.nudGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGamma.ForeColor = System.Drawing.Color.White;
            this.nudGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGamma.Location = new System.Drawing.Point(896, 544);
            this.nudGamma.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nudGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGamma.Name = "nudGamma";
            this.nudGamma.Size = new System.Drawing.Size(116, 38);
            this.nudGamma.TabIndex = 104;
            this.nudGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGamma.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamma.ForeColor = System.Drawing.Color.White;
            this.lblGamma.Location = new System.Drawing.Point(820, 555);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(70, 20);
            this.lblGamma.TabIndex = 105;
            this.lblGamma.Text = "Gamma:";
            // 
            // btnGammaUp
            // 
            this.btnGammaUp.BackColor = System.Drawing.Color.LightGray;
            this.btnGammaUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGammaUp.Location = new System.Drawing.Point(1086, 544);
            this.btnGammaUp.Name = "btnGammaUp";
            this.btnGammaUp.Size = new System.Drawing.Size(62, 38);
            this.btnGammaUp.TabIndex = 107;
            this.btnGammaUp.Text = "+";
            this.btnGammaUp.UseVisualStyleBackColor = false;
            this.btnGammaUp.Click += new System.EventHandler(this.btnGammaUp_Click);
            // 
            // btnGammaDown
            // 
            this.btnGammaDown.BackColor = System.Drawing.Color.LightGray;
            this.btnGammaDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGammaDown.Location = new System.Drawing.Point(1018, 544);
            this.btnGammaDown.Name = "btnGammaDown";
            this.btnGammaDown.Size = new System.Drawing.Size(62, 38);
            this.btnGammaDown.TabIndex = 106;
            this.btnGammaDown.Text = "-";
            this.btnGammaDown.UseVisualStyleBackColor = false;
            this.btnGammaDown.Click += new System.EventHandler(this.btnGammaDown_Click);
            // 
            // chkClip
            // 
            this.chkClip.AutoSize = true;
            this.chkClip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkClip.Checked = true;
            this.chkClip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClip.ForeColor = System.Drawing.Color.White;
            this.chkClip.Location = new System.Drawing.Point(975, 507);
            this.chkClip.Name = "chkClip";
            this.chkClip.Size = new System.Drawing.Size(168, 29);
            this.chkClip.TabIndex = 108;
            this.chkClip.Text = "Show Clipping";
            this.chkClip.UseVisualStyleBackColor = false;
            // 
            // btnBrightnessUp
            // 
            this.btnBrightnessUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBrightnessUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightnessUp.Location = new System.Drawing.Point(1086, 588);
            this.btnBrightnessUp.Name = "btnBrightnessUp";
            this.btnBrightnessUp.Size = new System.Drawing.Size(62, 38);
            this.btnBrightnessUp.TabIndex = 112;
            this.btnBrightnessUp.Text = "+";
            this.btnBrightnessUp.UseVisualStyleBackColor = false;
            this.btnBrightnessUp.Click += new System.EventHandler(this.btnBrightnessUp_Click);
            // 
            // btnBrightnessDown
            // 
            this.btnBrightnessDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBrightnessDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightnessDown.Location = new System.Drawing.Point(1018, 588);
            this.btnBrightnessDown.Name = "btnBrightnessDown";
            this.btnBrightnessDown.Size = new System.Drawing.Size(62, 38);
            this.btnBrightnessDown.TabIndex = 111;
            this.btnBrightnessDown.Text = "-";
            this.btnBrightnessDown.UseVisualStyleBackColor = false;
            this.btnBrightnessDown.Click += new System.EventHandler(this.btnBrightnessDown_Click);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.ForeColor = System.Drawing.Color.White;
            this.lblBrightness.Location = new System.Drawing.Point(801, 599);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(89, 20);
            this.lblBrightness.TabIndex = 110;
            this.lblBrightness.Text = "Brightness:";
            // 
            // nudBrightness
            // 
            this.nudBrightness.BackColor = System.Drawing.Color.DimGray;
            this.nudBrightness.DecimalPlaces = 2;
            this.nudBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBrightness.ForeColor = System.Drawing.Color.White;
            this.nudBrightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudBrightness.Location = new System.Drawing.Point(896, 588);
            this.nudBrightness.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nudBrightness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(116, 38);
            this.nudBrightness.TabIndex = 109;
            this.nudBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBrightness.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btnContrastUp
            // 
            this.btnContrastUp.BackColor = System.Drawing.Color.LightGray;
            this.btnContrastUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrastUp.Location = new System.Drawing.Point(1086, 632);
            this.btnContrastUp.Name = "btnContrastUp";
            this.btnContrastUp.Size = new System.Drawing.Size(62, 38);
            this.btnContrastUp.TabIndex = 116;
            this.btnContrastUp.Text = "+";
            this.btnContrastUp.UseVisualStyleBackColor = false;
            this.btnContrastUp.Click += new System.EventHandler(this.btnContrastUp_Click);
            // 
            // btnContrastDown
            // 
            this.btnContrastDown.BackColor = System.Drawing.Color.LightGray;
            this.btnContrastDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrastDown.Location = new System.Drawing.Point(1018, 632);
            this.btnContrastDown.Name = "btnContrastDown";
            this.btnContrastDown.Size = new System.Drawing.Size(62, 38);
            this.btnContrastDown.TabIndex = 115;
            this.btnContrastDown.Text = "-";
            this.btnContrastDown.UseVisualStyleBackColor = false;
            this.btnContrastDown.Click += new System.EventHandler(this.btnContrastDown_Click);
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.ForeColor = System.Drawing.Color.White;
            this.lblContrast.Location = new System.Drawing.Point(816, 643);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(74, 20);
            this.lblContrast.TabIndex = 114;
            this.lblContrast.Text = "Contrast:";
            // 
            // nudContrast
            // 
            this.nudContrast.BackColor = System.Drawing.Color.DimGray;
            this.nudContrast.DecimalPlaces = 2;
            this.nudContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudContrast.ForeColor = System.Drawing.Color.White;
            this.nudContrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudContrast.Location = new System.Drawing.Point(896, 632);
            this.nudContrast.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nudContrast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudContrast.Name = "nudContrast";
            this.nudContrast.Size = new System.Drawing.Size(116, 38);
            this.nudContrast.TabIndex = 113;
            this.nudContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudContrast.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btnSaturationUp
            // 
            this.btnSaturationUp.BackColor = System.Drawing.Color.LightGray;
            this.btnSaturationUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturationUp.Location = new System.Drawing.Point(1086, 677);
            this.btnSaturationUp.Name = "btnSaturationUp";
            this.btnSaturationUp.Size = new System.Drawing.Size(62, 38);
            this.btnSaturationUp.TabIndex = 120;
            this.btnSaturationUp.Text = "+";
            this.btnSaturationUp.UseVisualStyleBackColor = false;
            this.btnSaturationUp.Click += new System.EventHandler(this.btnSaturationUp_Click);
            // 
            // btnSaturationDown
            // 
            this.btnSaturationDown.BackColor = System.Drawing.Color.LightGray;
            this.btnSaturationDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturationDown.Location = new System.Drawing.Point(1018, 677);
            this.btnSaturationDown.Name = "btnSaturationDown";
            this.btnSaturationDown.Size = new System.Drawing.Size(62, 38);
            this.btnSaturationDown.TabIndex = 119;
            this.btnSaturationDown.Text = "-";
            this.btnSaturationDown.UseVisualStyleBackColor = false;
            this.btnSaturationDown.Click += new System.EventHandler(this.btnSaturationDown_Click);
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturation.ForeColor = System.Drawing.Color.White;
            this.lblSaturation.Location = new System.Drawing.Point(803, 688);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(87, 20);
            this.lblSaturation.TabIndex = 118;
            this.lblSaturation.Text = "Saturation:";
            // 
            // nudSaturation
            // 
            this.nudSaturation.BackColor = System.Drawing.Color.DimGray;
            this.nudSaturation.DecimalPlaces = 2;
            this.nudSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSaturation.ForeColor = System.Drawing.Color.White;
            this.nudSaturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSaturation.Location = new System.Drawing.Point(896, 677);
            this.nudSaturation.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nudSaturation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSaturation.Name = "nudSaturation";
            this.nudSaturation.Size = new System.Drawing.Size(116, 38);
            this.nudSaturation.TabIndex = 117;
            this.nudSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSaturation.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btnSharpnessUp
            // 
            this.btnSharpnessUp.BackColor = System.Drawing.Color.LightGray;
            this.btnSharpnessUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSharpnessUp.Location = new System.Drawing.Point(1086, 721);
            this.btnSharpnessUp.Name = "btnSharpnessUp";
            this.btnSharpnessUp.Size = new System.Drawing.Size(62, 38);
            this.btnSharpnessUp.TabIndex = 124;
            this.btnSharpnessUp.Text = "+";
            this.btnSharpnessUp.UseVisualStyleBackColor = false;
            this.btnSharpnessUp.Click += new System.EventHandler(this.btnSharpnessUp_Click);
            // 
            // btnSharpnessDown
            // 
            this.btnSharpnessDown.BackColor = System.Drawing.Color.LightGray;
            this.btnSharpnessDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSharpnessDown.Location = new System.Drawing.Point(1018, 721);
            this.btnSharpnessDown.Name = "btnSharpnessDown";
            this.btnSharpnessDown.Size = new System.Drawing.Size(62, 38);
            this.btnSharpnessDown.TabIndex = 123;
            this.btnSharpnessDown.Text = "-";
            this.btnSharpnessDown.UseVisualStyleBackColor = false;
            this.btnSharpnessDown.Click += new System.EventHandler(this.btnSharpnessDown_Click);
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSharpness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSharpness.ForeColor = System.Drawing.Color.White;
            this.lblSharpness.Location = new System.Drawing.Point(800, 732);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(90, 20);
            this.lblSharpness.TabIndex = 122;
            this.lblSharpness.Text = "Sharpness:";
            // 
            // nudSharpness
            // 
            this.nudSharpness.BackColor = System.Drawing.Color.DimGray;
            this.nudSharpness.DecimalPlaces = 2;
            this.nudSharpness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSharpness.ForeColor = System.Drawing.Color.White;
            this.nudSharpness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSharpness.Location = new System.Drawing.Point(896, 721);
            this.nudSharpness.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nudSharpness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSharpness.Name = "nudSharpness";
            this.nudSharpness.Size = new System.Drawing.Size(116, 38);
            this.nudSharpness.TabIndex = 121;
            this.nudSharpness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSharpness.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // lblBufferFrames
            // 
            this.lblBufferFrames.AutoSize = true;
            this.lblBufferFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferFrames.ForeColor = System.Drawing.Color.White;
            this.lblBufferFrames.Location = new System.Drawing.Point(1428, 129);
            this.lblBufferFrames.Name = "lblBufferFrames";
            this.lblBufferFrames.Size = new System.Drawing.Size(66, 20);
            this.lblBufferFrames.TabIndex = 8;
            this.lblBufferFrames.Text = "[frames]";
            // 
            // btnTrig
            // 
            this.btnTrig.BackColor = System.Drawing.Color.DarkRed;
            this.btnTrig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrig.ForeColor = System.Drawing.Color.White;
            this.btnTrig.Location = new System.Drawing.Point(1345, 392);
            this.btnTrig.Name = "btnTrig";
            this.btnTrig.Size = new System.Drawing.Size(145, 50);
            this.btnTrig.TabIndex = 125;
            this.btnTrig.Text = "TRIG";
            this.btnTrig.UseVisualStyleBackColor = false;
            // 
            // btnBufferUp
            // 
            this.btnBufferUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBufferUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBufferUp.Location = new System.Drawing.Point(1432, 88);
            this.btnBufferUp.Name = "btnBufferUp";
            this.btnBufferUp.Size = new System.Drawing.Size(62, 38);
            this.btnBufferUp.TabIndex = 127;
            this.btnBufferUp.Text = "+";
            this.btnBufferUp.UseVisualStyleBackColor = false;
            // 
            // btnBufferDown
            // 
            this.btnBufferDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBufferDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBufferDown.Location = new System.Drawing.Point(1364, 88);
            this.btnBufferDown.Name = "btnBufferDown";
            this.btnBufferDown.Size = new System.Drawing.Size(62, 38);
            this.btnBufferDown.TabIndex = 126;
            this.btnBufferDown.Text = "-";
            this.btnBufferDown.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1228, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Divider:";
            // 
            // btnBGSaveDivUp
            // 
            this.btnBGSaveDivUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBGSaveDivUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGSaveDivUp.Location = new System.Drawing.Point(1432, 555);
            this.btnBGSaveDivUp.Name = "btnBGSaveDivUp";
            this.btnBGSaveDivUp.Size = new System.Drawing.Size(62, 38);
            this.btnBGSaveDivUp.TabIndex = 130;
            this.btnBGSaveDivUp.Text = "+";
            this.btnBGSaveDivUp.UseVisualStyleBackColor = false;
            // 
            // btnBGSaveDivDn
            // 
            this.btnBGSaveDivDn.BackColor = System.Drawing.Color.LightGray;
            this.btnBGSaveDivDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGSaveDivDn.Location = new System.Drawing.Point(1364, 555);
            this.btnBGSaveDivDn.Name = "btnBGSaveDivDn";
            this.btnBGSaveDivDn.Size = new System.Drawing.Size(62, 38);
            this.btnBGSaveDivDn.TabIndex = 129;
            this.btnBGSaveDivDn.Text = "-";
            this.btnBGSaveDivDn.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1345, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 50);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // trkTrigger
            // 
            this.trkTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trkTrigger.LargeChange = 2;
            this.trkTrigger.Location = new System.Drawing.Point(1185, 341);
            this.trkTrigger.Name = "trkTrigger";
            this.trkTrigger.Size = new System.Drawing.Size(309, 45);
            this.trkTrigger.TabIndex = 132;
            this.trkTrigger.Value = 5;
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.ForeColor = System.Drawing.Color.White;
            this.lblTrigger.Location = new System.Drawing.Point(1189, 316);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(122, 20);
            this.lblTrigger.TabIndex = 133;
            this.lblTrigger.Text = "Trigger Position:";
            // 
            // nudFR
            // 
            this.nudFR.BackColor = System.Drawing.Color.DimGray;
            this.nudFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFR.ForeColor = System.Drawing.Color.White;
            this.nudFR.Location = new System.Drawing.Point(225, 595);
            this.nudFR.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFR.Name = "nudFR";
            this.nudFR.Size = new System.Drawing.Size(85, 38);
            this.nudFR.TabIndex = 135;
            this.nudFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFR.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFR.ValueChanged += new System.EventHandler(this.nudFR_ValueChanged);
            // 
            // btnFRUp
            // 
            this.btnFRUp.BackColor = System.Drawing.Color.LightGray;
            this.btnFRUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRUp.Location = new System.Drawing.Point(384, 595);
            this.btnFRUp.Name = "btnFRUp";
            this.btnFRUp.Size = new System.Drawing.Size(62, 38);
            this.btnFRUp.TabIndex = 137;
            this.btnFRUp.Text = "+";
            this.btnFRUp.UseVisualStyleBackColor = false;
            // 
            // btnFRDown
            // 
            this.btnFRDown.BackColor = System.Drawing.Color.LightGray;
            this.btnFRDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRDown.Location = new System.Drawing.Point(316, 595);
            this.btnFRDown.Name = "btnFRDown";
            this.btnFRDown.Size = new System.Drawing.Size(62, 38);
            this.btnFRDown.TabIndex = 136;
            this.btnFRDown.Text = "-";
            this.btnFRDown.UseVisualStyleBackColor = false;
            // 
            // rdo30fps
            // 
            this.rdo30fps.AutoSize = true;
            this.rdo30fps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo30fps.Checked = true;
            this.rdo30fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo30fps.ForeColor = System.Drawing.Color.White;
            this.rdo30fps.Location = new System.Drawing.Point(100, 6);
            this.rdo30fps.Name = "rdo30fps";
            this.rdo30fps.Size = new System.Drawing.Size(100, 29);
            this.rdo30fps.TabIndex = 139;
            this.rdo30fps.TabStop = true;
            this.rdo30fps.Text = "30fps x";
            this.rdo30fps.UseVisualStyleBackColor = false;
            // 
            // cmbResolution
            // 
            this.cmbResolution.BackColor = System.Drawing.Color.DimGray;
            this.cmbResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResolution.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Items.AddRange(new object[] {
            "4096x2160 (1.90:1)",
            "3840x2160 (16:9)",
            "1920x1200 (1.60:1)",
            "1920x1080 (16:9)",
            "1920x1038 (1.85:1)",
            "1920x800 (2.40:1)",
            "1920x480",
            "1920x360",
            "1920x240",
            "1280x720 (16:9)",
            "1280x534 (2.40:1)",
            "864x480 (1.80:1)",
            "864x360 (2.40:1)",
            "864x240",
            "864x160",
            "864x120"});
            this.cmbResolution.Location = new System.Drawing.Point(30, 644);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(280, 39);
            this.cmbResolution.TabIndex = 140;
            this.cmbResolution.Text = "1920x1200 (1.6:1)";
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // btnResUp
            // 
            this.btnResUp.BackColor = System.Drawing.Color.LightGray;
            this.btnResUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResUp.Location = new System.Drawing.Point(384, 644);
            this.btnResUp.Name = "btnResUp";
            this.btnResUp.Size = new System.Drawing.Size(62, 38);
            this.btnResUp.TabIndex = 142;
            this.btnResUp.Text = "+";
            this.btnResUp.UseVisualStyleBackColor = false;
            // 
            // btnResDown
            // 
            this.btnResDown.BackColor = System.Drawing.Color.LightGray;
            this.btnResDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResDown.Location = new System.Drawing.Point(316, 644);
            this.btnResDown.Name = "btnResDown";
            this.btnResDown.Size = new System.Drawing.Size(62, 38);
            this.btnResDown.TabIndex = 141;
            this.btnResDown.Text = "-";
            this.btnResDown.UseVisualStyleBackColor = false;
            // 
            // pnlShutter
            // 
            this.pnlShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlShutter.Controls.Add(this.rdoShutterTime);
            this.pnlShutter.Controls.Add(this.rdoShutterAngle);
            this.pnlShutter.Location = new System.Drawing.Point(1042, 53);
            this.pnlShutter.Name = "pnlShutter";
            this.pnlShutter.Size = new System.Drawing.Size(119, 77);
            this.pnlShutter.TabIndex = 143;
            // 
            // pnlGain
            // 
            this.pnlGain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlGain.Controls.Add(this.rdoGainISO);
            this.pnlGain.Controls.Add(this.rdoGainDB);
            this.pnlGain.Location = new System.Drawing.Point(1042, 138);
            this.pnlGain.Name = "pnlGain";
            this.pnlGain.Size = new System.Drawing.Size(119, 75);
            this.pnlGain.TabIndex = 144;
            // 
            // rdo24fps
            // 
            this.rdo24fps.AutoSize = true;
            this.rdo24fps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo24fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo24fps.ForeColor = System.Drawing.Color.White;
            this.rdo24fps.Location = new System.Drawing.Point(11, 6);
            this.rdo24fps.Name = "rdo24fps";
            this.rdo24fps.Size = new System.Drawing.Size(83, 29);
            this.rdo24fps.TabIndex = 138;
            this.rdo24fps.Text = "24fps";
            this.rdo24fps.UseVisualStyleBackColor = false;
            // 
            // pnlFR
            // 
            this.pnlFR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlFR.Controls.Add(this.rdo30fps);
            this.pnlFR.Controls.Add(this.rdo24fps);
            this.pnlFR.Location = new System.Drawing.Point(19, 595);
            this.pnlFR.Name = "pnlFR";
            this.pnlFR.Size = new System.Drawing.Size(206, 38);
            this.pnlFR.TabIndex = 145;
            // 
            // btnChangeFormat
            // 
            this.btnChangeFormat.BackColor = System.Drawing.Color.LightGray;
            this.btnChangeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFormat.Location = new System.Drawing.Point(594, 644);
            this.btnChangeFormat.Name = "btnChangeFormat";
            this.btnChangeFormat.Size = new System.Drawing.Size(128, 91);
            this.btnChangeFormat.TabIndex = 146;
            this.btnChangeFormat.Text = "Change Format";
            this.btnChangeFormat.UseVisualStyleBackColor = false;
            this.btnChangeFormat.Click += new System.EventHandler(this.btnChangeFormat_Click);
            // 
            // pnlBit
            // 
            this.pnlBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlBit.Controls.Add(this.rdo12bit);
            this.pnlBit.Controls.Add(this.rdo8bit);
            this.pnlBit.Location = new System.Drawing.Point(19, 697);
            this.pnlBit.Name = "pnlBit";
            this.pnlBit.Size = new System.Drawing.Size(206, 38);
            this.pnlBit.TabIndex = 147;
            // 
            // rdo12bit
            // 
            this.rdo12bit.AutoSize = true;
            this.rdo12bit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo12bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo12bit.ForeColor = System.Drawing.Color.White;
            this.rdo12bit.Location = new System.Drawing.Point(100, 6);
            this.rdo12bit.Name = "rdo12bit";
            this.rdo12bit.Size = new System.Drawing.Size(84, 29);
            this.rdo12bit.TabIndex = 139;
            this.rdo12bit.Text = "12-bit";
            this.rdo12bit.UseVisualStyleBackColor = false;
            // 
            // rdo8bit
            // 
            this.rdo8bit.AllowDrop = true;
            this.rdo8bit.AutoSize = true;
            this.rdo8bit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo8bit.Checked = true;
            this.rdo8bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo8bit.ForeColor = System.Drawing.Color.White;
            this.rdo8bit.Location = new System.Drawing.Point(11, 6);
            this.rdo8bit.Name = "rdo8bit";
            this.rdo8bit.Size = new System.Drawing.Size(72, 29);
            this.rdo8bit.TabIndex = 138;
            this.rdo8bit.TabStop = true;
            this.rdo8bit.Text = "8-bit";
            this.rdo8bit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1514, 801);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBit);
            this.Controls.Add(this.btnChangeFormat);
            this.Controls.Add(this.pnlFR);
            this.Controls.Add(this.pnlGain);
            this.Controls.Add(this.pnlShutter);
            this.Controls.Add(this.btnResUp);
            this.Controls.Add(this.btnResDown);
            this.Controls.Add(this.cmbResolution);
            this.Controls.Add(this.btnFRUp);
            this.Controls.Add(this.btnFRDown);
            this.Controls.Add(this.nudFR);
            this.Controls.Add(this.lblTrigger);
            this.Controls.Add(this.trkTrigger);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBGSaveDivUp);
            this.Controls.Add(this.btnBGSaveDivDn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBufferUp);
            this.Controls.Add(this.btnBufferDown);
            this.Controls.Add(this.btnTrig);
            this.Controls.Add(this.btnSharpnessUp);
            this.Controls.Add(this.btnSharpnessDown);
            this.Controls.Add(this.lblSharpness);
            this.Controls.Add(this.nudSharpness);
            this.Controls.Add(this.btnSaturationUp);
            this.Controls.Add(this.btnSaturationDown);
            this.Controls.Add(this.lblSaturation);
            this.Controls.Add(this.nudSaturation);
            this.Controls.Add(this.btnContrastUp);
            this.Controls.Add(this.btnContrastDown);
            this.Controls.Add(this.lblContrast);
            this.Controls.Add(this.nudContrast);
            this.Controls.Add(this.btnBrightnessUp);
            this.Controls.Add(this.btnBrightnessDown);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.nudBrightness);
            this.Controls.Add(this.chkClip);
            this.Controls.Add(this.btnGammaUp);
            this.Controls.Add(this.btnGammaDown);
            this.Controls.Add(this.lblGamma);
            this.Controls.Add(this.nudGamma);
            this.Controls.Add(this.chkRaw);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.btnRedUpUp);
            this.Controls.Add(this.btnRedDownDown);
            this.Controls.Add(this.btnBlueDownDown);
            this.Controls.Add(this.btnBlueUpUp);
            this.Controls.Add(this.lblBusd);
            this.Controls.Add(this.btnBusDown);
            this.Controls.Add(this.btnBusUp);
            this.Controls.Add(this.chkHistOn);
            this.Controls.Add(this.lblHistl);
            this.Controls.Add(this.picHist);
            this.Controls.Add(this.picHistFrame);
            this.Controls.Add(this.chkWBSpot);
            this.Controls.Add(this.lblColorTempd);
            this.Controls.Add(this.lblBlued);
            this.Controls.Add(this.lblRedd);
            this.Controls.Add(this.btnRedUp);
            this.Controls.Add(this.btnRedDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBlueUp);
            this.Controls.Add(this.btnBlueDown);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblFormatl);
            this.Controls.Add(this.lblGainl);
            this.Controls.Add(this.btnGainUp);
            this.Controls.Add(this.btnGainDown);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblRecording);
            this.Controls.Add(this.lblShutterl);
            this.Controls.Add(this.btnShutterUp);
            this.Controls.Add(this.btnShutterDown);
            this.Controls.Add(this.lblGaind);
            this.Controls.Add(this.lblShutterd);
            this.Controls.Add(this.lblBITd);
            this.Controls.Add(this.lblPXd);
            this.Controls.Add(this.lblFPSd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.nudDiv);
            this.Controls.Add(this.chkContSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picBuffer);
            this.Controls.Add(this.chkAuto30Hz);
            this.Controls.Add(this.lblDD);
            this.Controls.Add(this.nudDD);
            this.Controls.Add(this.lblFramesBuffered);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBufferGB);
            this.Controls.Add(this.lblBufferSeconds);
            this.Controls.Add(this.lblBufferSize);
            this.Controls.Add(this.lblBufferFrames);
            this.Controls.Add(this.nudBufferFrames);
            this.Controls.Add(this.lblRawSize);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbShutter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "FlyCapture2SimpleGUI_CSharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBufferFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShutter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHistFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSharpness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFR)).EndInit();
            this.pnlShutter.ResumeLayout(false);
            this.pnlShutter.PerformLayout();
            this.pnlGain.ResumeLayout(false);
            this.pnlGain.PerformLayout();
            this.pnlFR.ResumeLayout(false);
            this.pnlFR.PerformLayout();
            this.pnlBit.ResumeLayout(false);
            this.pnlBit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimestamp;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCameraControl;
        private System.Windows.Forms.ToolStripMenuItem newCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImageSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFrameRate;
        private System.Windows.Forms.Label lblRawSize;
        private System.Windows.Forms.NumericUpDown nudBufferFrames;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblBufferSeconds;
        private System.Windows.Forms.Label lblBufferGB;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFramesBuffered;
        private System.Windows.Forms.NumericUpDown nudDD;
        private System.Windows.Forms.Label lblDD;
        private System.Windows.Forms.CheckBox chkAuto30Hz;
        private System.Windows.Forms.PictureBox picBuffer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkContSave;
        private System.Windows.Forms.NumericUpDown nudDiv;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFPSd;
        private System.Windows.Forms.Label lblPXd;
        private System.Windows.Forms.Label lblBITd;
        private System.Windows.Forms.Label lblShutterd;
        private System.Windows.Forms.Label lblGaind;
        private System.Windows.Forms.Button btnShutterDown;
        private System.Windows.Forms.Button btnShutterUp;
        private System.Windows.Forms.RadioButton rdoShutterAngle;
        private System.Windows.Forms.RadioButton rdoShutterTime;
        private System.Windows.Forms.PictureBox pbShutter;
        private System.Windows.Forms.Label lblShutterl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRecording;
        private System.Windows.Forms.Label lblGainl;
        private System.Windows.Forms.RadioButton rdoGainISO;
        private System.Windows.Forms.RadioButton rdoGainDB;
        private System.Windows.Forms.Button btnGainUp;
        private System.Windows.Forms.Button btnGainDown;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblFormatl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBlueUp;
        private System.Windows.Forms.Button btnBlueDown;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRedUp;
        private System.Windows.Forms.Button btnRedDown;
        private System.Windows.Forms.Label lblBlued;
        private System.Windows.Forms.Label lblRedd;
        private System.Windows.Forms.Label lblColorTempd;
        private System.Windows.Forms.CheckBox chkWBSpot;
        private System.Windows.Forms.PictureBox picHistFrame;
        private System.Windows.Forms.PictureBox picHist;
        private System.Windows.Forms.Label lblHistl;
        private System.Windows.Forms.CheckBox chkHistOn;
        private System.Windows.Forms.Button btnBusUp;
        private System.Windows.Forms.Button btnBusDown;
        private System.Windows.Forms.Label lblBusd;
        private System.Windows.Forms.Button btnBlueUpUp;
        private System.Windows.Forms.Button btnBlueDownDown;
        private System.Windows.Forms.Button btnRedDownDown;
        private System.Windows.Forms.Button btnRedUpUp;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.CheckBox chkRaw;
        private System.Windows.Forms.NumericUpDown nudGamma;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.Button btnGammaUp;
        private System.Windows.Forms.Button btnGammaDown;
        private System.Windows.Forms.CheckBox chkClip;
        private System.Windows.Forms.Button btnBrightnessUp;
        private System.Windows.Forms.Button btnBrightnessDown;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.Button btnContrastUp;
        private System.Windows.Forms.Button btnContrastDown;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.NumericUpDown nudContrast;
        private System.Windows.Forms.Button btnSaturationUp;
        private System.Windows.Forms.Button btnSaturationDown;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.NumericUpDown nudSaturation;
        private System.Windows.Forms.Button btnSharpnessUp;
        private System.Windows.Forms.Button btnSharpnessDown;
        private System.Windows.Forms.Label lblSharpness;
        private System.Windows.Forms.NumericUpDown nudSharpness;
        private System.Windows.Forms.Label lblBufferFrames;
        private System.Windows.Forms.Button btnTrig;
        private System.Windows.Forms.Button btnBufferUp;
        private System.Windows.Forms.Button btnBufferDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBGSaveDivUp;
        private System.Windows.Forms.Button btnBGSaveDivDn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trkTrigger;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.NumericUpDown nudFR;
        private System.Windows.Forms.Button btnFRUp;
        private System.Windows.Forms.Button btnFRDown;
        private System.Windows.Forms.RadioButton rdo30fps;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Button btnResUp;
        private System.Windows.Forms.Button btnResDown;
        private System.Windows.Forms.Panel pnlShutter;
        private System.Windows.Forms.Panel pnlGain;
        private System.Windows.Forms.RadioButton rdo24fps;
        private System.Windows.Forms.Panel pnlFR;
        private System.Windows.Forms.Button btnChangeFormat;
        private System.Windows.Forms.Panel pnlBit;
        private System.Windows.Forms.RadioButton rdo12bit;
        private System.Windows.Forms.RadioButton rdo8bit;
    }
}

