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
            this.btnBlackLevelUp = new System.Windows.Forms.Button();
            this.btnBlackLevelDown = new System.Windows.Forms.Button();
            this.lblBlackLevel = new System.Windows.Forms.Label();
            this.nudBlackLevel = new System.Windows.Forms.NumericUpDown();
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
            this.chkTimestamp = new System.Windows.Forms.CheckBox();
            this.chkFrameCount = new System.Windows.Forms.CheckBox();
            this.chkHistLow = new System.Windows.Forms.CheckBox();
            this.lblXY = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudBlackLevel)).BeginInit();
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
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripButtonCameraControl});
            this.toolStrip1.Location = new System.Drawing.Point(1874, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(240, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(36, 45);
            this.toolStripButtonStart.Text = "Play";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(36, 45);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButtonCameraControl
            // 
            this.toolStripButtonCameraControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCameraControl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCameraControl.Image")));
            this.toolStripButtonCameraControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCameraControl.Name = "toolStripButtonCameraControl";
            this.toolStripButtonCameraControl.Size = new System.Drawing.Size(36, 45);
            this.toolStripButtonCameraControl.Text = "Controls";
            this.toolStripButtonCameraControl.Click += new System.EventHandler(this.toolStripButtonCameraControl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImageSize,
            this.toolStripStatusLabelFrameRate,
            this.toolStripStatusLabelTimestamp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(3028, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelImageSize
            // 
            this.toolStripStatusLabelImageSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelImageSize.Name = "toolStripStatusLabelImageSize";
            this.toolStripStatusLabelImageSize.Size = new System.Drawing.Size(52, 32);
            this.toolStripStatusLabelImageSize.Text = "0x0";
            // 
            // toolStripStatusLabelFrameRate
            // 
            this.toolStripStatusLabelFrameRate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelFrameRate.Name = "toolStripStatusLabelFrameRate";
            this.toolStripStatusLabelFrameRate.Size = new System.Drawing.Size(87, 32);
            this.toolStripStatusLabelFrameRate.Text = "0.00Hz";
            // 
            // toolStripStatusLabelTimestamp
            // 
            this.toolStripStatusLabelTimestamp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripStatusLabelTimestamp.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelTimestamp.Name = "toolStripStatusLabelTimestamp";
            this.toolStripStatusLabelTimestamp.Size = new System.Drawing.Size(219, 32);
            this.toolStripStatusLabelTimestamp.Text = "Camera not started";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(3028, 48);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 40);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCameraToolStripMenuItem
            // 
            this.newCameraToolStripMenuItem.Name = "newCameraToolStripMenuItem";
            this.newCameraToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.newCameraToolStripMenuItem.Text = "New camera";
            this.newCameraToolStripMenuItem.Click += new System.EventHandler(this.OnNewCameraClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 923);
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
            this.lblRawSize.Location = new System.Drawing.Point(2378, 108);
            this.lblRawSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRawSize.Name = "lblRawSize";
            this.lblRawSize.Size = new System.Drawing.Size(258, 37);
            this.lblRawSize.TabIndex = 4;
            this.lblRawSize.Text = "Raw Image BPP:";
            // 
            // nudBufferFrames
            // 
            this.nudBufferFrames.BackColor = System.Drawing.Color.DimGray;
            this.nudBufferFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBufferFrames.ForeColor = System.Drawing.Color.White;
            this.nudBufferFrames.Location = new System.Drawing.Point(2516, 169);
            this.nudBufferFrames.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudBufferFrames.Size = new System.Drawing.Size(200, 69);
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
            this.lblBufferSize.Location = new System.Drawing.Point(2390, 192);
            this.lblBufferSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(111, 37);
            this.lblBufferSize.TabIndex = 9;
            this.lblBufferSize.Text = "Buffer:";
            this.lblBufferSize.Click += new System.EventHandler(this.lblBufferSize_Click);
            // 
            // lblBufferSeconds
            // 
            this.lblBufferSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferSeconds.ForeColor = System.Drawing.Color.White;
            this.lblBufferSeconds.Location = new System.Drawing.Point(2712, 352);
            this.lblBufferSeconds.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBufferSeconds.Name = "lblBufferSeconds";
            this.lblBufferSeconds.Size = new System.Drawing.Size(276, 38);
            this.lblBufferSeconds.TabIndex = 10;
            this.lblBufferSeconds.Text = "[s]";
            this.lblBufferSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBufferGB
            // 
            this.lblBufferGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferGB.ForeColor = System.Drawing.Color.White;
            this.lblBufferGB.Location = new System.Drawing.Point(2744, 300);
            this.lblBufferGB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBufferGB.Name = "lblBufferGB";
            this.lblBufferGB.Size = new System.Drawing.Size(244, 38);
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
            this.btnStart.Location = new System.Drawing.Point(2370, 754);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(290, 96);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // lblFramesBuffered
            // 
            this.lblFramesBuffered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFramesBuffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFramesBuffered.ForeColor = System.Drawing.Color.White;
            this.lblFramesBuffered.Location = new System.Drawing.Point(2662, 483);
            this.lblFramesBuffered.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFramesBuffered.Name = "lblFramesBuffered";
            this.lblFramesBuffered.Size = new System.Drawing.Size(318, 115);
            this.lblFramesBuffered.TabIndex = 13;
            this.lblFramesBuffered.Text = "Frame In: 0\r\nFrame Out: 0\r\nDiff: 0";
            this.lblFramesBuffered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudDD
            // 
            this.nudDD.BackColor = System.Drawing.Color.DimGray;
            this.nudDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDD.ForeColor = System.Drawing.Color.White;
            this.nudDD.Location = new System.Drawing.Point(990, 1035);
            this.nudDD.Margin = new System.Windows.Forms.Padding(6);
            this.nudDD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDD.Name = "nudDD";
            this.nudDD.Size = new System.Drawing.Size(96, 44);
            this.nudDD.TabIndex = 16;
            this.nudDD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDD
            // 
            this.lblDD.AutoSize = true;
            this.lblDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDD.ForeColor = System.Drawing.Color.White;
            this.lblDD.Location = new System.Drawing.Point(746, 1038);
            this.lblDD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDD.Name = "lblDD";
            this.lblDD.Size = new System.Drawing.Size(237, 37);
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
            this.chkAuto30Hz.Location = new System.Drawing.Point(1098, 1038);
            this.chkAuto30Hz.Margin = new System.Windows.Forms.Padding(6);
            this.chkAuto30Hz.Name = "chkAuto30Hz";
            this.chkAuto30Hz.Size = new System.Drawing.Size(200, 41);
            this.chkAuto30Hz.TabIndex = 18;
            this.chkAuto30Hz.Text = "Auto 30Hz";
            this.chkAuto30Hz.UseVisualStyleBackColor = true;
            // 
            // picBuffer
            // 
            this.picBuffer.BackColor = System.Drawing.Color.DimGray;
            this.picBuffer.Location = new System.Drawing.Point(2378, 419);
            this.picBuffer.Margin = new System.Windows.Forms.Padding(6);
            this.picBuffer.Name = "picBuffer";
            this.picBuffer.Size = new System.Drawing.Size(602, 58);
            this.picBuffer.TabIndex = 19;
            this.picBuffer.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(2370, 862);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(290, 96);
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
            this.chkContSave.Location = new System.Drawing.Point(2370, 996);
            this.chkContSave.Margin = new System.Windows.Forms.Padding(6);
            this.chkContSave.Name = "chkContSave";
            this.chkContSave.Size = new System.Drawing.Size(413, 52);
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
            this.nudDiv.Location = new System.Drawing.Point(2590, 1067);
            this.nudDiv.Margin = new System.Windows.Forms.Padding(6);
            this.nudDiv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiv.Name = "nudDiv";
            this.nudDiv.Size = new System.Drawing.Size(126, 69);
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
            this.lblFPS.Location = new System.Drawing.Point(904, 1160);
            this.lblFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(169, 48);
            this.lblFPS.TabIndex = 43;
            this.lblFPS.Text = "= 24 fps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(904, 1256);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 48);
            this.label2.TabIndex = 52;
            this.label2.Text = "px";
            // 
            // lblFPSd
            // 
            this.lblFPSd.BackColor = System.Drawing.Color.Black;
            this.lblFPSd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFPSd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPSd.ForeColor = System.Drawing.Color.White;
            this.lblFPSd.Location = new System.Drawing.Point(564, 54);
            this.lblFPSd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFPSd.Name = "lblFPSd";
            this.lblFPSd.Size = new System.Drawing.Size(230, 42);
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
            this.lblPXd.Location = new System.Drawing.Point(24, 54);
            this.lblPXd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPXd.Name = "lblPXd";
            this.lblPXd.Size = new System.Drawing.Size(282, 42);
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
            this.lblBITd.Location = new System.Drawing.Point(320, 54);
            this.lblBITd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBITd.Name = "lblBITd";
            this.lblBITd.Size = new System.Drawing.Size(230, 42);
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
            this.lblShutterd.Location = new System.Drawing.Point(808, 54);
            this.lblShutterd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShutterd.Name = "lblShutterd";
            this.lblShutterd.Size = new System.Drawing.Size(250, 42);
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
            this.lblGaind.Location = new System.Drawing.Point(1072, 54);
            this.lblGaind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGaind.Name = "lblGaind";
            this.lblGaind.Size = new System.Drawing.Size(232, 42);
            this.lblGaind.TabIndex = 57;
            this.lblGaind.Text = "+0dB";
            this.lblGaind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutterDown
            // 
            this.btnShutterDown.BackColor = System.Drawing.Color.LightGray;
            this.btnShutterDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterDown.Location = new System.Drawing.Point(1814, 158);
            this.btnShutterDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnShutterDown.Name = "btnShutterDown";
            this.btnShutterDown.Size = new System.Drawing.Size(124, 73);
            this.btnShutterDown.TabIndex = 59;
            this.btnShutterDown.Text = "-";
            this.btnShutterDown.UseVisualStyleBackColor = false;
            this.btnShutterDown.Click += new System.EventHandler(this.btnShutterDown_Click);
            // 
            // btnShutterUp
            // 
            this.btnShutterUp.BackColor = System.Drawing.Color.LightGray;
            this.btnShutterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterUp.Location = new System.Drawing.Point(1950, 158);
            this.btnShutterUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnShutterUp.Name = "btnShutterUp";
            this.btnShutterUp.Size = new System.Drawing.Size(124, 73);
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
            this.rdoShutterAngle.Location = new System.Drawing.Point(34, 12);
            this.rdoShutterAngle.Margin = new System.Windows.Forms.Padding(6);
            this.rdoShutterAngle.Name = "rdoShutterAngle";
            this.rdoShutterAngle.Size = new System.Drawing.Size(158, 52);
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
            this.rdoShutterTime.Location = new System.Drawing.Point(34, 79);
            this.rdoShutterTime.Margin = new System.Windows.Forms.Padding(6);
            this.rdoShutterTime.Name = "rdoShutterTime";
            this.rdoShutterTime.Size = new System.Drawing.Size(145, 52);
            this.rdoShutterTime.TabIndex = 62;
            this.rdoShutterTime.Text = "Time";
            this.rdoShutterTime.UseVisualStyleBackColor = false;
            this.rdoShutterTime.CheckedChanged += new System.EventHandler(this.rdoShutterTime_CheckedChanged);
            // 
            // pbShutter
            // 
            this.pbShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pbShutter.Location = new System.Drawing.Point(1568, 104);
            this.pbShutter.Margin = new System.Windows.Forms.Padding(6);
            this.pbShutter.Name = "pbShutter";
            this.pbShutter.Size = new System.Drawing.Size(756, 148);
            this.pbShutter.TabIndex = 63;
            this.pbShutter.TabStop = false;
            // 
            // lblShutterl
            // 
            this.lblShutterl.AutoSize = true;
            this.lblShutterl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblShutterl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutterl.ForeColor = System.Drawing.Color.White;
            this.lblShutterl.Location = new System.Drawing.Point(1572, 104);
            this.lblShutterl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShutterl.Name = "lblShutterl";
            this.lblShutterl.Size = new System.Drawing.Size(129, 37);
            this.lblShutterl.TabIndex = 64;
            this.lblShutterl.Text = "Shutter:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(2340, 54);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(664, 1435);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // lblRecording
            // 
            this.lblRecording.AutoSize = true;
            this.lblRecording.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecording.ForeColor = System.Drawing.Color.White;
            this.lblRecording.Location = new System.Drawing.Point(2340, 54);
            this.lblRecording.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecording.Name = "lblRecording";
            this.lblRecording.Size = new System.Drawing.Size(171, 37);
            this.lblRecording.TabIndex = 66;
            this.lblRecording.Text = "Recording:";
            // 
            // lblGainl
            // 
            this.lblGainl.AutoSize = true;
            this.lblGainl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGainl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainl.ForeColor = System.Drawing.Color.White;
            this.lblGainl.Location = new System.Drawing.Point(1568, 263);
            this.lblGainl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGainl.Name = "lblGainl";
            this.lblGainl.Size = new System.Drawing.Size(94, 37);
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
            this.rdoGainISO.Location = new System.Drawing.Point(28, 75);
            this.rdoGainISO.Margin = new System.Windows.Forms.Padding(6);
            this.rdoGainISO.Name = "rdoGainISO";
            this.rdoGainISO.Size = new System.Drawing.Size(124, 52);
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
            this.rdoGainDB.Location = new System.Drawing.Point(28, 8);
            this.rdoGainDB.Margin = new System.Windows.Forms.Padding(6);
            this.rdoGainDB.Name = "rdoGainDB";
            this.rdoGainDB.Size = new System.Drawing.Size(102, 52);
            this.rdoGainDB.TabIndex = 69;
            this.rdoGainDB.TabStop = true;
            this.rdoGainDB.Text = "dB";
            this.rdoGainDB.UseVisualStyleBackColor = false;
            // 
            // btnGainUp
            // 
            this.btnGainUp.BackColor = System.Drawing.Color.LightGray;
            this.btnGainUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainUp.Location = new System.Drawing.Point(1950, 317);
            this.btnGainUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnGainUp.Name = "btnGainUp";
            this.btnGainUp.Size = new System.Drawing.Size(124, 73);
            this.btnGainUp.TabIndex = 68;
            this.btnGainUp.Text = "+";
            this.btnGainUp.UseVisualStyleBackColor = false;
            this.btnGainUp.Click += new System.EventHandler(this.btnGainUp_Click);
            // 
            // btnGainDown
            // 
            this.btnGainDown.BackColor = System.Drawing.Color.LightGray;
            this.btnGainDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainDown.Location = new System.Drawing.Point(1814, 317);
            this.btnGainDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnGainDown.Name = "btnGainDown";
            this.btnGainDown.Size = new System.Drawing.Size(124, 73);
            this.btnGainDown.TabIndex = 67;
            this.btnGainDown.Text = "-";
            this.btnGainDown.UseVisualStyleBackColor = false;
            this.btnGainDown.Click += new System.EventHandler(this.btnGainDown_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(1568, 263);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(756, 148);
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(24, 1096);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1532, 392);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // lblFormatl
            // 
            this.lblFormatl.AutoSize = true;
            this.lblFormatl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatl.ForeColor = System.Drawing.Color.White;
            this.lblFormatl.Location = new System.Drawing.Point(24, 1096);
            this.lblFormatl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormatl.Name = "lblFormatl";
            this.lblFormatl.Size = new System.Drawing.Size(129, 37);
            this.lblFormatl.TabIndex = 74;
            this.lblFormatl.Text = "Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1568, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 37);
            this.label4.TabIndex = 80;
            this.label4.Text = "White Balance:";
            // 
            // btnBlueUp
            // 
            this.btnBlueUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueUp.Location = new System.Drawing.Point(1826, 467);
            this.btnBlueUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlueUp.Name = "btnBlueUp";
            this.btnBlueUp.Size = new System.Drawing.Size(102, 73);
            this.btnBlueUp.TabIndex = 76;
            this.btnBlueUp.Text = "+";
            this.btnBlueUp.UseVisualStyleBackColor = false;
            this.btnBlueUp.Click += new System.EventHandler(this.btnBlueUp_Click);
            // 
            // btnBlueDown
            // 
            this.btnBlueDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDown.Location = new System.Drawing.Point(1712, 467);
            this.btnBlueDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlueDown.Name = "btnBlueDown";
            this.btnBlueDown.Size = new System.Drawing.Size(102, 73);
            this.btnBlueDown.TabIndex = 75;
            this.btnBlueDown.Text = "-";
            this.btnBlueDown.UseVisualStyleBackColor = false;
            this.btnBlueDown.Click += new System.EventHandler(this.btnBlueDown_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox5.Location = new System.Drawing.Point(1568, 423);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(756, 223);
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // btnRedUp
            // 
            this.btnRedUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedUp.Location = new System.Drawing.Point(1826, 552);
            this.btnRedUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnRedUp.Name = "btnRedUp";
            this.btnRedUp.Size = new System.Drawing.Size(102, 73);
            this.btnRedUp.TabIndex = 82;
            this.btnRedUp.Text = "+";
            this.btnRedUp.UseVisualStyleBackColor = false;
            this.btnRedUp.Click += new System.EventHandler(this.btnRedUp_Click);
            // 
            // btnRedDown
            // 
            this.btnRedDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDown.Location = new System.Drawing.Point(1712, 552);
            this.btnRedDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnRedDown.Name = "btnRedDown";
            this.btnRedDown.Size = new System.Drawing.Size(102, 73);
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
            this.lblBlued.Location = new System.Drawing.Point(266, 1037);
            this.lblBlued.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBlued.Name = "lblBlued";
            this.lblBlued.Size = new System.Drawing.Size(218, 42);
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
            this.lblRedd.Location = new System.Drawing.Point(26, 1037);
            this.lblRedd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRedd.Name = "lblRedd";
            this.lblRedd.Size = new System.Drawing.Size(226, 42);
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
            this.lblColorTempd.Location = new System.Drawing.Point(500, 1035);
            this.lblColorTempd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColorTempd.Name = "lblColorTempd";
            this.lblColorTempd.Size = new System.Drawing.Size(232, 42);
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
            this.chkWBSpot.Location = new System.Drawing.Point(2150, 479);
            this.chkWBSpot.Margin = new System.Windows.Forms.Padding(6);
            this.chkWBSpot.Name = "chkWBSpot";
            this.chkWBSpot.Size = new System.Drawing.Size(138, 52);
            this.chkWBSpot.TabIndex = 86;
            this.chkWBSpot.Text = "Spot";
            this.chkWBSpot.UseVisualStyleBackColor = false;
            // 
            // picHistFrame
            // 
            this.picHistFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.picHistFrame.Location = new System.Drawing.Point(1568, 658);
            this.picHistFrame.Margin = new System.Windows.Forms.Padding(6);
            this.picHistFrame.Name = "picHistFrame";
            this.picHistFrame.Size = new System.Drawing.Size(756, 263);
            this.picHistFrame.TabIndex = 87;
            this.picHistFrame.TabStop = false;
            // 
            // picHist
            // 
            this.picHist.BackColor = System.Drawing.Color.Black;
            this.picHist.Location = new System.Drawing.Point(1604, 702);
            this.picHist.Margin = new System.Windows.Forms.Padding(6);
            this.picHist.Name = "picHist";
            this.picHist.Size = new System.Drawing.Size(510, 192);
            this.picHist.TabIndex = 88;
            this.picHist.TabStop = false;
            // 
            // lblHistl
            // 
            this.lblHistl.AutoSize = true;
            this.lblHistl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHistl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistl.ForeColor = System.Drawing.Color.White;
            this.lblHistl.Location = new System.Drawing.Point(1568, 658);
            this.lblHistl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHistl.Name = "lblHistl";
            this.lblHistl.Size = new System.Drawing.Size(173, 37);
            this.lblHistl.TabIndex = 89;
            this.lblHistl.Text = "Histogram:";
            // 
            // chkHistOn
            // 
            this.chkHistOn.AutoSize = true;
            this.chkHistOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkHistOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHistOn.ForeColor = System.Drawing.Color.White;
            this.chkHistOn.Location = new System.Drawing.Point(2150, 679);
            this.chkHistOn.Margin = new System.Windows.Forms.Padding(6);
            this.chkHistOn.Name = "chkHistOn";
            this.chkHistOn.Size = new System.Drawing.Size(125, 52);
            this.chkHistOn.TabIndex = 90;
            this.chkHistOn.Text = "Fire";
            this.chkHistOn.UseVisualStyleBackColor = false;
            this.chkHistOn.CheckedChanged += new System.EventHandler(this.chkHistOn_CheckedChanged);
            // 
            // btnBusUp
            // 
            this.btnBusUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBusUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusUp.Location = new System.Drawing.Point(768, 1313);
            this.btnBusUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBusUp.Name = "btnBusUp";
            this.btnBusUp.Size = new System.Drawing.Size(124, 73);
            this.btnBusUp.TabIndex = 92;
            this.btnBusUp.Text = "+";
            this.btnBusUp.UseVisualStyleBackColor = false;
            this.btnBusUp.Click += new System.EventHandler(this.btnBusUp_Click);
            // 
            // btnBusDown
            // 
            this.btnBusDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBusDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusDown.Location = new System.Drawing.Point(632, 1313);
            this.btnBusDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBusDown.Name = "btnBusDown";
            this.btnBusDown.Size = new System.Drawing.Size(124, 73);
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
            this.lblBusd.Location = new System.Drawing.Point(904, 1331);
            this.lblBusd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBusd.Name = "lblBusd";
            this.lblBusd.Size = new System.Drawing.Size(186, 48);
            this.lblBusd.TabIndex = 94;
            this.lblBusd.Text = "95% Bus";
            // 
            // btnBlueUpUp
            // 
            this.btnBlueUpUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueUpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueUpUp.Location = new System.Drawing.Point(1940, 467);
            this.btnBlueUpUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlueUpUp.Name = "btnBlueUpUp";
            this.btnBlueUpUp.Size = new System.Drawing.Size(102, 73);
            this.btnBlueUpUp.TabIndex = 95;
            this.btnBlueUpUp.Text = "++";
            this.btnBlueUpUp.UseVisualStyleBackColor = false;
            this.btnBlueUpUp.Click += new System.EventHandler(this.btnBlueUpUp_Click);
            // 
            // btnBlueDownDown
            // 
            this.btnBlueDownDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBlueDownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDownDown.Location = new System.Drawing.Point(1604, 467);
            this.btnBlueDownDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlueDownDown.Name = "btnBlueDownDown";
            this.btnBlueDownDown.Size = new System.Drawing.Size(96, 73);
            this.btnBlueDownDown.TabIndex = 96;
            this.btnBlueDownDown.Text = "--";
            this.btnBlueDownDown.UseVisualStyleBackColor = false;
            this.btnBlueDownDown.Click += new System.EventHandler(this.btnBlueDownDown_Click);
            // 
            // btnRedDownDown
            // 
            this.btnRedDownDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedDownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDownDown.Location = new System.Drawing.Point(1604, 552);
            this.btnRedDownDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnRedDownDown.Name = "btnRedDownDown";
            this.btnRedDownDown.Size = new System.Drawing.Size(96, 73);
            this.btnRedDownDown.TabIndex = 97;
            this.btnRedDownDown.Text = "--";
            this.btnRedDownDown.UseVisualStyleBackColor = false;
            this.btnRedDownDown.Click += new System.EventHandler(this.btnRedDownDown_Click);
            // 
            // btnRedUpUp
            // 
            this.btnRedUpUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRedUpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedUpUp.Location = new System.Drawing.Point(1940, 552);
            this.btnRedUpUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnRedUpUp.Name = "btnRedUpUp";
            this.btnRedUpUp.Size = new System.Drawing.Size(102, 73);
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
            this.txtDiag.Location = new System.Drawing.Point(2370, 1212);
            this.txtDiag.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiag.Multiline = true;
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(606, 264);
            this.txtDiag.TabIndex = 99;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.ForeColor = System.Drawing.Color.White;
            this.lblDiag.Location = new System.Drawing.Point(2370, 1167);
            this.lblDiag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(373, 37);
            this.lblDiag.TabIndex = 100;
            this.lblDiag.Text = "Thread Diagnostics [ms]:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox6.Location = new System.Drawing.Point(1568, 933);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(760, 556);
            this.pictureBox6.TabIndex = 101;
            this.pictureBox6.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(1568, 933);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(137, 37);
            this.lblPreview.TabIndex = 102;
            this.lblPreview.Text = "Preview:";
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRaw.ForeColor = System.Drawing.Color.White;
            this.chkRaw.Location = new System.Drawing.Point(1580, 977);
            this.chkRaw.Margin = new System.Windows.Forms.Padding(6);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(307, 52);
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
            this.nudGamma.Location = new System.Drawing.Point(1810, 1131);
            this.nudGamma.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudGamma.Size = new System.Drawing.Size(232, 69);
            this.nudGamma.TabIndex = 104;
            this.nudGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGamma.Value = new decimal(new int[] {
            44,
            0,
            0,
            65536});
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamma.ForeColor = System.Drawing.Color.White;
            this.lblGamma.Location = new System.Drawing.Point(1658, 1152);
            this.lblGamma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(141, 37);
            this.lblGamma.TabIndex = 105;
            this.lblGamma.Text = "Gamma:";
            // 
            // btnGammaUp
            // 
            this.btnGammaUp.BackColor = System.Drawing.Color.LightGray;
            this.btnGammaUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGammaUp.Location = new System.Drawing.Point(2190, 1131);
            this.btnGammaUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnGammaUp.Name = "btnGammaUp";
            this.btnGammaUp.Size = new System.Drawing.Size(124, 73);
            this.btnGammaUp.TabIndex = 107;
            this.btnGammaUp.Text = "+";
            this.btnGammaUp.UseVisualStyleBackColor = false;
            this.btnGammaUp.Click += new System.EventHandler(this.btnGammaUp_Click);
            // 
            // btnGammaDown
            // 
            this.btnGammaDown.BackColor = System.Drawing.Color.LightGray;
            this.btnGammaDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGammaDown.Location = new System.Drawing.Point(2054, 1131);
            this.btnGammaDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnGammaDown.Name = "btnGammaDown";
            this.btnGammaDown.Size = new System.Drawing.Size(124, 73);
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
            this.chkClip.Location = new System.Drawing.Point(1950, 975);
            this.chkClip.Margin = new System.Windows.Forms.Padding(6);
            this.chkClip.Name = "chkClip";
            this.chkClip.Size = new System.Drawing.Size(319, 52);
            this.chkClip.TabIndex = 108;
            this.chkClip.Text = "Show Clipping";
            this.chkClip.UseVisualStyleBackColor = false;
            // 
            // btnBrightnessUp
            // 
            this.btnBrightnessUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBrightnessUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightnessUp.Location = new System.Drawing.Point(2190, 1216);
            this.btnBrightnessUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrightnessUp.Name = "btnBrightnessUp";
            this.btnBrightnessUp.Size = new System.Drawing.Size(124, 73);
            this.btnBrightnessUp.TabIndex = 112;
            this.btnBrightnessUp.Text = "+";
            this.btnBrightnessUp.UseVisualStyleBackColor = false;
            this.btnBrightnessUp.Click += new System.EventHandler(this.btnBrightnessUp_Click);
            // 
            // btnBrightnessDown
            // 
            this.btnBrightnessDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBrightnessDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightnessDown.Location = new System.Drawing.Point(2054, 1216);
            this.btnBrightnessDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrightnessDown.Name = "btnBrightnessDown";
            this.btnBrightnessDown.Size = new System.Drawing.Size(124, 73);
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
            this.lblBrightness.Location = new System.Drawing.Point(1620, 1237);
            this.lblBrightness.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(177, 37);
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
            this.nudBrightness.Location = new System.Drawing.Point(1810, 1216);
            this.nudBrightness.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudBrightness.Size = new System.Drawing.Size(232, 69);
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
            this.btnContrastUp.Location = new System.Drawing.Point(2190, 1300);
            this.btnContrastUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnContrastUp.Name = "btnContrastUp";
            this.btnContrastUp.Size = new System.Drawing.Size(124, 73);
            this.btnContrastUp.TabIndex = 116;
            this.btnContrastUp.Text = "+";
            this.btnContrastUp.UseVisualStyleBackColor = false;
            this.btnContrastUp.Click += new System.EventHandler(this.btnContrastUp_Click);
            // 
            // btnContrastDown
            // 
            this.btnContrastDown.BackColor = System.Drawing.Color.LightGray;
            this.btnContrastDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrastDown.Location = new System.Drawing.Point(2054, 1300);
            this.btnContrastDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnContrastDown.Name = "btnContrastDown";
            this.btnContrastDown.Size = new System.Drawing.Size(124, 73);
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
            this.lblContrast.Location = new System.Drawing.Point(1650, 1322);
            this.lblContrast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(148, 37);
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
            this.nudContrast.Location = new System.Drawing.Point(1810, 1300);
            this.nudContrast.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudContrast.Size = new System.Drawing.Size(232, 69);
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
            this.btnSaturationUp.Location = new System.Drawing.Point(2190, 1387);
            this.btnSaturationUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaturationUp.Name = "btnSaturationUp";
            this.btnSaturationUp.Size = new System.Drawing.Size(124, 73);
            this.btnSaturationUp.TabIndex = 120;
            this.btnSaturationUp.Text = "+";
            this.btnSaturationUp.UseVisualStyleBackColor = false;
            this.btnSaturationUp.Click += new System.EventHandler(this.btnSaturationUp_Click);
            // 
            // btnSaturationDown
            // 
            this.btnSaturationDown.BackColor = System.Drawing.Color.LightGray;
            this.btnSaturationDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturationDown.Location = new System.Drawing.Point(2054, 1387);
            this.btnSaturationDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaturationDown.Name = "btnSaturationDown";
            this.btnSaturationDown.Size = new System.Drawing.Size(124, 73);
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
            this.lblSaturation.Location = new System.Drawing.Point(1624, 1408);
            this.lblSaturation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(173, 37);
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
            this.nudSaturation.Location = new System.Drawing.Point(1810, 1387);
            this.nudSaturation.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudSaturation.Size = new System.Drawing.Size(232, 69);
            this.nudSaturation.TabIndex = 117;
            this.nudSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSaturation.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btnBlackLevelUp
            // 
            this.btnBlackLevelUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBlackLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackLevelUp.Location = new System.Drawing.Point(2190, 1050);
            this.btnBlackLevelUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlackLevelUp.Name = "btnBlackLevelUp";
            this.btnBlackLevelUp.Size = new System.Drawing.Size(124, 73);
            this.btnBlackLevelUp.TabIndex = 124;
            this.btnBlackLevelUp.Text = "+";
            this.btnBlackLevelUp.UseVisualStyleBackColor = false;
            this.btnBlackLevelUp.Click += new System.EventHandler(this.btnBlackLevelUp_Click);
            // 
            // btnBlackLevelDown
            // 
            this.btnBlackLevelDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBlackLevelDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackLevelDown.Location = new System.Drawing.Point(2054, 1050);
            this.btnBlackLevelDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlackLevelDown.Name = "btnBlackLevelDown";
            this.btnBlackLevelDown.Size = new System.Drawing.Size(124, 73);
            this.btnBlackLevelDown.TabIndex = 123;
            this.btnBlackLevelDown.Text = "-";
            this.btnBlackLevelDown.UseVisualStyleBackColor = false;
            this.btnBlackLevelDown.Click += new System.EventHandler(this.btnBlackLevelDown_Click);
            // 
            // lblBlackLevel
            // 
            this.lblBlackLevel.AutoSize = true;
            this.lblBlackLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBlackLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackLevel.ForeColor = System.Drawing.Color.White;
            this.lblBlackLevel.Location = new System.Drawing.Point(1610, 1072);
            this.lblBlackLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBlackLevel.Name = "lblBlackLevel";
            this.lblBlackLevel.Size = new System.Drawing.Size(187, 37);
            this.lblBlackLevel.TabIndex = 122;
            this.lblBlackLevel.Text = "Black Level:";
            // 
            // nudBlackLevel
            // 
            this.nudBlackLevel.BackColor = System.Drawing.Color.DimGray;
            this.nudBlackLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBlackLevel.ForeColor = System.Drawing.Color.White;
            this.nudBlackLevel.Location = new System.Drawing.Point(1810, 1050);
            this.nudBlackLevel.Margin = new System.Windows.Forms.Padding(6);
            this.nudBlackLevel.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nudBlackLevel.Name = "nudBlackLevel";
            this.nudBlackLevel.Size = new System.Drawing.Size(232, 69);
            this.nudBlackLevel.TabIndex = 121;
            this.nudBlackLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBlackLevel.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // lblBufferFrames
            // 
            this.lblBufferFrames.AutoSize = true;
            this.lblBufferFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBufferFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferFrames.ForeColor = System.Drawing.Color.White;
            this.lblBufferFrames.Location = new System.Drawing.Point(2856, 248);
            this.lblBufferFrames.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBufferFrames.Name = "lblBufferFrames";
            this.lblBufferFrames.Size = new System.Drawing.Size(133, 37);
            this.lblBufferFrames.TabIndex = 8;
            this.lblBufferFrames.Text = "[frames]";
            // 
            // btnTrig
            // 
            this.btnTrig.BackColor = System.Drawing.Color.DarkRed;
            this.btnTrig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrig.ForeColor = System.Drawing.Color.White;
            this.btnTrig.Location = new System.Drawing.Point(2690, 754);
            this.btnTrig.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrig.Name = "btnTrig";
            this.btnTrig.Size = new System.Drawing.Size(290, 96);
            this.btnTrig.TabIndex = 125;
            this.btnTrig.Text = "TRIG";
            this.btnTrig.UseVisualStyleBackColor = false;
            this.btnTrig.Click += new System.EventHandler(this.btnTrig_Click);
            // 
            // btnBufferUp
            // 
            this.btnBufferUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBufferUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBufferUp.Location = new System.Drawing.Point(2864, 169);
            this.btnBufferUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBufferUp.Name = "btnBufferUp";
            this.btnBufferUp.Size = new System.Drawing.Size(124, 73);
            this.btnBufferUp.TabIndex = 127;
            this.btnBufferUp.Text = "+";
            this.btnBufferUp.UseVisualStyleBackColor = false;
            // 
            // btnBufferDown
            // 
            this.btnBufferDown.BackColor = System.Drawing.Color.LightGray;
            this.btnBufferDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBufferDown.Location = new System.Drawing.Point(2728, 169);
            this.btnBufferDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnBufferDown.Name = "btnBufferDown";
            this.btnBufferDown.Size = new System.Drawing.Size(124, 73);
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
            this.label1.Location = new System.Drawing.Point(2456, 1090);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 128;
            this.label1.Text = "Divider:";
            // 
            // btnBGSaveDivUp
            // 
            this.btnBGSaveDivUp.BackColor = System.Drawing.Color.LightGray;
            this.btnBGSaveDivUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGSaveDivUp.Location = new System.Drawing.Point(2864, 1067);
            this.btnBGSaveDivUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBGSaveDivUp.Name = "btnBGSaveDivUp";
            this.btnBGSaveDivUp.Size = new System.Drawing.Size(124, 73);
            this.btnBGSaveDivUp.TabIndex = 130;
            this.btnBGSaveDivUp.Text = "+";
            this.btnBGSaveDivUp.UseVisualStyleBackColor = false;
            this.btnBGSaveDivUp.Click += new System.EventHandler(this.btnBGSaveDivUp_Click);
            // 
            // btnBGSaveDivDn
            // 
            this.btnBGSaveDivDn.BackColor = System.Drawing.Color.LightGray;
            this.btnBGSaveDivDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGSaveDivDn.Location = new System.Drawing.Point(2728, 1067);
            this.btnBGSaveDivDn.Margin = new System.Windows.Forms.Padding(6);
            this.btnBGSaveDivDn.Name = "btnBGSaveDivDn";
            this.btnBGSaveDivDn.Size = new System.Drawing.Size(124, 73);
            this.btnBGSaveDivDn.TabIndex = 129;
            this.btnBGSaveDivDn.Text = "-";
            this.btnBGSaveDivDn.UseVisualStyleBackColor = false;
            this.btnBGSaveDivDn.Click += new System.EventHandler(this.btnBGSaveDivDn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(2690, 862);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(290, 96);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trkTrigger
            // 
            this.trkTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trkTrigger.LargeChange = 2;
            this.trkTrigger.Location = new System.Drawing.Point(2370, 656);
            this.trkTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.trkTrigger.Name = "trkTrigger";
            this.trkTrigger.Size = new System.Drawing.Size(618, 90);
            this.trkTrigger.TabIndex = 132;
            this.trkTrigger.Value = 5;
            this.trkTrigger.Scroll += new System.EventHandler(this.trkTrigger_Scroll);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.ForeColor = System.Drawing.Color.White;
            this.lblTrigger.Location = new System.Drawing.Point(2378, 608);
            this.lblTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(251, 37);
            this.lblTrigger.TabIndex = 133;
            this.lblTrigger.Text = "Trigger Position:";
            // 
            // nudFR
            // 
            this.nudFR.BackColor = System.Drawing.Color.DimGray;
            this.nudFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFR.ForeColor = System.Drawing.Color.White;
            this.nudFR.Location = new System.Drawing.Point(450, 1144);
            this.nudFR.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudFR.Size = new System.Drawing.Size(170, 69);
            this.nudFR.TabIndex = 135;
            this.nudFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFR.ValueChanged += new System.EventHandler(this.nudFR_ValueChanged);
            // 
            // btnFRUp
            // 
            this.btnFRUp.BackColor = System.Drawing.Color.LightGray;
            this.btnFRUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRUp.Location = new System.Drawing.Point(768, 1144);
            this.btnFRUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnFRUp.Name = "btnFRUp";
            this.btnFRUp.Size = new System.Drawing.Size(124, 73);
            this.btnFRUp.TabIndex = 137;
            this.btnFRUp.Text = "+";
            this.btnFRUp.UseVisualStyleBackColor = false;
            this.btnFRUp.Click += new System.EventHandler(this.btnFRUp_Click);
            // 
            // btnFRDown
            // 
            this.btnFRDown.BackColor = System.Drawing.Color.LightGray;
            this.btnFRDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFRDown.Location = new System.Drawing.Point(632, 1144);
            this.btnFRDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnFRDown.Name = "btnFRDown";
            this.btnFRDown.Size = new System.Drawing.Size(124, 73);
            this.btnFRDown.TabIndex = 136;
            this.btnFRDown.Text = "-";
            this.btnFRDown.UseVisualStyleBackColor = false;
            this.btnFRDown.Click += new System.EventHandler(this.btnFRDown_Click);
            // 
            // rdo30fps
            // 
            this.rdo30fps.AutoSize = true;
            this.rdo30fps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo30fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo30fps.ForeColor = System.Drawing.Color.White;
            this.rdo30fps.Location = new System.Drawing.Point(200, 12);
            this.rdo30fps.Margin = new System.Windows.Forms.Padding(6);
            this.rdo30fps.Name = "rdo30fps";
            this.rdo30fps.Size = new System.Drawing.Size(185, 52);
            this.rdo30fps.TabIndex = 139;
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
            this.cmbResolution.Location = new System.Drawing.Point(60, 1229);
            this.cmbResolution.Margin = new System.Windows.Forms.Padding(6);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(556, 71);
            this.cmbResolution.TabIndex = 140;
            this.cmbResolution.Text = "Resolution";
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // btnResUp
            // 
            this.btnResUp.BackColor = System.Drawing.Color.LightGray;
            this.btnResUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResUp.Location = new System.Drawing.Point(768, 1229);
            this.btnResUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnResUp.Name = "btnResUp";
            this.btnResUp.Size = new System.Drawing.Size(124, 73);
            this.btnResUp.TabIndex = 142;
            this.btnResUp.Text = "+";
            this.btnResUp.UseVisualStyleBackColor = false;
            this.btnResUp.Click += new System.EventHandler(this.btnResUp_Click);
            // 
            // btnResDown
            // 
            this.btnResDown.BackColor = System.Drawing.Color.LightGray;
            this.btnResDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResDown.Location = new System.Drawing.Point(632, 1229);
            this.btnResDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnResDown.Name = "btnResDown";
            this.btnResDown.Size = new System.Drawing.Size(124, 73);
            this.btnResDown.TabIndex = 141;
            this.btnResDown.Text = "-";
            this.btnResDown.UseVisualStyleBackColor = false;
            this.btnResDown.Click += new System.EventHandler(this.btnResDown_Click);
            // 
            // pnlShutter
            // 
            this.pnlShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlShutter.Controls.Add(this.rdoShutterTime);
            this.pnlShutter.Controls.Add(this.rdoShutterAngle);
            this.pnlShutter.Location = new System.Drawing.Point(2084, 108);
            this.pnlShutter.Margin = new System.Windows.Forms.Padding(6);
            this.pnlShutter.Name = "pnlShutter";
            this.pnlShutter.Size = new System.Drawing.Size(238, 142);
            this.pnlShutter.TabIndex = 143;
            // 
            // pnlGain
            // 
            this.pnlGain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlGain.Controls.Add(this.rdoGainISO);
            this.pnlGain.Controls.Add(this.rdoGainDB);
            this.pnlGain.Location = new System.Drawing.Point(2084, 265);
            this.pnlGain.Margin = new System.Windows.Forms.Padding(6);
            this.pnlGain.Name = "pnlGain";
            this.pnlGain.Size = new System.Drawing.Size(238, 144);
            this.pnlGain.TabIndex = 144;
            // 
            // rdo24fps
            // 
            this.rdo24fps.AutoSize = true;
            this.rdo24fps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo24fps.Checked = true;
            this.rdo24fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo24fps.ForeColor = System.Drawing.Color.White;
            this.rdo24fps.Location = new System.Drawing.Point(22, 12);
            this.rdo24fps.Margin = new System.Windows.Forms.Padding(6);
            this.rdo24fps.Name = "rdo24fps";
            this.rdo24fps.Size = new System.Drawing.Size(153, 52);
            this.rdo24fps.TabIndex = 138;
            this.rdo24fps.TabStop = true;
            this.rdo24fps.Text = "24fps";
            this.rdo24fps.UseVisualStyleBackColor = false;
            // 
            // pnlFR
            // 
            this.pnlFR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlFR.Controls.Add(this.rdo30fps);
            this.pnlFR.Controls.Add(this.rdo24fps);
            this.pnlFR.Location = new System.Drawing.Point(38, 1144);
            this.pnlFR.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFR.Name = "pnlFR";
            this.pnlFR.Size = new System.Drawing.Size(412, 73);
            this.pnlFR.TabIndex = 145;
            // 
            // btnChangeFormat
            // 
            this.btnChangeFormat.BackColor = System.Drawing.Color.LightGray;
            this.btnChangeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFormat.Location = new System.Drawing.Point(1188, 1238);
            this.btnChangeFormat.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangeFormat.Name = "btnChangeFormat";
            this.btnChangeFormat.Size = new System.Drawing.Size(256, 175);
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
            this.pnlBit.Location = new System.Drawing.Point(38, 1315);
            this.pnlBit.Margin = new System.Windows.Forms.Padding(6);
            this.pnlBit.Name = "pnlBit";
            this.pnlBit.Size = new System.Drawing.Size(412, 73);
            this.pnlBit.TabIndex = 147;
            // 
            // rdo12bit
            // 
            this.rdo12bit.AutoSize = true;
            this.rdo12bit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo12bit.Checked = true;
            this.rdo12bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo12bit.ForeColor = System.Drawing.Color.White;
            this.rdo12bit.Location = new System.Drawing.Point(200, 12);
            this.rdo12bit.Margin = new System.Windows.Forms.Padding(6);
            this.rdo12bit.Name = "rdo12bit";
            this.rdo12bit.Size = new System.Drawing.Size(156, 52);
            this.rdo12bit.TabIndex = 139;
            this.rdo12bit.TabStop = true;
            this.rdo12bit.Text = "12-bit";
            this.rdo12bit.UseVisualStyleBackColor = false;
            // 
            // rdo8bit
            // 
            this.rdo8bit.AllowDrop = true;
            this.rdo8bit.AutoSize = true;
            this.rdo8bit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdo8bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo8bit.ForeColor = System.Drawing.Color.White;
            this.rdo8bit.Location = new System.Drawing.Point(22, 12);
            this.rdo8bit.Margin = new System.Windows.Forms.Padding(6);
            this.rdo8bit.Name = "rdo8bit";
            this.rdo8bit.Size = new System.Drawing.Size(133, 52);
            this.rdo8bit.TabIndex = 138;
            this.rdo8bit.Text = "8-bit";
            this.rdo8bit.UseVisualStyleBackColor = false;
            // 
            // chkTimestamp
            // 
            this.chkTimestamp.AutoSize = true;
            this.chkTimestamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkTimestamp.Checked = true;
            this.chkTimestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimestamp.ForeColor = System.Drawing.Color.White;
            this.chkTimestamp.Location = new System.Drawing.Point(38, 1400);
            this.chkTimestamp.Margin = new System.Windows.Forms.Padding(6);
            this.chkTimestamp.Name = "chkTimestamp";
            this.chkTimestamp.Size = new System.Drawing.Size(260, 52);
            this.chkTimestamp.TabIndex = 148;
            this.chkTimestamp.Text = "Timestamp";
            this.chkTimestamp.UseVisualStyleBackColor = false;
            this.chkTimestamp.CheckedChanged += new System.EventHandler(this.chkTimestamp_CheckedChanged);
            // 
            // chkFrameCount
            // 
            this.chkFrameCount.AutoSize = true;
            this.chkFrameCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkFrameCount.Checked = true;
            this.chkFrameCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFrameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFrameCount.ForeColor = System.Drawing.Color.White;
            this.chkFrameCount.Location = new System.Drawing.Point(310, 1400);
            this.chkFrameCount.Margin = new System.Windows.Forms.Padding(6);
            this.chkFrameCount.Name = "chkFrameCount";
            this.chkFrameCount.Size = new System.Drawing.Size(295, 52);
            this.chkFrameCount.TabIndex = 149;
            this.chkFrameCount.Text = "Frame Count";
            this.chkFrameCount.UseVisualStyleBackColor = false;
            this.chkFrameCount.CheckedChanged += new System.EventHandler(this.chkFrameCount_CheckedChanged);
            // 
            // chkHistLow
            // 
            this.chkHistLow.AutoSize = true;
            this.chkHistLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkHistLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHistLow.ForeColor = System.Drawing.Color.White;
            this.chkHistLow.Location = new System.Drawing.Point(2152, 746);
            this.chkHistLow.Margin = new System.Windows.Forms.Padding(6);
            this.chkHistLow.Name = "chkHistLow";
            this.chkHistLow.Size = new System.Drawing.Size(128, 52);
            this.chkHistLow.TabIndex = 150;
            this.chkHistLow.Text = "Low";
            this.chkHistLow.UseVisualStyleBackColor = false;
            this.chkHistLow.CheckedChanged += new System.EventHandler(this.chkHistLow_CheckedChanged);
            // 
            // lblXY
            // 
            this.lblXY.BackColor = System.Drawing.Color.Black;
            this.lblXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXY.ForeColor = System.Drawing.Color.White;
            this.lblXY.Location = new System.Drawing.Point(1318, 52);
            this.lblXY.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(240, 42);
            this.lblXY.TabIndex = 151;
            this.lblXY.Text = "0,0";
            this.lblXY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(3028, 1540);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkHistLow);
            this.Controls.Add(this.chkFrameCount);
            this.Controls.Add(this.chkTimestamp);
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
            this.Controls.Add(this.btnBlackLevelUp);
            this.Controls.Add(this.btnBlackLevelDown);
            this.Controls.Add(this.lblBlackLevel);
            this.Controls.Add(this.nudBlackLevel);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1254, 858);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudBlackLevel)).EndInit();
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
        private System.Windows.Forms.Button btnBlackLevelUp;
        private System.Windows.Forms.Button btnBlackLevelDown;
        private System.Windows.Forms.Label lblBlackLevel;
        private System.Windows.Forms.NumericUpDown nudBlackLevel;
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
        private System.Windows.Forms.CheckBox chkTimestamp;
        private System.Windows.Forms.CheckBox chkFrameCount;
        private System.Windows.Forms.CheckBox chkHistLow;
        private System.Windows.Forms.Label lblXY;
    }
}

