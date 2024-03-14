namespace Plane_Controller
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogoTubitak = new System.Windows.Forms.PictureBox();
            this.LogoUM = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Failsafe = new System.Windows.Forms.Label();
            this.EngineStart = new System.Windows.Forms.Button();
            this.FlightModes = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BPercent = new System.Windows.Forms.Label();
            this.BAmp = new System.Windows.Forms.Label();
            this.BVolt = new System.Windows.Forms.Label();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.btnConectSer = new System.Windows.Forms.Button();
            this.cBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Logger = new System.Windows.Forms.TextBox();
            this.InputLogger = new System.Windows.Forms.TextBox();
            this.ButSendLog = new System.Windows.Forms.Button();
            this.BtnSaveLog = new System.Windows.Forms.Button();
            this.yaw = new System.Windows.Forms.Label();
            this.GSpeedVal = new System.Windows.Forms.Label();
            this.groundspeed = new System.Windows.Forms.Label();
            this.pitchd = new System.Windows.Forms.Label();
            this.PitchDVal = new System.Windows.Forms.Label();
            this.YawVal = new System.Windows.Forms.Label();
            this.airspeed = new System.Windows.Forms.Label();
            this.altitude = new System.Windows.Forms.Label();
            this.ASpeedVal = new System.Windows.Forms.Label();
            this.AltitudeVal = new System.Windows.Forms.Label();
            this.rolld = new System.Windows.Forms.Label();
            this.RollDVal = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ServoStatus2 = new System.Windows.Forms.Label();
            this.ServoStatus1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ForceServo2 = new System.Windows.Forms.Button();
            this.ForceServo1 = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.CalAccelLabel = new System.Windows.Forms.Label();
            this.CalLevelLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CalibrateLevelBtn = new System.Windows.Forms.Button();
            this.CalibrateAccelBtn = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.FindPlane = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LongPlane = new System.Windows.Forms.Label();
            this.LongPlaneVal = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.LatPlaneVal = new System.Windows.Forms.Label();
            this.LatPlane = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelCoordinate = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.cBoxDraw = new System.Windows.Forms.ComboBox();
            this.cBoxDrawReset = new System.Windows.Forms.Button();
            this.cBoxDrawRemove = new System.Windows.Forms.Button();
            this.cBoxDrawAdd = new System.Windows.Forms.Button();
            this.cBoxDrawSave = new System.Windows.Forms.Button();
            this.DropAreaLoad = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxDrawLongitude = new System.Windows.Forms.TextBox();
            this.cBoxDrawLatitude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.MapsPosSave = new System.Windows.Forms.Button();
            this.MapsPosLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxMapType = new System.Windows.Forms.ComboBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetDropingMsnBtn = new System.Windows.Forms.Button();
            this.panelGyro = new System.Windows.Forms.Panel();
            this.GetMissionValues = new System.ComponentModel.BackgroundWorker();
            this.HeartBeat = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.DropPayoadCb = new System.Windows.Forms.CheckBox();
            this.BlobFilValMax = new System.Windows.Forms.HScrollBar();
            this.BlobFilterValMax = new System.Windows.Forms.Label();
            this.RecloseCB = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PBOpenDuration = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.ConnectToCam = new System.Windows.Forms.Button();
            this.PBOpenDurationVal = new System.Windows.Forms.Label();
            this.CaptureBtn = new System.Windows.Forms.Button();
            this.SelectCam = new System.Windows.Forms.ComboBox();
            this.HueMin1Val = new System.Windows.Forms.Label();
            this.VideoType = new System.Windows.Forms.ComboBox();
            this.HueMin1 = new System.Windows.Forms.HScrollBar();
            this.ThresholdBarVal = new System.Windows.Forms.HScrollBar();
            this.HueMax1Val = new System.Windows.Forms.Label();
            this.ThresholdVal = new System.Windows.Forms.Label();
            this.HueMax1 = new System.Windows.Forms.HScrollBar();
            this.BlurCb = new System.Windows.Forms.CheckBox();
            this.SatMaxVal = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.LigMaxVal = new System.Windows.Forms.Label();
            this.BlobFilVal = new System.Windows.Forms.HScrollBar();
            this.LigMax = new System.Windows.Forms.HScrollBar();
            this.BlobFilterVal = new System.Windows.Forms.Label();
            this.SatMax = new System.Windows.Forms.HScrollBar();
            this.DroppingScopeCB = new System.Windows.Forms.CheckBox();
            this.HueMaxVal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.HueMax = new System.Windows.Forms.HScrollBar();
            this.HueMin = new System.Windows.Forms.HScrollBar();
            this.SatMinVal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LigMinVal = new System.Windows.Forms.Label();
            this.SatMin = new System.Windows.Forms.HScrollBar();
            this.HueMinVal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LigMin = new System.Windows.Forms.HScrollBar();
            this.VideoStream = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTubitak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSerial.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelCoordinate.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoStream)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TopPanel.Controls.Add(this.panel6);
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.panelSerial);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1904, 72);
            this.TopPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.LogoTubitak);
            this.panel6.Controls.Add(this.LogoUM);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 72);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plane_Controller.Properties.Resources.Cakra_Dirga_Logo__6_;
            this.pictureBox2.Location = new System.Drawing.Point(148, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // LogoTubitak
            // 
            this.LogoTubitak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LogoTubitak.Image = global::Plane_Controller.Properties.Resources.Tubitak;
            this.LogoTubitak.Location = new System.Drawing.Point(10, 6);
            this.LogoTubitak.Name = "LogoTubitak";
            this.LogoTubitak.Size = new System.Drawing.Size(60, 60);
            this.LogoTubitak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoTubitak.TabIndex = 3;
            this.LogoTubitak.TabStop = false;
            // 
            // LogoUM
            // 
            this.LogoUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LogoUM.Image = global::Plane_Controller.Properties.Resources.LogoUM;
            this.LogoUM.Location = new System.Drawing.Point(80, 6);
            this.LogoUM.Name = "LogoUM";
            this.LogoUM.Size = new System.Drawing.Size(60, 60);
            this.LogoUM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoUM.TabIndex = 2;
            this.LogoUM.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Failsafe);
            this.panel2.Controls.Add(this.EngineStart);
            this.panel2.Controls.Add(this.FlightModes);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BPercent);
            this.panel2.Controls.Add(this.BAmp);
            this.panel2.Controls.Add(this.BVolt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 72);
            this.panel2.TabIndex = 6;
            // 
            // Failsafe
            // 
            this.Failsafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failsafe.ForeColor = System.Drawing.Color.White;
            this.Failsafe.Location = new System.Drawing.Point(627, 11);
            this.Failsafe.Name = "Failsafe";
            this.Failsafe.Size = new System.Drawing.Size(122, 21);
            this.Failsafe.TabIndex = 62;
            this.Failsafe.Text = "FAILSAFE";
            this.Failsafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EngineStart
            // 
            this.EngineStart.BackgroundImage = global::Plane_Controller.Properties.Resources.Engine_Off;
            this.EngineStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EngineStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngineStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.EngineStart.Location = new System.Drawing.Point(755, 9);
            this.EngineStart.Name = "EngineStart";
            this.EngineStart.Size = new System.Drawing.Size(50, 50);
            this.EngineStart.TabIndex = 60;
            this.EngineStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EngineStart.UseVisualStyleBackColor = true;
            this.EngineStart.Click += new System.EventHandler(this.EngineStart1_Click);
            // 
            // FlightModes
            // 
            this.FlightModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightModes.ForeColor = System.Drawing.Color.White;
            this.FlightModes.Location = new System.Drawing.Point(523, 36);
            this.FlightModes.Name = "FlightModes";
            this.FlightModes.Size = new System.Drawing.Size(226, 21);
            this.FlightModes.TabIndex = 18;
            this.FlightModes.Text = "UNKNOWN";
            this.FlightModes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(811, 24);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(192, 21);
            this.Status.TabIndex = 16;
            this.Status.Text = "ENGINE OFF";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Plane_Controller.Properties.Resources.Battery;
            this.pictureBox1.Location = new System.Drawing.Point(1151, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BPercent
            // 
            this.BPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BPercent.Location = new System.Drawing.Point(1009, 19);
            this.BPercent.Name = "BPercent";
            this.BPercent.Size = new System.Drawing.Size(146, 34);
            this.BPercent.TabIndex = 14;
            this.BPercent.Text = "100.0%";
            this.BPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BAmp
            // 
            this.BAmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BAmp.Location = new System.Drawing.Point(1195, 36);
            this.BAmp.Name = "BAmp";
            this.BAmp.Size = new System.Drawing.Size(113, 21);
            this.BAmp.TabIndex = 12;
            this.BAmp.Text = "00.00A";
            this.BAmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BVolt
            // 
            this.BVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BVolt.Location = new System.Drawing.Point(1195, 14);
            this.BVolt.Name = "BVolt";
            this.BVolt.Size = new System.Drawing.Size(113, 21);
            this.BVolt.TabIndex = 13;
            this.BVolt.Text = "00.00V";
            this.BVolt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSerial
            // 
            this.panelSerial.Controls.Add(this.btnConectSer);
            this.panelSerial.Controls.Add(this.cBoxSerialPort);
            this.panelSerial.Controls.Add(this.cBoxBaudrate);
            this.panelSerial.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSerial.Location = new System.Drawing.Point(1467, 0);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(437, 72);
            this.panelSerial.TabIndex = 3;
            // 
            // btnConectSer
            // 
            this.btnConectSer.BackgroundImage = global::Plane_Controller.Properties.Resources.DisconnectSerial;
            this.btnConectSer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConectSer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConectSer.FlatAppearance.BorderSize = 0;
            this.btnConectSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectSer.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectSer.ForeColor = System.Drawing.Color.White;
            this.btnConectSer.Location = new System.Drawing.Point(311, 0);
            this.btnConectSer.Name = "btnConectSer";
            this.btnConectSer.Size = new System.Drawing.Size(126, 72);
            this.btnConectSer.TabIndex = 7;
            this.btnConectSer.Text = "CONNECT";
            this.btnConectSer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConectSer.UseVisualStyleBackColor = true;
            this.btnConectSer.Click += new System.EventHandler(this.btnConectSer_Click);
            // 
            // cBoxSerialPort
            // 
            this.cBoxSerialPort.FormattingEnabled = true;
            this.cBoxSerialPort.Location = new System.Drawing.Point(15, 24);
            this.cBoxSerialPort.Name = "cBoxSerialPort";
            this.cBoxSerialPort.Size = new System.Drawing.Size(121, 21);
            this.cBoxSerialPort.TabIndex = 6;
            this.cBoxSerialPort.SelectedIndexChanged += new System.EventHandler(this.cBoxSerialPort_SelectedIndexChanged);
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Location = new System.Drawing.Point(157, 24);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudrate.TabIndex = 3;
            this.cBoxBaudrate.SelectedIndexChanged += new System.EventHandler(this.cBoxBaudrate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Logger
            // 
            this.Logger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logger.ForeColor = System.Drawing.Color.White;
            this.Logger.Location = new System.Drawing.Point(0, 0);
            this.Logger.Multiline = true;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.Size = new System.Drawing.Size(340, 189);
            this.Logger.TabIndex = 4;
            // 
            // InputLogger
            // 
            this.InputLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLogger.Location = new System.Drawing.Point(0, 0);
            this.InputLogger.Name = "InputLogger";
            this.InputLogger.Size = new System.Drawing.Size(198, 21);
            this.InputLogger.TabIndex = 7;
            this.InputLogger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputLogger_KeyPress);
            // 
            // ButSendLog
            // 
            this.ButSendLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButSendLog.Location = new System.Drawing.Point(67, 0);
            this.ButSendLog.Name = "ButSendLog";
            this.ButSendLog.Size = new System.Drawing.Size(75, 21);
            this.ButSendLog.TabIndex = 8;
            this.ButSendLog.Text = "Send";
            this.ButSendLog.UseVisualStyleBackColor = true;
            this.ButSendLog.Click += new System.EventHandler(this.ButSendLog_Click);
            // 
            // BtnSaveLog
            // 
            this.BtnSaveLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSaveLog.Location = new System.Drawing.Point(-8, 0);
            this.BtnSaveLog.Name = "BtnSaveLog";
            this.BtnSaveLog.Size = new System.Drawing.Size(75, 21);
            this.BtnSaveLog.TabIndex = 9;
            this.BtnSaveLog.Text = "Save";
            this.BtnSaveLog.UseVisualStyleBackColor = true;
            this.BtnSaveLog.Click += new System.EventHandler(this.BtnSaveLog_Click);
            // 
            // yaw
            // 
            this.yaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaw.ForeColor = System.Drawing.Color.White;
            this.yaw.Location = new System.Drawing.Point(3, 3);
            this.yaw.Name = "yaw";
            this.yaw.Size = new System.Drawing.Size(172, 29);
            this.yaw.TabIndex = 3;
            this.yaw.Text = "Yaw (deg)";
            this.yaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GSpeedVal
            // 
            this.GSpeedVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.GSpeedVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GSpeedVal.Location = new System.Drawing.Point(-2, 92);
            this.GSpeedVal.Name = "GSpeedVal";
            this.GSpeedVal.Size = new System.Drawing.Size(170, 31);
            this.GSpeedVal.TabIndex = 11;
            this.GSpeedVal.Text = "00.00";
            this.GSpeedVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groundspeed
            // 
            this.groundspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundspeed.ForeColor = System.Drawing.Color.White;
            this.groundspeed.Location = new System.Drawing.Point(-2, 63);
            this.groundspeed.Name = "groundspeed";
            this.groundspeed.Size = new System.Drawing.Size(172, 29);
            this.groundspeed.TabIndex = 5;
            this.groundspeed.Text = "Ground Speed (m/s)";
            this.groundspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pitchd
            // 
            this.pitchd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchd.ForeColor = System.Drawing.Color.White;
            this.pitchd.Location = new System.Drawing.Point(3, 63);
            this.pitchd.Name = "pitchd";
            this.pitchd.Size = new System.Drawing.Size(172, 29);
            this.pitchd.TabIndex = 4;
            this.pitchd.Text = "Pitch (deg)";
            this.pitchd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PitchDVal
            // 
            this.PitchDVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.PitchDVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PitchDVal.Location = new System.Drawing.Point(3, 92);
            this.PitchDVal.Name = "PitchDVal";
            this.PitchDVal.Size = new System.Drawing.Size(170, 31);
            this.PitchDVal.TabIndex = 10;
            this.PitchDVal.Text = "00.00";
            this.PitchDVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YawVal
            // 
            this.YawVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.YawVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.YawVal.Location = new System.Drawing.Point(3, 32);
            this.YawVal.Name = "YawVal";
            this.YawVal.Size = new System.Drawing.Size(170, 31);
            this.YawVal.TabIndex = 9;
            this.YawVal.Text = "00.00";
            this.YawVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airspeed
            // 
            this.airspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airspeed.ForeColor = System.Drawing.Color.White;
            this.airspeed.Location = new System.Drawing.Point(-3, 123);
            this.airspeed.Name = "airspeed";
            this.airspeed.Size = new System.Drawing.Size(172, 29);
            this.airspeed.TabIndex = 2;
            this.airspeed.Text = "Air Speed (m/s)";
            this.airspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altitude
            // 
            this.altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitude.ForeColor = System.Drawing.Color.White;
            this.altitude.Location = new System.Drawing.Point(-2, 0);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(172, 29);
            this.altitude.TabIndex = 0;
            this.altitude.Text = "Altitude (m)";
            this.altitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ASpeedVal
            // 
            this.ASpeedVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.ASpeedVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ASpeedVal.Location = new System.Drawing.Point(-2, 152);
            this.ASpeedVal.Name = "ASpeedVal";
            this.ASpeedVal.Size = new System.Drawing.Size(170, 31);
            this.ASpeedVal.TabIndex = 8;
            this.ASpeedVal.Text = "00.00";
            this.ASpeedVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AltitudeVal
            // 
            this.AltitudeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AltitudeVal.Location = new System.Drawing.Point(-1, 29);
            this.AltitudeVal.Name = "AltitudeVal";
            this.AltitudeVal.Size = new System.Drawing.Size(170, 31);
            this.AltitudeVal.TabIndex = 6;
            this.AltitudeVal.Text = "00.00";
            this.AltitudeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rolld
            // 
            this.rolld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolld.ForeColor = System.Drawing.Color.White;
            this.rolld.Location = new System.Drawing.Point(1, 123);
            this.rolld.Name = "rolld";
            this.rolld.Size = new System.Drawing.Size(172, 29);
            this.rolld.TabIndex = 1;
            this.rolld.Text = "Roll (deg)";
            this.rolld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollDVal
            // 
            this.RollDVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.RollDVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RollDVal.Location = new System.Drawing.Point(3, 152);
            this.RollDVal.Name = "RollDVal";
            this.RollDVal.Size = new System.Drawing.Size(170, 31);
            this.RollDVal.TabIndex = 7;
            this.RollDVal.Text = "00.00";
            this.RollDVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.ForeColor = System.Drawing.Color.White;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 72);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1904, 969);
            this.gMap.TabIndex = 3;
            this.gMap.Zoom = 0D;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panelCoordinate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1564, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 969);
            this.panel3.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel19);
            this.panel10.Controls.Add(this.panel20);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 391);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(340, 368);
            this.panel10.TabIndex = 3;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label7);
            this.panel19.Controls.Add(this.ServoStatus2);
            this.panel19.Controls.Add(this.ServoStatus1);
            this.panel19.Controls.Add(this.label6);
            this.panel19.Controls.Add(this.ForceServo2);
            this.panel19.Controls.Add(this.ForceServo1);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 157);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(340, 211);
            this.panel19.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Payload Gate  2 :";
            // 
            // ServoStatus2
            // 
            this.ServoStatus2.AutoSize = true;
            this.ServoStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoStatus2.ForeColor = System.Drawing.Color.White;
            this.ServoStatus2.Location = new System.Drawing.Point(243, 32);
            this.ServoStatus2.Name = "ServoStatus2";
            this.ServoStatus2.Size = new System.Drawing.Size(61, 18);
            this.ServoStatus2.TabIndex = 63;
            this.ServoStatus2.Text = "Closed";
            // 
            // ServoStatus1
            // 
            this.ServoStatus1.AutoSize = true;
            this.ServoStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoStatus1.ForeColor = System.Drawing.Color.White;
            this.ServoStatus1.Location = new System.Drawing.Point(243, 7);
            this.ServoStatus1.Name = "ServoStatus1";
            this.ServoStatus1.Size = new System.Drawing.Size(61, 18);
            this.ServoStatus1.TabIndex = 62;
            this.ServoStatus1.Text = "Closed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Payload Gate  1 :";
            // 
            // ForceServo2
            // 
            this.ForceServo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceServo2.ForeColor = System.Drawing.Color.Black;
            this.ForceServo2.Location = new System.Drawing.Point(45, 29);
            this.ForceServo2.Name = "ForceServo2";
            this.ForceServo2.Size = new System.Drawing.Size(57, 23);
            this.ForceServo2.TabIndex = 60;
            this.ForceServo2.Text = "Switch";
            this.ForceServo2.UseVisualStyleBackColor = true;
            this.ForceServo2.Click += new System.EventHandler(this.ForceServo2_Click);
            // 
            // ForceServo1
            // 
            this.ForceServo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceServo1.ForeColor = System.Drawing.Color.Black;
            this.ForceServo1.Location = new System.Drawing.Point(45, 3);
            this.ForceServo1.Name = "ForceServo1";
            this.ForceServo1.Size = new System.Drawing.Size(57, 23);
            this.ForceServo1.TabIndex = 59;
            this.ForceServo1.Text = "Switch";
            this.ForceServo1.UseVisualStyleBackColor = true;
            this.ForceServo1.Click += new System.EventHandler(this.ForceServo1_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.CalAccelLabel);
            this.panel20.Controls.Add(this.CalLevelLabel);
            this.panel20.Controls.Add(this.label8);
            this.panel20.Controls.Add(this.CalibrateLevelBtn);
            this.panel20.Controls.Add(this.CalibrateAccelBtn);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 50);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(340, 107);
            this.panel20.TabIndex = 63;
            // 
            // CalAccelLabel
            // 
            this.CalAccelLabel.ForeColor = System.Drawing.Color.White;
            this.CalAccelLabel.Location = new System.Drawing.Point(167, 31);
            this.CalAccelLabel.Name = "CalAccelLabel";
            this.CalAccelLabel.Size = new System.Drawing.Size(163, 30);
            this.CalAccelLabel.TabIndex = 64;
            this.CalAccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalLevelLabel
            // 
            this.CalLevelLabel.ForeColor = System.Drawing.Color.White;
            this.CalLevelLabel.Location = new System.Drawing.Point(7, 31);
            this.CalLevelLabel.Name = "CalLevelLabel";
            this.CalLevelLabel.Size = new System.Drawing.Size(163, 30);
            this.CalLevelLabel.TabIndex = 63;
            this.CalLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(111, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "Calibration";
            // 
            // CalibrateLevelBtn
            // 
            this.CalibrateLevelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrateLevelBtn.ForeColor = System.Drawing.Color.Black;
            this.CalibrateLevelBtn.Location = new System.Drawing.Point(32, 64);
            this.CalibrateLevelBtn.Name = "CalibrateLevelBtn";
            this.CalibrateLevelBtn.Size = new System.Drawing.Size(120, 23);
            this.CalibrateLevelBtn.TabIndex = 60;
            this.CalibrateLevelBtn.Text = "Calibrate Level";
            this.CalibrateLevelBtn.UseVisualStyleBackColor = true;
            this.CalibrateLevelBtn.Click += new System.EventHandler(this.CalibrateLevelBtn_Click);
            // 
            // CalibrateAccelBtn
            // 
            this.CalibrateAccelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibrateAccelBtn.ForeColor = System.Drawing.Color.Black;
            this.CalibrateAccelBtn.Location = new System.Drawing.Point(191, 65);
            this.CalibrateAccelBtn.Name = "CalibrateAccelBtn";
            this.CalibrateAccelBtn.Size = new System.Drawing.Size(120, 23);
            this.CalibrateAccelBtn.TabIndex = 61;
            this.CalibrateAccelBtn.Text = "Calibrate Accel";
            this.CalibrateAccelBtn.UseVisualStyleBackColor = true;
            this.CalibrateAccelBtn.Click += new System.EventHandler(this.CalibrateAccelBtn_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(340, 50);
            this.panel13.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.FindPlane);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(220, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(120, 50);
            this.panel16.TabIndex = 2;
            // 
            // FindPlane
            // 
            this.FindPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPlane.Location = new System.Drawing.Point(11, 7);
            this.FindPlane.Name = "FindPlane";
            this.FindPlane.Size = new System.Drawing.Size(100, 35);
            this.FindPlane.TabIndex = 6;
            this.FindPlane.Text = "Find";
            this.FindPlane.UseVisualStyleBackColor = true;
            this.FindPlane.Click += new System.EventHandler(this.FindPlane_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.LongPlane);
            this.panel15.Controls.Add(this.LongPlaneVal);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(110, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(110, 50);
            this.panel15.TabIndex = 1;
            // 
            // LongPlane
            // 
            this.LongPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongPlane.ForeColor = System.Drawing.Color.White;
            this.LongPlane.Location = new System.Drawing.Point(0, 3);
            this.LongPlane.Name = "LongPlane";
            this.LongPlane.Size = new System.Drawing.Size(110, 20);
            this.LongPlane.TabIndex = 13;
            this.LongPlane.Text = "Longitude";
            this.LongPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LongPlaneVal
            // 
            this.LongPlaneVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LongPlaneVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LongPlaneVal.Location = new System.Drawing.Point(0, 21);
            this.LongPlaneVal.Name = "LongPlaneVal";
            this.LongPlaneVal.Size = new System.Drawing.Size(110, 28);
            this.LongPlaneVal.TabIndex = 15;
            this.LongPlaneVal.Text = "00.00";
            this.LongPlaneVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.LatPlaneVal);
            this.panel14.Controls.Add(this.LatPlane);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(110, 50);
            this.panel14.TabIndex = 0;
            // 
            // LatPlaneVal
            // 
            this.LatPlaneVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LatPlaneVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LatPlaneVal.Location = new System.Drawing.Point(1, 23);
            this.LatPlaneVal.Name = "LatPlaneVal";
            this.LatPlaneVal.Size = new System.Drawing.Size(110, 26);
            this.LatPlaneVal.TabIndex = 14;
            this.LatPlaneVal.Text = "00.00";
            this.LatPlaneVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LatPlane
            // 
            this.LatPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatPlane.ForeColor = System.Drawing.Color.White;
            this.LatPlane.Location = new System.Drawing.Point(-3, 3);
            this.LatPlane.Name = "LatPlane";
            this.LatPlane.Size = new System.Drawing.Size(110, 20);
            this.LatPlane.TabIndex = 12;
            this.LatPlane.Text = "Latitude";
            this.LatPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 164);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(340, 227);
            this.panel9.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.panel5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 37);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(340, 190);
            this.panel12.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yaw);
            this.panel1.Controls.Add(this.YawVal);
            this.panel1.Controls.Add(this.PitchDVal);
            this.panel1.Controls.Add(this.pitchd);
            this.panel1.Controls.Add(this.rolld);
            this.panel1.Controls.Add(this.RollDVal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 190);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GSpeedVal);
            this.panel5.Controls.Add(this.ASpeedVal);
            this.panel5.Controls.Add(this.altitude);
            this.panel5.Controls.Add(this.airspeed);
            this.panel5.Controls.Add(this.groundspeed);
            this.panel5.Controls.Add(this.AltitudeVal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 190);
            this.panel5.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(340, 37);
            this.panel11.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plane Status";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Logger);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 759);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 210);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.InputLogger);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 189);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(340, 21);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.BtnSaveLog);
            this.panel8.Controls.Add(this.ButSendLog);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(198, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(142, 21);
            this.panel8.TabIndex = 0;
            // 
            // panelCoordinate
            // 
            this.panelCoordinate.Controls.Add(this.panel22);
            this.panelCoordinate.Controls.Add(this.panel21);
            this.panelCoordinate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCoordinate.Location = new System.Drawing.Point(0, 0);
            this.panelCoordinate.Name = "panelCoordinate";
            this.panelCoordinate.Size = new System.Drawing.Size(340, 164);
            this.panelCoordinate.TabIndex = 0;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.cBoxDraw);
            this.panel22.Controls.Add(this.cBoxDrawReset);
            this.panel22.Controls.Add(this.cBoxDrawRemove);
            this.panel22.Controls.Add(this.cBoxDrawAdd);
            this.panel22.Controls.Add(this.cBoxDrawSave);
            this.panel22.Controls.Add(this.DropAreaLoad);
            this.panel22.Controls.Add(this.label13);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Controls.Add(this.cBoxDrawLongitude);
            this.panel22.Controls.Add(this.cBoxDrawLatitude);
            this.panel22.Controls.Add(this.label12);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 82);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(340, 82);
            this.panel22.TabIndex = 7;
            // 
            // cBoxDraw
            // 
            this.cBoxDraw.FormattingEnabled = true;
            this.cBoxDraw.Location = new System.Drawing.Point(170, 27);
            this.cBoxDraw.Name = "cBoxDraw";
            this.cBoxDraw.Size = new System.Drawing.Size(63, 21);
            this.cBoxDraw.TabIndex = 8;
            this.cBoxDraw.SelectedIndexChanged += new System.EventHandler(this.cBoxDraw_SelectedIndexChanged);
            // 
            // cBoxDrawReset
            // 
            this.cBoxDrawReset.Location = new System.Drawing.Point(286, 50);
            this.cBoxDrawReset.Name = "cBoxDrawReset";
            this.cBoxDrawReset.Size = new System.Drawing.Size(50, 20);
            this.cBoxDrawReset.TabIndex = 13;
            this.cBoxDrawReset.Text = "Reset";
            this.cBoxDrawReset.UseVisualStyleBackColor = true;
            this.cBoxDrawReset.Click += new System.EventHandler(this.DrawPathReset_Click);
            // 
            // cBoxDrawRemove
            // 
            this.cBoxDrawRemove.Location = new System.Drawing.Point(229, 50);
            this.cBoxDrawRemove.Name = "cBoxDrawRemove";
            this.cBoxDrawRemove.Size = new System.Drawing.Size(56, 20);
            this.cBoxDrawRemove.TabIndex = 12;
            this.cBoxDrawRemove.Text = "Remove";
            this.cBoxDrawRemove.UseVisualStyleBackColor = true;
            this.cBoxDrawRemove.Click += new System.EventHandler(this.DrawPathRemove_Click);
            // 
            // cBoxDrawAdd
            // 
            this.cBoxDrawAdd.Location = new System.Drawing.Point(176, 50);
            this.cBoxDrawAdd.Name = "cBoxDrawAdd";
            this.cBoxDrawAdd.Size = new System.Drawing.Size(50, 20);
            this.cBoxDrawAdd.TabIndex = 11;
            this.cBoxDrawAdd.Text = "Add";
            this.cBoxDrawAdd.UseVisualStyleBackColor = true;
            this.cBoxDrawAdd.Click += new System.EventHandler(this.DrawPathAdd_Click);
            // 
            // cBoxDrawSave
            // 
            this.cBoxDrawSave.Location = new System.Drawing.Point(286, 28);
            this.cBoxDrawSave.Name = "cBoxDrawSave";
            this.cBoxDrawSave.Size = new System.Drawing.Size(50, 20);
            this.cBoxDrawSave.TabIndex = 10;
            this.cBoxDrawSave.Text = "Save";
            this.cBoxDrawSave.UseVisualStyleBackColor = true;
            this.cBoxDrawSave.Click += new System.EventHandler(this.DrawPathSave_Click);
            // 
            // DropAreaLoad
            // 
            this.DropAreaLoad.Location = new System.Drawing.Point(235, 28);
            this.DropAreaLoad.Name = "DropAreaLoad";
            this.DropAreaLoad.Size = new System.Drawing.Size(50, 20);
            this.DropAreaLoad.TabIndex = 6;
            this.DropAreaLoad.Text = "Load";
            this.DropAreaLoad.UseVisualStyleBackColor = true;
            this.DropAreaLoad.Click += new System.EventHandler(this.DrawPathLoad_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(340, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = "Draw";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(91, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Longitude";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxDrawLongitude
            // 
            this.cBoxDrawLongitude.Location = new System.Drawing.Point(91, 51);
            this.cBoxDrawLongitude.Name = "cBoxDrawLongitude";
            this.cBoxDrawLongitude.Size = new System.Drawing.Size(80, 20);
            this.cBoxDrawLongitude.TabIndex = 9;
            this.cBoxDrawLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cBoxDrawLatitude
            // 
            this.cBoxDrawLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cBoxDrawLatitude.Location = new System.Drawing.Point(7, 51);
            this.cBoxDrawLatitude.Name = "cBoxDrawLatitude";
            this.cBoxDrawLatitude.Size = new System.Drawing.Size(80, 20);
            this.cBoxDrawLatitude.TabIndex = 8;
            this.cBoxDrawLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Latitude";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.MapsPosSave);
            this.panel21.Controls.Add(this.MapsPosLoad);
            this.panel21.Controls.Add(this.label4);
            this.panel21.Controls.Add(this.label3);
            this.panel21.Controls.Add(this.cBoxMapType);
            this.panel21.Controls.Add(this.tbLatitude);
            this.panel21.Controls.Add(this.btnLoad);
            this.panel21.Controls.Add(this.tbLongitude);
            this.panel21.Controls.Add(this.label2);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(340, 82);
            this.panel21.TabIndex = 6;
            // 
            // MapsPosSave
            // 
            this.MapsPosSave.Location = new System.Drawing.Point(276, 27);
            this.MapsPosSave.Name = "MapsPosSave";
            this.MapsPosSave.Size = new System.Drawing.Size(50, 20);
            this.MapsPosSave.TabIndex = 15;
            this.MapsPosSave.Text = "Save";
            this.MapsPosSave.UseVisualStyleBackColor = true;
            this.MapsPosSave.Click += new System.EventHandler(this.MapsPosSave_Click);
            // 
            // MapsPosLoad
            // 
            this.MapsPosLoad.Location = new System.Drawing.Point(276, 49);
            this.MapsPosLoad.Name = "MapsPosLoad";
            this.MapsPosLoad.Size = new System.Drawing.Size(50, 20);
            this.MapsPosLoad.TabIndex = 14;
            this.MapsPosLoad.Text = "Load";
            this.MapsPosLoad.UseVisualStyleBackColor = true;
            this.MapsPosLoad.Click += new System.EventHandler(this.MapsPosLoad_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maps";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Longitude";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxMapType
            // 
            this.cBoxMapType.FormattingEnabled = true;
            this.cBoxMapType.Location = new System.Drawing.Point(179, 26);
            this.cBoxMapType.Name = "cBoxMapType";
            this.cBoxMapType.Size = new System.Drawing.Size(91, 21);
            this.cBoxMapType.TabIndex = 1;
            this.cBoxMapType.SelectedIndexChanged += new System.EventHandler(this.cBoxMapType_SelectedIndexChanged);
            // 
            // tbLatitude
            // 
            this.tbLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbLatitude.Location = new System.Drawing.Point(7, 50);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(80, 20);
            this.tbLatitude.TabIndex = 2;
            this.tbLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(179, 49);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 20);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Go";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(91, 50);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(80, 20);
            this.tbLongitude.TabIndex = 3;
            this.tbLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Latitude";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetDropingMsnBtn
            // 
            this.ResetDropingMsnBtn.BackColor = System.Drawing.Color.Red;
            this.ResetDropingMsnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDropingMsnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetDropingMsnBtn.ForeColor = System.Drawing.Color.White;
            this.ResetDropingMsnBtn.Location = new System.Drawing.Point(68, 99);
            this.ResetDropingMsnBtn.Name = "ResetDropingMsnBtn";
            this.ResetDropingMsnBtn.Size = new System.Drawing.Size(159, 29);
            this.ResetDropingMsnBtn.TabIndex = 65;
            this.ResetDropingMsnBtn.Text = "Reset Dropping Mission";
            this.ResetDropingMsnBtn.UseVisualStyleBackColor = false;
            this.ResetDropingMsnBtn.Click += new System.EventHandler(this.ResetDroppingMsnBtn_Click);
            // 
            // panelGyro
            // 
            this.panelGyro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGyro.Location = new System.Drawing.Point(0, 669);
            this.panelGyro.Name = "panelGyro";
            this.panelGyro.Size = new System.Drawing.Size(300, 300);
            this.panelGyro.TabIndex = 6;
            // 
            // GetMissionValues
            // 
            this.GetMissionValues.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RecvMission);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Data);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.VideoStream);
            this.panel17.Controls.Add(this.panelGyro);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 72);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(300, 969);
            this.panel17.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.ResetDropingMsnBtn);
            this.panel18.Controls.Add(this.DropPayoadCb);
            this.panel18.Controls.Add(this.BlobFilValMax);
            this.panel18.Controls.Add(this.BlobFilterValMax);
            this.panel18.Controls.Add(this.RecloseCB);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.label20);
            this.panel18.Controls.Add(this.button1);
            this.panel18.Controls.Add(this.PBOpenDuration);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Controls.Add(this.ConnectToCam);
            this.panel18.Controls.Add(this.PBOpenDurationVal);
            this.panel18.Controls.Add(this.CaptureBtn);
            this.panel18.Controls.Add(this.SelectCam);
            this.panel18.Controls.Add(this.HueMin1Val);
            this.panel18.Controls.Add(this.VideoType);
            this.panel18.Controls.Add(this.HueMin1);
            this.panel18.Controls.Add(this.ThresholdBarVal);
            this.panel18.Controls.Add(this.HueMax1Val);
            this.panel18.Controls.Add(this.ThresholdVal);
            this.panel18.Controls.Add(this.HueMax1);
            this.panel18.Controls.Add(this.BlurCb);
            this.panel18.Controls.Add(this.SatMaxVal);
            this.panel18.Controls.Add(this.label);
            this.panel18.Controls.Add(this.LigMaxVal);
            this.panel18.Controls.Add(this.BlobFilVal);
            this.panel18.Controls.Add(this.LigMax);
            this.panel18.Controls.Add(this.BlobFilterVal);
            this.panel18.Controls.Add(this.SatMax);
            this.panel18.Controls.Add(this.DroppingScopeCB);
            this.panel18.Controls.Add(this.HueMaxVal);
            this.panel18.Controls.Add(this.label18);
            this.panel18.Controls.Add(this.HueMax);
            this.panel18.Controls.Add(this.HueMin);
            this.panel18.Controls.Add(this.SatMinVal);
            this.panel18.Controls.Add(this.label17);
            this.panel18.Controls.Add(this.LigMinVal);
            this.panel18.Controls.Add(this.SatMin);
            this.panel18.Controls.Add(this.HueMinVal);
            this.panel18.Controls.Add(this.label16);
            this.panel18.Controls.Add(this.LigMin);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 225);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(300, 444);
            this.panel18.TabIndex = 9;
            // 
            // DropPayoadCb
            // 
            this.DropPayoadCb.AutoSize = true;
            this.DropPayoadCb.Checked = true;
            this.DropPayoadCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DropPayoadCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropPayoadCb.ForeColor = System.Drawing.Color.White;
            this.DropPayoadCb.Location = new System.Drawing.Point(14, 125);
            this.DropPayoadCb.Name = "DropPayoadCb";
            this.DropPayoadCb.Size = new System.Drawing.Size(84, 20);
            this.DropPayoadCb.TabIndex = 67;
            this.DropPayoadCb.Text = "Dropper";
            this.DropPayoadCb.UseVisualStyleBackColor = true;
            // 
            // BlobFilValMax
            // 
            this.BlobFilValMax.LargeChange = 1;
            this.BlobFilValMax.Location = new System.Drawing.Point(157, 211);
            this.BlobFilValMax.Name = "BlobFilValMax";
            this.BlobFilValMax.Size = new System.Drawing.Size(100, 17);
            this.BlobFilValMax.TabIndex = 61;
            this.BlobFilValMax.Value = 50;
            this.BlobFilValMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlobFilValMax_Scroll);
            // 
            // BlobFilterValMax
            // 
            this.BlobFilterValMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlobFilterValMax.ForeColor = System.Drawing.Color.White;
            this.BlobFilterValMax.Location = new System.Drawing.Point(260, 209);
            this.BlobFilterValMax.Name = "BlobFilterValMax";
            this.BlobFilterValMax.Size = new System.Drawing.Size(35, 18);
            this.BlobFilterValMax.TabIndex = 62;
            this.BlobFilterValMax.Text = "100";
            this.BlobFilterValMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RecloseCB
            // 
            this.RecloseCB.AutoSize = true;
            this.RecloseCB.Checked = true;
            this.RecloseCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecloseCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecloseCB.ForeColor = System.Drawing.Color.White;
            this.RecloseCB.Location = new System.Drawing.Point(12, 148);
            this.RecloseCB.Name = "RecloseCB";
            this.RecloseCB.Size = new System.Drawing.Size(85, 20);
            this.RecloseCB.TabIndex = 66;
            this.RecloseCB.Text = "Reclose";
            this.RecloseCB.UseVisualStyleBackColor = true;
            this.RecloseCB.CheckedChanged += new System.EventHandler(this.RecloseCB_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Threshold";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(97, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(200, 16);
            this.label20.TabIndex = 65;
            this.label20.Text = "Payload Bay Open Duration";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(44, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PBOpenDuration
            // 
            this.PBOpenDuration.LargeChange = 1;
            this.PBOpenDuration.Location = new System.Drawing.Point(103, 151);
            this.PBOpenDuration.Maximum = 120;
            this.PBOpenDuration.Name = "PBOpenDuration";
            this.PBOpenDuration.Size = new System.Drawing.Size(154, 17);
            this.PBOpenDuration.TabIndex = 63;
            this.PBOpenDuration.Value = 10;
            this.PBOpenDuration.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PBOpenDuration_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(111, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Camera";
            // 
            // ConnectToCam
            // 
            this.ConnectToCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectToCam.ForeColor = System.Drawing.Color.Black;
            this.ConnectToCam.Location = new System.Drawing.Point(209, 24);
            this.ConnectToCam.Name = "ConnectToCam";
            this.ConnectToCam.Size = new System.Drawing.Size(87, 51);
            this.ConnectToCam.TabIndex = 8;
            this.ConnectToCam.Text = "Connect";
            this.ConnectToCam.UseVisualStyleBackColor = true;
            this.ConnectToCam.Click += new System.EventHandler(this.ConnectToCam_Click);
            // 
            // PBOpenDurationVal
            // 
            this.PBOpenDurationVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBOpenDurationVal.ForeColor = System.Drawing.Color.White;
            this.PBOpenDurationVal.Location = new System.Drawing.Point(264, 150);
            this.PBOpenDurationVal.Name = "PBOpenDurationVal";
            this.PBOpenDurationVal.Size = new System.Drawing.Size(35, 18);
            this.PBOpenDurationVal.TabIndex = 64;
            this.PBOpenDurationVal.Text = "10";
            this.PBOpenDurationVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureBtn.ForeColor = System.Drawing.Color.Black;
            this.CaptureBtn.Location = new System.Drawing.Point(170, 382);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(87, 23);
            this.CaptureBtn.TabIndex = 58;
            this.CaptureBtn.Text = "Capture";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            this.CaptureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // SelectCam
            // 
            this.SelectCam.FormattingEnabled = true;
            this.SelectCam.Location = new System.Drawing.Point(11, 25);
            this.SelectCam.Name = "SelectCam";
            this.SelectCam.Size = new System.Drawing.Size(192, 21);
            this.SelectCam.TabIndex = 9;
            this.SelectCam.SelectedIndexChanged += new System.EventHandler(this.SelectCam_SelectedIndexChanged);
            // 
            // HueMin1Val
            // 
            this.HueMin1Val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HueMin1Val.ForeColor = System.Drawing.Color.White;
            this.HueMin1Val.Location = new System.Drawing.Point(113, 271);
            this.HueMin1Val.Name = "HueMin1Val";
            this.HueMin1Val.Size = new System.Drawing.Size(35, 18);
            this.HueMin1Val.TabIndex = 57;
            this.HueMin1Val.Text = "359";
            this.HueMin1Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VideoType
            // 
            this.VideoType.FormattingEnabled = true;
            this.VideoType.Location = new System.Drawing.Point(12, 53);
            this.VideoType.Name = "VideoType";
            this.VideoType.Size = new System.Drawing.Size(191, 21);
            this.VideoType.TabIndex = 10;
            this.VideoType.SelectedIndexChanged += new System.EventHandler(this.VideoType_SelectedIndexChanged);
            // 
            // HueMin1
            // 
            this.HueMin1.LargeChange = 1;
            this.HueMin1.Location = new System.Drawing.Point(10, 271);
            this.HueMin1.Maximum = 359;
            this.HueMin1.Name = "HueMin1";
            this.HueMin1.Size = new System.Drawing.Size(100, 17);
            this.HueMin1.TabIndex = 56;
            this.HueMin1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HueMin1_Scroll);
            // 
            // ThresholdBarVal
            // 
            this.ThresholdBarVal.LargeChange = 1;
            this.ThresholdBarVal.Location = new System.Drawing.Point(104, 174);
            this.ThresholdBarVal.Maximum = 255;
            this.ThresholdBarVal.Name = "ThresholdBarVal";
            this.ThresholdBarVal.Size = new System.Drawing.Size(153, 17);
            this.ThresholdBarVal.TabIndex = 11;
            this.ThresholdBarVal.Value = 20;
            this.ThresholdBarVal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ThresholdBarVal_Scroll);
            // 
            // HueMax1Val
            // 
            this.HueMax1Val.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HueMax1Val.ForeColor = System.Drawing.Color.White;
            this.HueMax1Val.Location = new System.Drawing.Point(260, 271);
            this.HueMax1Val.Name = "HueMax1Val";
            this.HueMax1Val.Size = new System.Drawing.Size(35, 18);
            this.HueMax1Val.TabIndex = 55;
            this.HueMax1Val.Text = "359";
            this.HueMax1Val.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThresholdVal
            // 
            this.ThresholdVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdVal.ForeColor = System.Drawing.Color.White;
            this.ThresholdVal.Location = new System.Drawing.Point(260, 176);
            this.ThresholdVal.Name = "ThresholdVal";
            this.ThresholdVal.Size = new System.Drawing.Size(35, 18);
            this.ThresholdVal.TabIndex = 21;
            this.ThresholdVal.Text = "255";
            this.ThresholdVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HueMax1
            // 
            this.HueMax1.LargeChange = 1;
            this.HueMax1.Location = new System.Drawing.Point(157, 271);
            this.HueMax1.Maximum = 359;
            this.HueMax1.Name = "HueMax1";
            this.HueMax1.Size = new System.Drawing.Size(100, 17);
            this.HueMax1.TabIndex = 54;
            this.HueMax1.Value = 10;
            this.HueMax1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HueMax1_Scroll);
            // 
            // BlurCb
            // 
            this.BlurCb.AutoSize = true;
            this.BlurCb.Checked = true;
            this.BlurCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlurCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurCb.ForeColor = System.Drawing.Color.White;
            this.BlurCb.Location = new System.Drawing.Point(159, 77);
            this.BlurCb.Name = "BlurCb";
            this.BlurCb.Size = new System.Drawing.Size(54, 20);
            this.BlurCb.TabIndex = 27;
            this.BlurCb.Text = "Blur";
            this.BlurCb.UseVisualStyleBackColor = true;
            this.BlurCb.CheckedChanged += new System.EventHandler(this.BlurCb_CheckedChanged);
            // 
            // SatMaxVal
            // 
            this.SatMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatMaxVal.ForeColor = System.Drawing.Color.White;
            this.SatMaxVal.Location = new System.Drawing.Point(262, 310);
            this.SatMaxVal.Name = "SatMaxVal";
            this.SatMaxVal.Size = new System.Drawing.Size(35, 18);
            this.SatMaxVal.TabIndex = 53;
            this.SatMaxVal.Text = "100";
            this.SatMaxVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(119, 193);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 16);
            this.label.TabIndex = 35;
            this.label.Text = "Blob";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LigMaxVal
            // 
            this.LigMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LigMaxVal.ForeColor = System.Drawing.Color.White;
            this.LigMaxVal.Location = new System.Drawing.Point(262, 350);
            this.LigMaxVal.Name = "LigMaxVal";
            this.LigMaxVal.Size = new System.Drawing.Size(35, 18);
            this.LigMaxVal.TabIndex = 52;
            this.LigMaxVal.Text = "100";
            this.LigMaxVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BlobFilVal
            // 
            this.BlobFilVal.LargeChange = 1;
            this.BlobFilVal.Location = new System.Drawing.Point(11, 213);
            this.BlobFilVal.Name = "BlobFilVal";
            this.BlobFilVal.Size = new System.Drawing.Size(100, 17);
            this.BlobFilVal.TabIndex = 36;
            this.BlobFilVal.Value = 20;
            this.BlobFilVal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlobFilVal_Scroll);
            // 
            // LigMax
            // 
            this.LigMax.LargeChange = 1;
            this.LigMax.Location = new System.Drawing.Point(159, 350);
            this.LigMax.Name = "LigMax";
            this.LigMax.Size = new System.Drawing.Size(100, 17);
            this.LigMax.TabIndex = 51;
            this.LigMax.Value = 100;
            this.LigMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LigMax_Scroll);
            // 
            // BlobFilterVal
            // 
            this.BlobFilterVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlobFilterVal.ForeColor = System.Drawing.Color.White;
            this.BlobFilterVal.Location = new System.Drawing.Point(114, 211);
            this.BlobFilterVal.Name = "BlobFilterVal";
            this.BlobFilterVal.Size = new System.Drawing.Size(35, 18);
            this.BlobFilterVal.TabIndex = 37;
            this.BlobFilterVal.Text = "0";
            this.BlobFilterVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SatMax
            // 
            this.SatMax.LargeChange = 1;
            this.SatMax.Location = new System.Drawing.Point(159, 310);
            this.SatMax.Name = "SatMax";
            this.SatMax.Size = new System.Drawing.Size(100, 17);
            this.SatMax.TabIndex = 50;
            this.SatMax.Value = 100;
            this.SatMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SatMax_Scroll);
            // 
            // DroppingScopeCB
            // 
            this.DroppingScopeCB.AutoSize = true;
            this.DroppingScopeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DroppingScopeCB.ForeColor = System.Drawing.Color.White;
            this.DroppingScopeCB.Location = new System.Drawing.Point(12, 77);
            this.DroppingScopeCB.Name = "DroppingScopeCB";
            this.DroppingScopeCB.Size = new System.Drawing.Size(140, 20);
            this.DroppingScopeCB.TabIndex = 38;
            this.DroppingScopeCB.Text = "Dropping Scope";
            this.DroppingScopeCB.UseVisualStyleBackColor = true;
            this.DroppingScopeCB.CheckedChanged += new System.EventHandler(this.DroppingScopeCB_CheckedChanged);
            // 
            // HueMaxVal
            // 
            this.HueMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HueMaxVal.ForeColor = System.Drawing.Color.White;
            this.HueMaxVal.Location = new System.Drawing.Point(262, 246);
            this.HueMaxVal.Name = "HueMaxVal";
            this.HueMaxVal.Size = new System.Drawing.Size(35, 18);
            this.HueMaxVal.TabIndex = 49;
            this.HueMaxVal.Text = "359";
            this.HueMaxVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(123, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 39;
            this.label18.Text = "Hue";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HueMax
            // 
            this.HueMax.LargeChange = 1;
            this.HueMax.Location = new System.Drawing.Point(159, 246);
            this.HueMax.Maximum = 359;
            this.HueMax.Name = "HueMax";
            this.HueMax.Size = new System.Drawing.Size(100, 17);
            this.HueMax.TabIndex = 48;
            this.HueMax.Value = 359;
            this.HueMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HueMax_Scroll);
            // 
            // HueMin
            // 
            this.HueMin.LargeChange = 1;
            this.HueMin.Location = new System.Drawing.Point(10, 246);
            this.HueMin.Maximum = 359;
            this.HueMin.Name = "HueMin";
            this.HueMin.Size = new System.Drawing.Size(100, 17);
            this.HueMin.TabIndex = 40;
            this.HueMin.Value = 270;
            this.HueMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HueMin_Scroll);
            // 
            // SatMinVal
            // 
            this.SatMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SatMinVal.ForeColor = System.Drawing.Color.White;
            this.SatMinVal.Location = new System.Drawing.Point(114, 310);
            this.SatMinVal.Name = "SatMinVal";
            this.SatMinVal.Size = new System.Drawing.Size(35, 18);
            this.SatMinVal.TabIndex = 47;
            this.SatMinVal.Text = "100";
            this.SatMinVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(100, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Saturation";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LigMinVal
            // 
            this.LigMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LigMinVal.ForeColor = System.Drawing.Color.White;
            this.LigMinVal.Location = new System.Drawing.Point(114, 350);
            this.LigMinVal.Name = "LigMinVal";
            this.LigMinVal.Size = new System.Drawing.Size(35, 18);
            this.LigMinVal.TabIndex = 46;
            this.LigMinVal.Text = "100";
            this.LigMinVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SatMin
            // 
            this.SatMin.LargeChange = 1;
            this.SatMin.Location = new System.Drawing.Point(11, 310);
            this.SatMin.Name = "SatMin";
            this.SatMin.Size = new System.Drawing.Size(100, 17);
            this.SatMin.TabIndex = 42;
            this.SatMin.Value = 47;
            this.SatMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SatMin_Scroll);
            // 
            // HueMinVal
            // 
            this.HueMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HueMinVal.ForeColor = System.Drawing.Color.White;
            this.HueMinVal.Location = new System.Drawing.Point(113, 246);
            this.HueMinVal.Name = "HueMinVal";
            this.HueMinVal.Size = new System.Drawing.Size(35, 18);
            this.HueMinVal.TabIndex = 45;
            this.HueMinVal.Text = "359";
            this.HueMinVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(101, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Lightness";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LigMin
            // 
            this.LigMin.LargeChange = 1;
            this.LigMin.Location = new System.Drawing.Point(11, 350);
            this.LigMin.Name = "LigMin";
            this.LigMin.Size = new System.Drawing.Size(100, 17);
            this.LigMin.TabIndex = 44;
            this.LigMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LigMin_Scroll);
            // 
            // VideoStream
            // 
            this.VideoStream.BackColor = System.Drawing.Color.White;
            this.VideoStream.Dock = System.Windows.Forms.DockStyle.Top;
            this.VideoStream.Location = new System.Drawing.Point(0, 0);
            this.VideoStream.Name = "VideoStream";
            this.VideoStream.Size = new System.Drawing.Size(300, 225);
            this.VideoStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VideoStream.TabIndex = 7;
            this.VideoStream.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Cakra Dirga Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTubitak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSerial.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panelCoordinate.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoStream)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox LogoUM;
        private System.Windows.Forms.PictureBox LogoTubitak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groundspeed;
        private System.Windows.Forms.Label pitchd;
        private System.Windows.Forms.Label yaw;
        private System.Windows.Forms.Label airspeed;
        private System.Windows.Forms.Label rolld;
        private System.Windows.Forms.Label altitude;
        private System.Windows.Forms.Label GSpeedVal;
        private System.Windows.Forms.Label PitchDVal;
        private System.Windows.Forms.Label YawVal;
        private System.Windows.Forms.Label ASpeedVal;
        private System.Windows.Forms.Label RollDVal;
        private System.Windows.Forms.Label AltitudeVal;
        private System.Windows.Forms.Button BtnSaveLog;
        private System.Windows.Forms.Button ButSendLog;
        private System.Windows.Forms.TextBox Logger;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.ComboBox cBoxSerialPort;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.Button btnConectSer;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCoordinate;
        private System.Windows.Forms.ComboBox cBoxMapType;
        private System.Windows.Forms.TextBox InputLogger;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGyro;
        private System.ComponentModel.BackgroundWorker GetMissionValues;
        private System.ComponentModel.BackgroundWorker HeartBeat;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label BVolt;
        private System.Windows.Forms.Label BAmp;
        private System.Windows.Forms.Label BPercent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LongPlaneVal;
        private System.Windows.Forms.Label LongPlane;
        private System.Windows.Forms.Label LatPlaneVal;
        private System.Windows.Forms.Label LatPlane;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindPlane;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox VideoStream;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button ConnectToCam;
        private System.Windows.Forms.ComboBox SelectCam;
        private System.Windows.Forms.ComboBox VideoType;
        private System.Windows.Forms.HScrollBar ThresholdBarVal;
        private System.Windows.Forms.Label ThresholdVal;
        private System.Windows.Forms.CheckBox BlurCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label BlobFilterVal;
        private System.Windows.Forms.HScrollBar BlobFilVal;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox DroppingScopeCB;
        private System.Windows.Forms.Label SatMaxVal;
        private System.Windows.Forms.Label LigMaxVal;
        private System.Windows.Forms.HScrollBar LigMax;
        private System.Windows.Forms.HScrollBar SatMax;
        private System.Windows.Forms.Label HueMaxVal;
        private System.Windows.Forms.HScrollBar HueMax;
        private System.Windows.Forms.Label SatMinVal;
        private System.Windows.Forms.Label LigMinVal;
        private System.Windows.Forms.Label HueMinVal;
        private System.Windows.Forms.HScrollBar LigMin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.HScrollBar SatMin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.HScrollBar HueMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label HueMax1Val;
        private System.Windows.Forms.HScrollBar HueMax1;
        private System.Windows.Forms.Label HueMin1Val;
        private System.Windows.Forms.HScrollBar HueMin1;
        private System.Windows.Forms.Button CaptureBtn;
        private System.Windows.Forms.Button ForceServo1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FlightModes;
        private System.Windows.Forms.Button EngineStart;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ForceServo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ServoStatus2;
        private System.Windows.Forms.Label ServoStatus1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalibrateAccelBtn;
        private System.Windows.Forms.Button CalibrateLevelBtn;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Failsafe;
        private System.Windows.Forms.HScrollBar BlobFilValMax;
        private System.Windows.Forms.Label BlobFilterValMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CalAccelLabel;
        private System.Windows.Forms.Label CalLevelLabel;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button cBoxDrawReset;
        private System.Windows.Forms.Button cBoxDrawRemove;
        private System.Windows.Forms.Button cBoxDrawAdd;
        private System.Windows.Forms.Button cBoxDrawSave;
        private System.Windows.Forms.Button DropAreaLoad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cBoxDrawLongitude;
        private System.Windows.Forms.TextBox cBoxDrawLatitude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button MapsPosSave;
        private System.Windows.Forms.Button MapsPosLoad;
        private System.Windows.Forms.HScrollBar PBOpenDuration;
        private System.Windows.Forms.Label PBOpenDurationVal;
        private System.Windows.Forms.CheckBox RecloseCB;
        private System.Windows.Forms.ComboBox cBoxDraw;
        private System.Windows.Forms.CheckBox DropPayoadCb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button ResetDropingMsnBtn;
    }
}

