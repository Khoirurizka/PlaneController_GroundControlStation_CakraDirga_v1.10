using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using MavLink;
using System.Text.RegularExpressions;

using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;

namespace Plane_Controller
{
    public partial class Dashboard : Form
    {
        //////////////////THREAD//////////////////
        Thread tGyro = new Thread(Thread1)
        {
            Name = "Gyro",
            Priority = ThreadPriority.AboveNormal
        };
        Thread tfCam = new Thread(Thread2)
        {
            Name = "fpsCam",
            Priority = ThreadPriority.Lowest
        };
        /* Thread //tICam = new Thread(Thread3)
        {
            Name = "ICam",
            Priority = ThreadPriority.Highest
        };
        */
        ///////////////CAM///////////////////////
        static FilterInfoCollection _device;
        public string[] _ListDevice = { " " };
        static VideoCaptureDevice _CaptureDevice;
        static FileVideoSource _FileVideo;
        ///Source Image
        static Bitmap _BsourceFrame = new Bitmap(1366, 1366);
        ///Process Image
        static Bitmap _HSLcolorFilterImage = new Bitmap(1366, 1366), _bitmapGreyImage = new Bitmap(640, 480),
            _bitmapBinaryImage = new Bitmap(640, 480), _blobfilterImage = new Bitmap(640, 480),
            _PictureSource = new Bitmap(640, 480), _overlayImage = new Bitmap(640, 480), _SaveImage = new Bitmap(640, 480),
            _HSLcolorFilterImage0 = new Bitmap(1366, 1366), _HSLcolorFilterImage1 = new Bitmap(1366, 1366);
        ///Posprocess Image
        static Bitmap _BsourceFramePostProcess,
            _HSLcolorFilterImage0PostProcess = new Bitmap(1366, 1366),
            _HSLcolorFilterImage1PostProcess = new Bitmap(1366, 1366),
            _HSLcolorFilterImagePostProcess = new Bitmap(1366, 1366);

        static int fpsCam;
        static int fpsVid;
        private int fpsDebug;
        public static bool CamConnected;
        public static int SelectCamId;
        public static bool CamActive;
        public static bool VidSourceActive;

        static SobelEdgeDetector _edgeFilter = new SobelEdgeDetector();
        static bool _blurFlag = false;

        public string[] videotype = { "Video Stream", "HSL Filter", "Grey Scale", "Binary Stream", "Blob Filter", "HSL 0", "HSL 1" };

        //ResizeBilinear sizefilter;
        EuclideanColorFiltering _colorEuclidFilter = new EuclideanColorFiltering();
        static Dilatation _dilatfilter = new Dilatation();
        static BlobsFiltering _blobfilter = new BlobsFiltering();
        static Erosion _erosionfilter = new Erosion();
        static HSLFiltering _hslFilter = new HSLFiltering();
        static HSLFiltering _hslFilter1 = new HSLFiltering();
        static FillHoles _FillHolefilter = new FillHoles();
        static Add _AddfilterImage = new Add();
        double TargetDistance;
        bool TargetDetected;
        bool OnDropingArea;
        bool _DropingScope;

        static int iThreshold, iBlobMinFilter, iBlobMaxFilter;

        static int iHueMin, iHueMin1, iSatMin, iLigMin;
        static int iHueMax, iHueMax1, iSatMax, iLigMax;

        String ImageDir;
        String VideoDir;

        //////////////////MAV LINK////////////////
        Mavlink Mv = new Mavlink();
        Msg_heartbeat Hb = new Msg_heartbeat();
        Msg_sys_status Ss = new Msg_sys_status();
        Msg_power_status Ps = new Msg_power_status();
        static Msg_attitude At = new Msg_attitude();
        Msg_gps_raw_int Gps = new Msg_gps_raw_int();
        Msg_vfr_hud Vfr = new Msg_vfr_hud();
        Msg_data_stream Ds = new Msg_data_stream();
        Msg_raw_pressure Rp = new Msg_raw_pressure();
        Msg_scaled_pressure Sp = new Msg_scaled_pressure();
        Msg_command_ack Ack = new Msg_command_ack();
        Msg_statustext St = new Msg_statustext();
        Msg_mission_count Mc = new Msg_mission_count();
        Msg_servo_output_raw sor = new Msg_servo_output_raw();
        Msg_high_latency2 Hglat = new Msg_high_latency2();
        Msg_altitude Alti = new Msg_altitude();

        //Msg_mission_item[] Mi = new Msg_mission_item[32];

        Msg_scaled_imu2 ScImu = new Msg_scaled_imu2();

        int Prs;
        int Tep;
        int Dif;
        int Systemid;
        int Componentid;
        int Sequence;
        volatile int MI = -1;
        Util ut;

        String[] SMode = { "MANUAL", "CIRCLE", "STABILIZE", "TRAINING", "ACRO",
                            "FBWA", "FBWB", "CRUISE", "AUTOTUNE", "RTL",
                            "AUTO", "LOITER", "TAKEOFF", "AVOID_ADSSB", "GUIDDED",
                           "QSTABILIZE", "QHOVER", "QLOITER", "QLAND", "QRTL",
                            "QAUTOTUNE", "QACRO", "TERMAL", "INITIALISING" };

        private bool FailsafemodeTemp;
        private bool LastFailsafemodeTemp;
        private UInt16 byteFailsafemode;
        private DateTime Failsafemodetimer = DateTime.MinValue;

        private UInt16 ModeID;
        private bool ModeConTemp;
        private bool LastModeConTemp;
        private UInt16 byteModeID;
        private DateTime modetimer = DateTime.MinValue;

        private bool EngineStartCon;
        private bool EngineStartConTemp;
        private bool LastEngineStartConTemp;
        private UInt16 byteEngineStartCon;
        private DateTime armedtimer = DateTime.MinValue;
        /////////////////////DATA/////////////////
        public double Altitude;
        public double GSpeed;
        public double ASpeed;

        public float DistToWP;///
        public float DisttoMAV;///

        public double BatVolt;
        public double BatAmp;
        public double BatPercent;

        /////////////Droping PAYLOAD///////////////
        private bool DropingMode;

        public int ServoThreshold = 1300;
        public int ServoPL1RC;
        public int ServoPL2RC;
        public bool TargetAvaliable;

        public int DropCnt;
        public bool PL1Away;
        public bool PL2Away;
        private DateTime ForceServotimer = DateTime.MinValue;
        private DateTime DetectingServotimer = DateTime.MinValue;
        private bool ReclosePBCon;
        private int PBOpenDurationSecond;

        /// ///////////////GYRO////////////////////
        static Gyro gyrovar;
        static float Pitch { get; set; }
        static float Roll { get; set; }
        static float Yaw { get; set; }
        /////////////////////SERIAL/////////////////
        public bool SerialConected = false;
        public string[] ports = { " " };
        public string[] bauddrates = { "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "1000000", "2000000" };

        /// ///////////////MAPS////////////////////
        public string[] mapType = { "Map", "Satellit", "Terrain", "Hybrid" };
        public string[] DrawMode = { "WayPoint", "Boundary", "Drop Zone" };
        GMapOverlay PlaneMarkPos = new GMapOverlay("Plane");
        GMapOverlay PathTrajectory = new GMapOverlay("PathTrajectory");
        GMapOverlay TargetMarkPos = new GMapOverlay("Target");
        GMapOverlay VehicleWP = new GMapOverlay("VehicleWP");
        GMapOverlay BoundaryArea = new GMapOverlay("BoundaryArea");
        GMapOverlay DropingArea = new GMapOverlay("DropingArea");

        public double LatitudePlane;//-7.97f
        public double LongitudePlane;//112.65f

        public double LatitudeTarget;
        public double LongitudeTarget;

        public GMap.NET.PointLatLng MapCoordinate;

        public List<GMap.NET.PointLatLng> VehicleWPPoint = new List<GMap.NET.PointLatLng> { };
        public GMapRoute VehicleWPPolygon;

        public List<GMap.NET.PointLatLng> BoundaryPoint = new List<GMap.NET.PointLatLng> { };
        public GMapPolygon BoundaryPolygon;
        
        public List<GMap.NET.PointLatLng> DropingAreaPoint = new List<GMap.NET.PointLatLng> { };
        public GMapPolygon DropingAreaPolygon;

        public List<GMap.NET.PointLatLng> PathTrjPoint = new List<GMap.NET.PointLatLng> { };
        public GMapRoute PathTrj;
        private DateTime UpdateTrjTimer = DateTime.MinValue;
        //////////////////CALIBRATION/////////////////
        ///Accel
        public bool _incalibrate;
        public int AccelCalcount;
        ///Level
        public bool updateLevelStatus;
        ///////////////////LOGGER/////////////////
        public bool LoggerAutoScroll = false;
        //////////////////DEBUGER/////////////////
        private int cnt = -160;
        private bool Just1Debug;
        private bool Just2Debug;
        private bool Just3Debug;
        private bool Just4Debug;
        private bool Just5Debug;
        private bool Just6Debug;

        public Dashboard()
        {
            //////////////////THREAD/////////////////
            InitializeComponent();
            DoubleBuffered = true;
            tGyro.Start();
            tfCam.Start();
            ////tICam.Start();
            ////tICam.Suspend();
            //////////////////CALIBRATION/////////////////
            updateLevelStatus=false;
            /// ///////////////MAV LINK////////////////
            Ack.result = (byte)255;
            Mv.PacketReceived += Mv_PacketReceived;
            ut = new Util();
            FlightModes.Text = SMode[0];
            //////////////////DROP PAYLOAD///////////
            DropCnt = 0;
            PL1Away = false;
            PL2Away = false;
            DropingMode = DropPayoadCb.Checked;
            ReclosePBCon = RecloseCB.Checked;
            /// ////////////////CAM///////////////////
            CheckForIllegalCrossThreadCalls = false;

            _device = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;

            if (_device[_device.Count - 1].Name != _ListDevice.Last<string>())
            {
                _ListDevice.DefaultIfEmpty();
                _ListDevice = new string[_device.Count];
                for (var i = 0; i < _device.Count; i++)
                {
                    _ListDevice[i] = _device[i].Name;
                }
                SelectCam.Items.Clear();
                SelectCam.Items.AddRange(_ListDevice);
                SelectCam.Items.Add("Picture Source");
                SelectCam.Items.Add("Video Source");
            }
            if (SelectCam.Items.Count > 0)
                SelectCam.SelectedIndex = 0;

            VideoType.Items.AddRange(videotype);
            VideoType.SelectedIndex = 0;

            iThreshold = ThresholdBarVal.Value;
            ThresholdVal.Text = iThreshold.ToString();

            iBlobMinFilter = BlobFilVal.Value;
            BlobFilterVal.Text = iBlobMinFilter.ToString();

            iBlobMaxFilter = BlobFilValMax.Value;
            BlobFilterValMax.Text = iBlobMaxFilter.ToString();

            iHueMin = HueMin.Value;
            HueMinVal.Text = iHueMin.ToString();
            iHueMax = HueMax.Value;
            HueMaxVal.Text = iHueMax.ToString();

            iHueMin1 = HueMin1.Value;
            HueMin1Val.Text = iHueMin1.ToString();
            iHueMax1 = HueMax1.Value;
            HueMax1Val.Text = iHueMax1.ToString();

            iSatMin = SatMin.Value;
            SatMinVal.Text = iSatMin.ToString();
            iSatMax = SatMax.Value;
            SatMaxVal.Text = iSatMax.ToString();

            iLigMin = LigMin.Value;
            LigMinVal.Text = iLigMin.ToString();
            iLigMax = LigMax.Value;
            LigMaxVal.Text = iLigMax.ToString();

            PBOpenDurationSecond = PBOpenDuration.Value;
            PBOpenDurationVal.Text = PBOpenDurationSecond.ToString();

            _DropingScope = DroppingScopeCB.Checked;
            _blurFlag = BlurCb.Checked;


            /// //////////////////MAP/////////////////
            gMap.MinZoom = 2;
            gMap.MaxZoom = 20;
            gMap.Zoom = 15;
            cBoxMapType.Items.AddRange(mapType);
            cBoxMapType.SelectedIndex = 3;
            SelectMap(cBoxMapType.SelectedIndex);
            ///Map init position
            MapCoordinate.Lat = -7.97;
            MapCoordinate.Lng = 112.65;
            gMap.Position = MapCoordinate;

            cBoxDraw.Items.AddRange(DrawMode);
            cBoxDraw.SelectedIndex = 0;
            /// /////////////////Gyro////////////////
            this.panelGyro.Controls.Clear();
            gyrovar = new Gyro() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelGyro.Controls.Add(gyrovar);
            gyrovar.Show();

            /// ////////////////SERIAL//////////////////////
            SerialConected = false;
            try
            {
                ports = SerialPort.GetPortNames();
                if (ports.Length > 0)
                    cBoxSerialPort.Items.AddRange(ports);
                else
                    cBoxSerialPort.Items.Add(" ");

                if (cBoxSerialPort.Items.Count > 0)
                    cBoxSerialPort.SelectedIndex = cBoxSerialPort.Items.Count - 1;

                cBoxBaudrate.Items.AddRange(bauddrates);
                cBoxBaudrate.SelectedIndex = 5;
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }

            if (!serialPort1.IsOpen)
            {
                btnConectSer.Text = "CONNECT";
            }
            else
            {
                btnConectSer.Text = "DISCONNECT";
            }
            /// ////////////////LOGGER//////////////////////
            Logger.ScrollBars = ScrollBars.Both;
            Logger.Text = "### UNIVERSITAS NEGERI MALANG ###" + Environment.NewLine
                        + "#########  CAKRADIRGA  #########" + Environment.NewLine;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            tGyro.Abort();
            tfCam.Abort();

            StopVid();
            if (serialPort1.IsOpen)
                serialPort1.Close();
            if (CamConnected)
                StopCam();
            //tICam.Resume();
            //tICam.Abort();

        }

        ///////////////////////Update Data/////////////////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

                if (DropingMode && TargetDetected)// && ModeID == 10 && OnDropingArea)
                {
                    if (DropCnt == 0 && !PL1Away)
                    {
                        PL1Away = true;
                        DetectingServotimer = DateTime.Now;
                        ///Debuger
                        Console.WriteLine("Payload 1 Away");
                        if (!Just1Debug)
                        {
                            LogPrint("Payload 1 Away");
                            Just1Debug = true;
                        }
                        ///
                    }
                    else if (DropCnt == 1 && !PL2Away)
                    {
                        PL2Away = true;
                        DetectingServotimer = DateTime.Now;

                        ///Debuger
                        Console.WriteLine("Payload 2 Away");

                        if (!Just2Debug)
                        {
                            LogPrint("Payload 2 Away");
                            Just2Debug = true;
                        }
                        ///
                    }
                }

            if (!(DetectingServotimer.AddSeconds(PBOpenDurationSecond) < DateTime.Now))
            {
                if (DropCnt == 0 && PL1Away)
                {
                    if (SerialConected)
                    {
                        SetServo(5, 1100, 1900, false);
                    }
                    ///Debuger
                    Console.WriteLine("Payload Bay 1 Open");

                    if (!Just3Debug)
                    {
                        LogPrint("Payload Bay 1 Open");
                        Just3Debug = true;
                    }
                    ///
                }
                if (DropCnt == 1 && PL2Away)
                {
                    if (SerialConected)
                    {
                        SetServo(8, 1100, 1900, false);
                    }
                    ///Debuger
                    Console.WriteLine("Payload Bay 2 Open");
                    if (!Just4Debug)
                    {
                        LogPrint("Payload Bay 2 Open");
                        Just4Debug = true;
                    }
                    ///
                }
            }
            else
            {
                if (ReclosePBCon)
                {
                    if (DropCnt == 0 && PL1Away)
                    {
                        if (SerialConected)
                        {
                            SetServo(5, 1100, 1900, true);
                        }
                        DropCnt++;

                        ///Debuger
                        Console.WriteLine("Payload Bay 1 Closed");
                        if (!Just5Debug)
                        {
                            LogPrint("Payload Bay 1 Closed");
                            Just5Debug = true;
                        }
                        ///
                    }
                    if (DropCnt >= 1 && PL2Away)
                    {
                        if (SerialConected)
                        {
                            SetServo(8, 1100, 1900, true);
                        }
                        ///Debuger
                        Console.WriteLine("Payload Bay 2 Closed");
                        if (!Just6Debug)
                        {
                            LogPrint("Payload Bay 2 Closed");
                            Just6Debug = true;
                        }
                        ///
                    }
                }
                else
                {
                    if (DropCnt == 0 && PL1Away)
                    {
                        DropCnt++;
                    }
                }
            }

            try
                {
                if (SerialPort.GetPortNames().Last<string>() != ports.Last<string>())
                {
                    ports = SerialPort.GetPortNames();
                    cBoxSerialPort.Items.Clear();

                    if (ports.Length > 0)
                        cBoxSerialPort.Items.AddRange(ports);
                    else
                        cBoxSerialPort.Items.Add(" ");
                }
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }

            _device = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_device[_device.Count - 1].Name != _ListDevice.Last<string>())
            {
                _ListDevice.DefaultIfEmpty();
                _ListDevice = new string[_device.Count];
                for (var i = 0; i < _device.Count; i++)
                {
                    _ListDevice[i] = _device[i].Name;
                }
                SelectCam.Items.Clear();
                SelectCam.Items.AddRange(_ListDevice);
            }
            if (CamActive)
                fpsDebug = fpsCam;
            else if (VidSourceActive)
                fpsDebug = fpsVid;

            ///Auto scroll logger
            if (LoggerAutoScroll)
            {
                Logger.SelectionStart = Logger.TextLength;
                Logger.ScrollToCaret();
            }

            //DistToWP += 0.1f;
            //DisttoMAV += 0.1f;
            BVolt.Text = BatVolt.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "V";//String.Format("{0:f}V", BatVolt);
            BAmp.Text = BatAmp.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "A"; //String.Format("{0:f}A", BatAmp);
            BPercent.Text = BatPercent.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "%";

            AltitudeVal.Text = Altitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            ASpeedVal.Text = ASpeed.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            GSpeedVal.Text = GSpeed.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

            YawVal.Text = Yaw.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            PitchDVal.Text = Pitch.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            RollDVal.Text = Roll.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

            LatPlaneVal.Text = LatitudePlane.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            LongPlaneVal.Text = LongitudePlane.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

            if (SerialConected)
            {
                //Failsafe
                if (Hb.system_status == (byte)MAV_STATE.MAV_STATE_CRITICAL)
                {
                    FailsafemodeTemp = true;
                }
                else
                {
                    FailsafemodeTemp = false;
                }

                if (FailsafemodeTemp != LastFailsafemodeTemp)
                {
                    Failsafemodetimer = DateTime.Now;
                }

                if (FailsafemodeTemp)
                {
                    byteFailsafemode = (UInt16)(0xFF);
                }
                else
                {
                    if ((Failsafemodetimer.AddMilliseconds(100) < DateTime.Now))
                    {
                        byteFailsafemode = (UInt16)(byteFailsafemode << 1);
                        LastFailsafemodeTemp = FailsafemodeTemp;
                    }
                }

                if (byteFailsafemode == 0x00)
                {
                    Failsafe.Text = "STEADY";
                }
                else
                {
                    Failsafe.Text = "FAILSAFE ";
                }

                //Mode
                ModeID = (UInt16)Hb.custom_mode;
                if (ModeID != 0)
                {
                    ModeConTemp = true;
                }
                else
                {
                    ModeConTemp = false;
                }


                if (ModeConTemp != LastModeConTemp)
                {
                    modetimer = DateTime.Now;
                }

                if (ModeConTemp)
                {
                    byteModeID = (UInt16)(0xFF);
                }
                else
                {
                    if ((modetimer.AddMilliseconds(100) < DateTime.Now))
                    {
                        byteModeID = (UInt16)(byteModeID << 1);
                        LastModeConTemp = ModeConTemp;
                    }
                }

                if (byteModeID == 0x00)
                {
                    FlightModes.Text = SMode[0];
                }
                else
                {
                    if (ModeID != 0)
                        FlightModes.Text = SMode[ModeID];

                }

                ///// Arming UI
                if ((Hb.base_mode & (byte)MAV_MODE_FLAG.MAV_MODE_FLAG_SAFETY_ARMED) == 0b10000000)
                {
                    EngineStartConTemp = true;
                }
                else
                {
                    EngineStartConTemp = false;
                }


                if (EngineStartConTemp != LastEngineStartConTemp)
                {
                    armedtimer = DateTime.Now;
                }

                if (EngineStartConTemp)
                {
                    byteEngineStartCon = (UInt16)(0xFF);
                }
                else
                {
                    if ((armedtimer.AddMilliseconds(100) < DateTime.Now))
                    {
                        byteEngineStartCon = (UInt16)(byteEngineStartCon << 1);
                        LastEngineStartConTemp = EngineStartConTemp;
                    }
                }

                if (byteEngineStartCon == 0x00)
                {
                    EngineStartCon = false;
                }
                else
                {
                    EngineStartCon = true;
                }
                ////
                if (EngineStartCon == false) // not armed
                {

                    Status.Text = "ENGINE OFF";
                    Status.ForeColor = Color.White;
                    EngineStart.BackgroundImage = Properties.Resources.Engine_Off;
                    FlightModes.ForeColor = Color.White;
                    Failsafe.ForeColor = Color.White;
                }
                else if (EngineStartCon == true) // armed
                {
                    Status.Text = "ENGINE ON";
                    Status.ForeColor = Color.FromArgb(255, 255, 255, 128);
                    EngineStart.BackgroundImage = Properties.Resources.Engine_On;
                    FlightModes.ForeColor = Color.FromArgb(255, 255, 255, 128);
                    Failsafe.ForeColor = Color.FromArgb(255, 255, 255, 128);
                }
            }
            /////Draw trajectory///
            if (EngineStartCon)
            {
                if ((UpdateTrjTimer.AddMilliseconds(100) < DateTime.Now))
                {
                    GMap.NET.PointLatLng DALat = new GMap.NET.PointLatLng();
                   // cnt++;
                    DALat.Lat = LatitudePlane;// 0;
                    DALat.Lng = LongitudePlane;// cnt;
                    PathTrjPoint.Add(DALat);
                    UpdateTrjTimer = DateTime.Now;
                }
            }
            //////Drop Payload/////
            if (ServoPL1RC < ServoThreshold)
            {
                ServoStatus1.Text = "Closed";
            }
            else
            {
                ServoStatus1.Text = "Opened";
            }
            if (ServoPL2RC < ServoThreshold)
            {
                ServoStatus2.Text = "Closed";
            }
            else
            {
                ServoStatus2.Text = "Opened";
            }

            ////////////////////////////////////////////////////
            if (updateLevelStatus)
            {
                if (Ack.result == (byte)MAV_RESULT.MAV_RESULT_ACCEPTED)
                {
                    CalLevelLabel.Text = "Level Calibrate Completed";

                }
                else
                {
                    CalLevelLabel.Text = "Level Calibrate Failed";
                }
                updateLevelStatus = false;
            }
            ////////////////////////////////////////////////////

            TargetMarkPos.Markers.Clear();
            PlaneMarkPos.Markers.Clear();
            PathTrajectory.Markers.Clear();

            // PlaneMarkPos.Markers.Add(new TargetPoint(new GMap.NET.PointLatLng(-7.97, 112.65), 35));//Debug //
            // PlaneMarkPos.Markers.Add(new PlanePoint(new GMap.NET.PointLatLng(-7.97, 112.65), 30, Yaw));//Debug //

            if (TargetAvaliable)
                TargetMarkPos.Markers.Add(new TargetPoint(new GMap.NET.PointLatLng(LatitudeTarget, LongitudeTarget), 20));
            if (0 < Gps.satellites_visible)
                PlaneMarkPos.Markers.Add(new PlanePoint(new GMap.NET.PointLatLng(LatitudePlane, LongitudePlane), 30, Yaw));

            //PathTrajectory.Markers.Add(new MarkDropArea(new GMap.NET.PointLatLng(-7.97, 112.65), new GMap.NET.PointLatLng(-8.98, 111.66), 30 ));

            DropingAreaPolygon = new GMapPolygon(DropingAreaPoint, "Droping Area")
            {
                Stroke = new Pen( Brushes.Red,2),
                Fill= new SolidBrush(Color.FromArgb(40,Color.Red))
               
            };

            BoundaryPolygon = new GMapPolygon(BoundaryPoint, "Boundary")
            {
                Stroke = new Pen(Brushes.DarkRed, 2),
                Fill = new SolidBrush(Color.FromArgb(25, Color.DarkRed))

            };

            VehicleWPPolygon = new GMapRoute(VehicleWPPoint, "Vehicle Waypoint")
            {
                Stroke = new Pen(Brushes.Orange, 3),
//                Fill = new SolidBrush(Color.FromArgb(100, Color.LightCyan))
            };

            PathTrj = new GMapRoute(PathTrjPoint, "Path Trajectory")
            {
                Stroke = new Pen(Brushes.OrangeRed, 3),
            };

            VehicleWP.Routes.Clear();
            VehicleWP.Routes.Add(VehicleWPPolygon);
            BoundaryArea.Polygons.Clear();
            BoundaryArea.Polygons.Add(BoundaryPolygon);
            DropingArea.Polygons.Clear();
            DropingArea.Polygons.Add(DropingAreaPolygon);

            PathTrajectory.Routes.Clear();
            PathTrajectory.Routes.Add(PathTrj);

            gMap.Overlays.Clear();
            gMap.Overlays.Add(VehicleWP);
            gMap.Overlays.Add(BoundaryArea);
            gMap.Overlays.Add(DropingArea);
            gMap.Overlays.Add(PathTrajectory);
            gMap.Overlays.Add(TargetMarkPos);
            gMap.Overlays.Add(PlaneMarkPos);

        }
        public void UpdateData()
        {

            Altitude = Alti.altitude_local;
            GSpeed = Vfr.groundspeed;
            ASpeed = Vfr.airspeed;

            BatVolt = (double)(Ss.voltage_battery / 1000.0f);
            BatAmp = (double)(Ss.current_battery / 1000.0f);
            BatPercent = (double)(Ss.battery_remaining / 1000.0f);

            LatitudePlane = (double)(Gps.lat / 10000000.0f);//-7.97f;//
            LongitudePlane = (double)(Gps.lon / 10000000.0f);//112.65f; //
            ServoPL1RC = sor.servo5_raw;
            ServoPL2RC = sor.servo8_raw;

        }

        //////////////////////SERIAL////////////////////
        private void btnConectSer_Click(object sender, EventArgs e)
        {
            if (!SerialConected)
            {
                try
                {
                    serialPort1.PortName = cBoxSerialPort.Text;
                    serialPort1.BaudRate = int.Parse(cBoxBaudrate.Text);

                    if (cBoxSerialPort.Text != " ")
                        serialPort1.Open();

                    if (serialPort1.IsOpen)
                    {
                        SerialConected = true;
                        btnConectSer.Text = "DISCONNECT";
                        btnConectSer.BackgroundImage = Properties.Resources.ConnectSerial;
                        cBoxSerialPort.Enabled = false;
                        cBoxBaudrate.Enabled = false;
                        LoggerAutoScroll = true;
                    }
                }
                catch (Exception ex)
                {
                    LogPrint(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    if (!serialPort1.IsOpen)
                    {
                        SerialConected = false;
                        btnConectSer.Text = "CONNECT";
                        btnConectSer.BackgroundImage = Properties.Resources.DisconnectSerial;
                        cBoxSerialPort.Enabled = true;
                        cBoxBaudrate.Enabled = true;
                        LoggerAutoScroll = false;
                    }
                }
                catch (Exception ex)
                {
                    LogPrint(ex.Message);
                }
            }
        }

        private void cBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogPrint("PORT=" + cBoxSerialPort.Text + ";");
        }

        private void cBoxBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogPrint("BAUDRATE=" + cBoxBaudrate.Text + ";");
        }
        //////////////////////LOGGER////////////////////

        private void ButSendLog_Click(object sender, EventArgs e)
        {
            SendCmdLog();
        }

        private void InputLogger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendCmdLog();
            }
        }
        
        private void BtnSaveLog_Click(object sender, EventArgs e)
        {
            string pathDdocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter StrTxt = null;

            if (Directory.Exists(pathDdocument + "//CakraDirgaUM"))
            {
                StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaLog.txt");
            }
            else
            {
                Directory.CreateDirectory(pathDdocument + "//CakraDirgaUM");
                StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaLog.txt");
            }

            StrTxt.Write(Logger.Text);
            StrTxt.Close();
        }
        public void SendCmdLog()
        {
            Logger.Text = Logger.Text + Environment.NewLine + InputLogger.Text;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(InputLogger.Text + Environment.NewLine);
            }

            //////////////// Send Command ///////////////////
            /// Clear Screen
            if (InputLogger.Text == "clr()")
            {
                Logger.Text = "### UNIVERSITAS NEGERI MALANG ###" + Environment.NewLine
                        + "#########  CAKRADIRGA  #########" + Environment.NewLine;
            }
            InputLogger.Text = "\0";
        }
        public void LogPrint(string text)
        {
            Logger.Text += Environment.NewLine + text;
        }
        public async Task PrintlnSerial()
        {
            Logger.Text += Environment.NewLine + "Reading data from serial..." + Environment.NewLine;
            while (serialPort1.IsOpen)
            {
                string message = await SerialReadLineAsync(serialPort1).ConfigureAwait(true);
                Logger.Text += message;
            }
        }

        async Task<string> SerialReadLineAsync(SerialPort serialPort)
        {
            byte[] buffer = new byte[1];
            string result = string.Empty;
            //Console.WriteLine("Let's start reading.");

            while (true)
            {
                await serialPort.BaseStream.ReadAsync(buffer, 0, 1).ConfigureAwait(false);
                result += serialPort.Encoding.GetString(buffer);

                if (result.EndsWith(serialPort.NewLine))
                {
                    result = result.Substring(0, result.Length - serialPort.NewLine.Length);
                    result.TrimEnd('\r', '\n');
                    //Console.Write(string.Format("Data: {0}", result));
                    result += "\r\n";
                    return result;
                }
            }
        }

        //////////////////////////// MAPS//////////////////////////////
        public void SelectMap(int Index)
        {
            if (Index == 0)
            {
                gMap.MapProvider = GMapProviders.GoogleMap;
            }
            else if (Index == 1)
            {
                gMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            else if (Index == 2)
            {
                gMap.MapProvider = GMapProviders.GoogleTerrainMap;
            }
            else if (Index == 3)
            {
                gMap.MapProvider = GMapProviders.GoogleHybridMap;
            }
            LogPrint("MAPTYPE=" + cBoxMapType.Text + ";");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLatitude.Text) && !string.IsNullOrWhiteSpace(tbLongitude.Text))
            {
                MapCoordinate.Lat = Convert.ToDouble(tbLatitude.Text);
                MapCoordinate.Lng = Convert.ToDouble(tbLongitude.Text);
            }

            gMap.Position = new GMap.NET.PointLatLng(MapCoordinate.Lat, MapCoordinate.Lng);
        }

        private void cBoxMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectMap(cBoxMapType.SelectedIndex);
        }
        private void FindPlane_Click(object sender, EventArgs e)
        {
            if (0 < Gps.satellites_visible)
                gMap.Position = new GMap.NET.PointLatLng(LatitudePlane, LongitudePlane);
            else
                LogPrint("Plane Not Found");
        }

        ////////////////////////Camera//////////////////////////////
        private void ConnectToCam_Click(object sender, EventArgs e)
        {
            SelectCamId = SelectCam.SelectedIndex;

            try
            {
                if (SelectCam.Text == "Picture Source")
                {
                    VidSourceActive = false;
                    CamActive = false;
                   // Dashboard.ActiveForm.Invoke(new Action(() => VidSourceActive = false));
                   // Dashboard.ActiveForm.Invoke(new Action(() => CamActive = false));
                    try
                    {
                        StopVid();
                        StopCam();
                        //tICam.Resume();
                        OpenFileDialog OIdialog = new OpenFileDialog();
                        OIdialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | All Files|*.*";
                        if (OIdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            ImageDir = OIdialog.FileName;
                            get_Frame_();
                        }
                    }
                    catch (Exception ex)
                    {
                        LogPrint(ex.Message);
                    }
                }
                else if (SelectCam.Text == "Video Source")
                {
                    VidSourceActive = true;
                    CamActive = false;
                   // Dashboard.ActiveForm.Invoke(new Action(() => VidSourceActive = true));
                   // Dashboard.ActiveForm.Invoke(new Action(() => CamActive = false));
                    try
                    {
                        if (_FileVideo != null)
                            _FileVideo.Stop();
                        StopCam();
                        StopVid();

                        OpenFileDialog OIdialog = new OpenFileDialog();
                        //"Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*" (*.avi, *.mp4, *.mp4v, *.mpeg, *.mov, *.mkv)
                        OIdialog.Filter = "Media Files | *.avi; | All Files|*.*";
                        if (OIdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            VideoDir = OIdialog.FileName;
                            OpenVideo(VideoDir);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogPrint(ex.Message);
                    }
                }
                else
                {
                    VidSourceActive = false;
                    CamActive = true;
                    //Dashboard.ActiveForm.Invoke(new MethodInvoker(() => VidSourceActive = false));
                    //Dashboard.ActiveForm.Invoke(new MethodInvoker(() => CamActive = true));
                    if (_FileVideo != null)
                        _FileVideo.Stop();
                    if (!CamConnected)
                    {
                        StartCam(SelectCam.SelectedIndex);
                        CamConnected = true;
                        ConnectToCam.Text = "Disconnect";

                    }
                    else
                    {
                        StopCam();
                        CamConnected = false;
                        ConnectToCam.Text = "Connect";

                    }
                }
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }
        private void HueMin_Scroll(object sender, ScrollEventArgs e)
        {
            iHueMin = HueMin.Value;
            HueMinVal.Text = iHueMin.ToString();
        }

        private void HueMax_Scroll(object sender, ScrollEventArgs e)
        {
            iHueMax = HueMax.Value;
            HueMaxVal.Text = iHueMax.ToString();
        }
        private void HueMin1_Scroll(object sender, ScrollEventArgs e)
        {
            iHueMin1 = HueMin1.Value;
            HueMin1Val.Text = iHueMin1.ToString();
        }
        private void HueMax1_Scroll(object sender, ScrollEventArgs e)
        {
            iHueMax1 = HueMax1.Value;
            HueMax1Val.Text = iHueMax1.ToString();
        }
        private void SatMin_Scroll(object sender, ScrollEventArgs e)
        {
            iSatMin = SatMin.Value;
            SatMinVal.Text = iSatMin.ToString();
        }

        private void SatMax_Scroll(object sender, ScrollEventArgs e)
        {
            iSatMax = SatMax.Value;
            SatMaxVal.Text = iSatMax.ToString();
        }

        private void LigMin_Scroll(object sender, ScrollEventArgs e)
        {
            iLigMin = LigMin.Value;
            LigMinVal.Text = iLigMin.ToString();
        }

        private void LigMax_Scroll(object sender, ScrollEventArgs e)
        {
            iLigMax = LigMax.Value;
            LigMaxVal.Text = iLigMax.ToString();
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            string pathDdocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int i = 1;
            string Ipath;

            if (Directory.Exists(pathDdocument + "//CakraDirgaUM"))
            {
              

                while (File.Exists(pathDdocument + "//CakraDirgaUM//DebugCam (" + i.ToString() + ").jpeg"))
                {
                    i++;
                }
                Ipath = pathDdocument + "//CakraDirgaUM//DebugCam (" + i.ToString() + ").jpeg";
            }
            else
            {
                Directory.CreateDirectory(pathDdocument + "//CakraDirgaUM");
                Ipath = pathDdocument + "//CakraDirgaUM//DebugCam (1).jpeg";
            }
            LogPrint("Image has been saved to "+Ipath);
            _SaveImage.Save(Ipath);

        }
        private void DroppingScopeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DroppingScopeCB.Checked)
                _DropingScope = true;
            else
                _DropingScope = false;
        }

        void StartCam(int deviceindex)
        {
            try
            {
                _CaptureDevice = new VideoCaptureDevice(_device[deviceindex].MonikerString);
                _CaptureDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                _CaptureDevice.Start();
                //tICam.Resume();
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }
        void OpenVideo(string Vpath)
        {
            try
            {
                LogPrint(Vpath);
                _FileVideo = new FileVideoSource(Vpath);
                _FileVideo.VideoSourceError += new VideoSourceErrorEventHandler(videoSource_Error);

                _FileVideo.NewFrame += new NewFrameEventHandler(get_Frame);
                _FileVideo.Start();
               // LogPrint("fps:    " + _FileVideo.FramesReceived.ToString());
                /* LogPrint("height: " + _FileVideo.Height.ToString());
                 
                 LogPrint("codec:  " + _FileVideo.CodecName.ToString());
                */
               // LogPrint("width:  " + _FileVideo.FramesReceived);

            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }

        private void ThresholdBarVal_Scroll(object sender, ScrollEventArgs e)
        {
            iThreshold = ThresholdBarVal.Value;
            ThresholdVal.Text = iThreshold.ToString();
        }

        private void BlobFilVal_Scroll(object sender, ScrollEventArgs e)
        {
            iBlobMinFilter = BlobFilVal.Value;
            BlobFilterVal.Text = iBlobMinFilter.ToString();
        }
        private void BlurCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BlurCb.Checked)
                _blurFlag = true;
            else
                _blurFlag = false;
        }
                      //  if (SelectCam.Text == "Video Source")
                    //_FileVideo.Stop();
        void StopCam()
        {
            try
            {
                if (_CaptureDevice != null)
                {
                    _CaptureDevice.Stop(); 
                    //tICam.Suspend();
                }

            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }
        void StopVid()
        {
            try
            {
                if (_FileVideo != null)
                {
                    _FileVideo.Stop();
                    //tICam.Suspend();
                }

            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }

        private void BlobFilValMax_Scroll(object sender, ScrollEventArgs e)
        {
                iBlobMaxFilter = BlobFilValMax.Value;
                BlobFilterValMax.Text = iBlobMaxFilter.ToString();
        }

        private void SelectCam_SelectedIndexChanged(object sender, EventArgs e)
        {

            StopCam();
            StopVid();
            CamConnected = false;
            if (SelectCam.Text == "Picture Source")
                ConnectToCam.Text = "Open Image";
            else if (SelectCam.Text == "Video Source")
                ConnectToCam.Text = "Open Video";
            else
            {
                if (CamConnected)
                {
                    ConnectToCam.Text = "Disconnect";
                }
                else
                {
                    ConnectToCam.Text = "Connect";
                }
            }
        }

        void LoadImage()
        {
            try
            {
                _PictureSource = (Bitmap)Bitmap.FromFile(ImageDir);
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }

        private void DrawPathAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBoxDrawLatitude.Text) && string.IsNullOrWhiteSpace(cBoxDrawLongitude.Text))
                return;
            GMap.NET.PointLatLng LatLngPoint = new GMap.NET.PointLatLng();

            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    LatLngPoint.Lat = Convert.ToDouble(cBoxDrawLatitude.Text);
                    LatLngPoint.Lng = Convert.ToDouble(cBoxDrawLongitude.Text);
                    VehicleWPPoint.Add(LatLngPoint);
                    break;
                case 1:
                    LatLngPoint.Lat = Convert.ToDouble(cBoxDrawLatitude.Text);
                    LatLngPoint.Lng = Convert.ToDouble(cBoxDrawLongitude.Text);
                    BoundaryPoint.Add(LatLngPoint);
                    break;
                case 2:
                    LatLngPoint.Lat = Convert.ToDouble(cBoxDrawLatitude.Text);
                    LatLngPoint.Lng = Convert.ToDouble(cBoxDrawLongitude.Text);
                    DropingAreaPoint.Add(LatLngPoint);
                    break;
            }
        }

        private void DrawPathRemove_Click(object sender, EventArgs e)
        {
            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    VehicleWPPoint.RemoveAt(VehicleWPPoint.Count - 1);
                    break;
                case 1:
                    BoundaryPoint.RemoveAt(VehicleWPPoint.Count - 1);
                    break;
                case 2:
                    DropingAreaPoint.RemoveAt(DropingAreaPoint.Count - 1);
                    break;
            }
        }

        private void DrawPathReset_Click(object sender, EventArgs e)
        {
            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    VehicleWPPoint.Clear();
                    break;
                case 1:
                    BoundaryPoint.Clear();
                    break;
                case 2:
                    DropingAreaPoint.Clear();
                    break;
            }
        }

        private void DrawPathSave_Click(object sender, EventArgs e)
        {
            string pathDdocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter StrTxt = null;
            string strlat = "-";
            string strlng = "-";

            if (!Directory.Exists(pathDdocument + "//CakraDirgaUM"))
            {
                Directory.CreateDirectory(pathDdocument + "//CakraDirgaUM");
            }

            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaWP.txt");
                    break;
                case 1:
                    StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaBoundary.txt");
                    break;
                case 2:
                    StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaDropArea.txt");
                    break;
            }
            
            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < VehicleWPPoint.Count; i++)
                    {
                        strlat = VehicleWPPoint[i].Lat.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        strlng = VehicleWPPoint[i].Lng.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        StrTxt.Write("{Lat =" + strlat + ", Lng =" + strlng + "}" + Environment.NewLine);
                    }
                    break;
                case 1:
                    for (int i = 0; i < BoundaryPoint.Count; i++)
                    {
                        strlat = BoundaryPoint[i].Lat.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        strlng = BoundaryPoint[i].Lng.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        StrTxt.Write("{Lat =" + strlat + ", Lng =" + strlng + "}" + Environment.NewLine);
                    }
                    break;
                case 2:
                    for (int i = 0; i < DropingAreaPoint.Count; i++)
                    {
                        strlat = DropingAreaPoint[i].Lat.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        strlng = DropingAreaPoint[i].Lng.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
                        StrTxt.Write("{Lat =" + strlat + ", Lng =" + strlng + "}" + Environment.NewLine);
                    }
                    break;
            }
            StrTxt.Close();
        }
        private void DrawPathLoad_Click(object sender, EventArgs e)
        {
            string pathDocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathFile = null;
            switch (cBoxDraw.SelectedIndex)
            {
                case 0:
                    pathFile = pathDocument + "//CakraDirgaUM//CakraDirgaWP.txt";
                    break;
                case 1:
                    pathFile = pathDocument + "//CakraDirgaUM//CakraDirgaBoundary.txt";
                    break;
                case 2:
                     pathFile = pathDocument + "//CakraDirgaUM//CakraDirgaDropArea.txt";
                    break;
            }
            if (File.Exists(pathFile))
            {
                DropingAreaPoint.Clear();
                GMap.NET.PointLatLng LatLngPoint = new GMap.NET.PointLatLng();

                string[] lines = System.IO.File.ReadAllLines(pathFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    string lat = String.Empty;
                    string lng = String.Empty;
                    bool setlng = false;
                    foreach (char c in lines[i])
                    {
                        // Do not use IsDigit as it will include more than the characters 0 through to 9
                        if (!setlng)
                        {
                            if (c >= '0' && c <= '9' || c == '-') lat += c;
                            else if (c == '.') lat += ',';
                            else if (c == ',') setlng = true;
                        }
                        else
                        {
                            if (c >= '0' && c <= '9' || c == '-') lng += c;
                            else if (c == '.') lng += ',';
                        }
                    }
                    LatLngPoint.Lat = double.Parse(lat);
                    LatLngPoint.Lng = double.Parse(lng);
                    switch (cBoxDraw.SelectedIndex)
                    {
                        case 0:
                            VehicleWPPoint.Add(LatLngPoint);
                            break;
                        case 1:
                            BoundaryPoint.Add(LatLngPoint);
                            break;
                        case 2:
                            DropingAreaPoint.Add(LatLngPoint);
                            break;
                    }
                    //Console.WriteLine(DALat.Lat + ", " + DALat.Lng);
                }
            }
        }

        private void MapsPosLoad_Click(object sender, EventArgs e)
        {
            string pathDocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathFile = pathDocument + "//CakraDirgaUM//CakraDirgaMapsPos.txt";
            if (File.Exists(pathFile))
            {
                string[] lines = System.IO.File.ReadAllLines(pathFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    string lat = String.Empty;
                    string lng = String.Empty;
                    bool setlng = false;
                    foreach (char c in lines[i])
                    {
                        // Do not use IsDigit as it will include more than the characters 0 through to 9
                        if (!setlng)
                        {
                            if (c >= '0' && c <= '9' || c == '-') lat += c;
                            else if (c == '.') lat += ',';
                            else if (c == ',') setlng = true;
                        }
                        else
                        {
                            if (c >= '0' && c <= '9' || c == '-') lng += c;
                            else if (c == '.') lng += ',';
                        }
                    }
                    MapCoordinate.Lat = double.Parse(lat);
                    MapCoordinate.Lng = double.Parse(lng);
                }
                Console.WriteLine(MapCoordinate.Lat + ", " + MapCoordinate.Lng);
                gMap.Position = new GMap.NET.PointLatLng(MapCoordinate.Lat, MapCoordinate.Lng);
            }
        }

        private void PBOpenDuration_Scroll(object sender, ScrollEventArgs e)
        {
            PBOpenDurationSecond = PBOpenDuration.Value;
            PBOpenDurationVal.Text = PBOpenDurationSecond.ToString();
        }

        private void RecloseCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RecloseCB.Checked)
                ReclosePBCon = true;
            else
                ReclosePBCon = false;
        }

        private void cBoxDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogPrint("DRAWMODE=" + cBoxDraw.Text + ";");
        }

        private void ResetDroppingMsnBtn_Click(object sender, EventArgs e)
        {
            DropCnt = 0;
            PL1Away = false;
            PL2Away = false;
            ForceServotimer = DateTime.MinValue;
            DetectingServotimer = DateTime.MinValue;
            Just1Debug = false;
            Just2Debug = false;
            Just3Debug = false;
            Just4Debug = false;
            Just5Debug = false;
            Just6Debug = false;
        }

        private void MapsPosSave_Click(object sender, EventArgs e)
        {
            string pathDdocument = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter StrTxt = null;

            if (Directory.Exists(pathDdocument + "//CakraDirgaUM"))
            {
                StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaMapsPos.txt");
            }
            else
            {
                Directory.CreateDirectory(pathDdocument + "//CakraDirgaUM");
                StrTxt = new StreamWriter(pathDdocument + "//CakraDirgaUM//CakraDirgaMapsPos.txt");
            }
            string strlat = MapCoordinate.Lat.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
            string strlng = MapCoordinate.Lng.ToString("0.0000000000000", System.Globalization.CultureInfo.InvariantCulture);
            StrTxt.Write("{Lat =" + strlat + ", Lng =" + strlng + "}" + Environment.NewLine);
            StrTxt.Close();
        }

       

   
        private void VideoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectCam.Text == "Picture Source")
            {
                try
                {
                    get_Frame_();
                }
                catch (Exception ex)
                {
                    LogPrint(ex.Message);
                }
            }
        }

        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {

            _BsourceFrame = (Bitmap)eventArgs.Frame.Clone();
            get_Frame_();
        }
        private void get_Frame_()
        {
            //Insert image into Picuture Box
            if (SelectCam.Text == "Picture Source")
            {
                LoadImage();
                _BsourceFrame = _PictureSource;
            }
            /////////////////////////////////////////////////////////////////////////
            ResizeBilinear filterSize = new ResizeBilinear(256, 192);
            _BsourceFrame = filterSize.Apply(_BsourceFrame);
            _hslFilter.Hue = new IntRange(iHueMin, iHueMax);
            _hslFilter.Saturation = new Range((float)iSatMin / 100, (float)iSatMax / 100);
            _hslFilter.Luminance = new Range((float)iLigMin / 100, (float)iLigMax / 100);
            _HSLcolorFilterImage0 = _hslFilter.Apply(_BsourceFrame);

            _hslFilter1.Hue = new IntRange(iHueMin1, iHueMax1);
            _hslFilter1.Saturation = new Range((float)iSatMin / 100, (float)iSatMax / 100);
            _hslFilter1.Luminance = new Range((float)iLigMin / 100, (float)iLigMax / 100);
            _HSLcolorFilterImage1 = _hslFilter1.Apply(_BsourceFrame);

            _AddfilterImage = new Add(_HSLcolorFilterImage0);
            // apply the filter
            _HSLcolorFilterImage = _AddfilterImage.Apply(_HSLcolorFilterImage1);

            /////////////////////////////////////////////////////////////////////////

            Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            _bitmapGreyImage = _grayscale.Apply(_HSLcolorFilterImage);

            Threshold _threshold = new Threshold(iThreshold);
            _bitmapBinaryImage = _threshold.Apply(_bitmapGreyImage);

            /*

_FillHolefilter.MaxHoleHeight = 20;
_FillHolefilter.MaxHoleWidth = 20;
_FillHolefilter.CoupledSizeFiltering = false;
_bitmapBinaryImage = _FillHolefilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);

_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
_bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
*/
            _blobfilter.CoupledSizeFiltering = true;
            _blobfilter.MinWidth = iBlobMinFilter;
            _blobfilter.MinHeight = iBlobMinFilter;
            _blobfilter.MaxWidth = iBlobMaxFilter;
            _blobfilter.MaxHeight = iBlobMaxFilter;
            _blobfilterImage = _blobfilter.Apply(_bitmapBinaryImage);
            /*
            _overlayImage = _blobfilter.Apply(_bitmapBinaryImage);
            Invert _invFilter = new Invert();
            _overlayImage = _invFilter.Apply(_overlayImage);
            Intersect _inserctfilter = new Intersect(_overlayImage);
            _InserctfilterImage = _inserctfilter.Apply(_blobfilterImage);
            */


            switch (VideoType.SelectedIndex)
            {
                case 0:
                    VideoStream.Image = BlobDetection(_BsourceFrame);
                    break;
                case 1:
                    VideoStream.Image = _HSLcolorFilterImage;
                    break;
                case 2:
                    VideoStream.Image = _bitmapGreyImage;
                    break;
                case 3:
                    VideoStream.Image = _bitmapBinaryImage;
                    break;
                case 4:
                    VideoStream.Image = _blobfilterImage;
                    break;
                case 5:
                    VideoStream.Image = _HSLcolorFilterImage0;
                    break;
                case 6:
                    VideoStream.Image = _HSLcolorFilterImage1;
                    break;
            }
        }

        Bitmap BlobDetection(Bitmap _bitmapSourceImage)
        {
            Graphics _g;
            int widthImg;
            int heightImg;
            if (SelectCam.Text != "Picture Source")
            {
                _g = Graphics.FromImage(_bitmapSourceImage);
                widthImg = _bitmapSourceImage.Width;
                heightImg = _bitmapSourceImage.Height;
            }
            else if (!CamConnected)
            {
                _g = Graphics.FromImage(_PictureSource);
                widthImg = _PictureSource.Width;
                heightImg = _PictureSource.Height;
            }
            else { return null; }

            var fontFamily = new FontFamily("Microsoft Sans Serif");
            var font = new Font(fontFamily, (int)(32 * widthImg/640), FontStyle.Regular, GraphicsUnit.Pixel);
            var fontB = new Font(fontFamily, (int)(32 * widthImg / 640), FontStyle.Bold, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));


            BlobCounter _blobCounter = new BlobCounter();

            //Configure Filter
            _blobCounter.MinWidth = 5;
            _blobCounter.MinHeight = 5;
            _blobCounter.FilterBlobs = true;
            
            _blobCounter.ProcessImage(_blobfilterImage);

            Rectangle[] rects = _blobCounter.GetObjectsRectangles();


            if (rects.Length <= 0)
            {
                TargetDetected = false;
            }
            else
            {
                foreach (Rectangle recs in rects)
                {
                    int maxAreaIndex = 0;
                    for (int i = 0; i < rects.Length; i++)
                    {
                        if ((rects[i].Width * rects[i].Height) >= (rects[maxAreaIndex].Width * rects[maxAreaIndex].Height))
                            maxAreaIndex = i;
                    }
                    Rectangle objectRect = rects[maxAreaIndex];

                    int _x = (int)objectRect.X;
                    int _y = (int)objectRect.Y;
                    int centerX = objectRect.Width / 2 + _x;
                    int centerY = objectRect.Height / 2 + _y;

                    TargetDetected = true;
                    TargetDistance = FindDistance(objectRect.Width);

                    if (!TargetAvaliable)
                    {
                        LatitudeTarget = LatitudePlane;
                        LongitudeTarget = LongitudePlane;

                        TargetAvaliable = true;
                    }

                    _g.FillEllipse(Brushes.Cyan, centerX, centerY, (int)(8 * widthImg / 640), (int)(8 * widthImg / 640));

                    using (Pen pen = new Pen(Color.Cyan, (int)(6 * widthImg / 640)))
                    {
                        _g.DrawRectangle(pen, objectRect);
                    }
                    _g.DrawString("Target", font, Brushes.White, _x, _y - (int)(37 * widthImg / 640));
                }
            }
           
            if (_DropingScope)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    _g.DrawLine(pen, widthImg / 2, 0, widthImg / 2, heightImg);
                    _g.DrawLine(pen, 0, heightImg / 2, widthImg, heightImg / 2);
                    _g.DrawEllipse(pen, (widthImg - 240) / 2, (heightImg - 240) / 2, 240, 240);
                }
            }
            
            _g.DrawString("Detected: " + TargetDetected, fontB, solidBrush, new PointF(5, 4));
            _g.DrawString("Range\t  : " + (TargetDistance).ToString("0.00") + "m", fontB, solidBrush, new PointF(5, (int)(48* widthImg / 640)));
            //_g.DrawString("Rect Detected: " + rects.Length, fontB, solidBrush, new PointF(5, 40));
             _g.DrawString("FPS:"+ fpsDebug, fontB, solidBrush,new PointF((int)(380 * widthImg / 480), 4));
            ResizeBilinear filterSize = new ResizeBilinear(640, 480);
            _bitmapSourceImage = filterSize.Apply(_bitmapSourceImage);

            _SaveImage = _bitmapSourceImage;
            return _bitmapSourceImage;
        }

        private double FindDistance(int _pixel)
        {
            ///
            /// distance(D): distance of object from the camera
            /// _focalLength(F): focal length of camera
            /// _pixel(P): apparent width in pixel
            /// _ObjectWidth(W): width of object
            /// 
            /// F = (P*D)/W
            ///     -> D = (W*F)/P
            ///
            double _distance;
            double _ObjectWidth = 0.18, _focalLength = 604.8;

            //_distance = Convert.ToInt16((_ObjectWidth * _focalLength) / _pixel);
            _distance = (_ObjectWidth * _focalLength) / _pixel;

            return _distance;
        }
        private void videoSource_Error(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            LogPrint(eventArgs.Description.ToString());
        }
        ////////////////////////MAV LINK//////////////////////////////
        void Mv_PacketReceived(object sender, MavLink.MavlinkPacket e)
        {
            uint x = Mv.PacketsReceived;
            Systemid = e.SystemId;
            Componentid = e.ComponentId;
            Sequence = e.SequenceNumber;
            MavlinkMessage m = e.Message;
            if (m.GetType() == Hb.GetType())
                Hb = (Msg_heartbeat)e.Message;
            if (m.GetType() == Ss.GetType())
                Ss = (Msg_sys_status)e.Message;
            if (m.GetType() == Ps.GetType())
                Ps = (Msg_power_status)e.Message;
            if (m.GetType() == At.GetType())
                At = (Msg_attitude)e.Message;
            if (m.GetType() == Gps.GetType())
                Gps = (Msg_gps_raw_int)e.Message;
            if (m.GetType() == Vfr.GetType())
                Vfr = (Msg_vfr_hud)e.Message;
            if (m.GetType() == Hglat.GetType())
                Hglat = (Msg_high_latency2)e.Message;
            if (m.GetType() == Alti.GetType())
                Alti = (Msg_altitude)e.Message;
            if (m.GetType() == Rp.GetType())
            {
                Rp = (Msg_raw_pressure)e.Message;
            }
            if (m.GetType() == Sp.GetType())
            {
                Sp = (Msg_scaled_pressure)e.Message;
                Prs = (int)(Sp.press_abs * 1000f);
                Tep = Sp.temperature;
                Dif = (int)(Sp.press_diff * 1000f);
                /*
                 * Special log of Barometric data to the D drive
                 * Can be disable if not needed
                 */
                ut.LogPressure(Sp);
            }

            if (m.GetType() == St.GetType())
            {
                St = (Msg_statustext)e.Message;
            }
            if (m.GetType() == Mc.GetType())
            {
                Mc = (Msg_mission_count)e.Message;
                MI = 0;
                GetMissionValues.RunWorkerAsync();
            }
            /*if (m.GetType() == Mi[0].GetType())
            {
                Mi[MI++] = (Msg_mission_item)e.Message;
                if (MI >= Mc.count)
                    MI = -1;
            }*/
            if (m.GetType() == ScImu.GetType())
            {
                ScImu = (Msg_scaled_imu2)e.Message;
            }

            if (m.GetType() == sor.GetType())

                sor = (Msg_servo_output_raw)e.Message;

            if (x > 0)
            {
                UpdateData();
            }
        }
        private void RecvMission(object sender, DoWorkEventArgs e)
        {
            if (!serialPort1.IsOpen)
                return;
            int Pr = -1;

            while (MI >= 0)
            {
                if ((Pr != MI) && (MI >= 0))
                {
                    Msg_mission_request Mr = new Msg_mission_request();
                    Mr.seq = (byte)MI;
                    Mr.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                    Mr.target_system = (byte)Systemid;
                    SendPacket(Mr);
                    Pr = MI;
                }
            }
        }

        private void SetServo(int ServoID, int MinPWMSer, int MaxPWMSer,bool SetConServo)
        {
            if ((ForceServotimer.AddMilliseconds(100) < DateTime.Now))
            {

                try
                {
                    Msg_command_long m_cmd = new Msg_command_long();
                    m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                    m_cmd.target_system = (byte)Systemid;
                    m_cmd.command = (ushort)MAV_CMD.MAV_CMD_DO_SET_SERVO;
                    m_cmd.param1 = (byte)ServoID;
                    if (SetConServo)
                    {
                        m_cmd.param2 = (ushort)MinPWMSer;
                    }
                    else
                    {
                        m_cmd.param2 = (ushort)MaxPWMSer;
                    }

                    SendPacket(m_cmd);
                }
                catch (Exception ex)
                {
                    LogPrint(ex.Message);
                }
                ForceServotimer = DateTime.Now;
            }
        }

        private void SendPacket(MavlinkMessage m)
        {
            if (!SerialConected)
                return;
            try
            {
                MavlinkPacket p = new MavlinkPacket();
                p.Message = m;
                p.SequenceNumber = (byte)Sequence;
                p.SystemId = 255;
                p.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
                byte[] b = Mv.Send(p);
                serialPort1.Write(b, 0, b.Length);
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }

        private void Data(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int x = serialPort1.BytesToRead;
                byte[] b = new byte[x];
                for (int i = 0; i < x; i++)
                    b[i] = (byte)serialPort1.ReadByte();
                Mv.ParseBytes(b);
            }
            catch (Exception ex)
            {
                LogPrint(ex.Message);
            }
        }

        private void CalibrateLevelBtn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                return;
            try
            {
                Msg_command_long m_cmd = new Msg_command_long();
                m_cmd.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION;

                m_cmd.param1 = 0;
                m_cmd.param2 = 0;
                m_cmd.param3 = 0;
                m_cmd.param4 = 0;
                m_cmd.param5 = 2;
                m_cmd.param6 = 0;
                m_cmd.param7 = 0;

                SendPacket(m_cmd);

                updateLevelStatus=true;

            }
            catch
            {
                CalLevelLabel.Text = "Level Calibrate Failed";
            }
        }

        private void CalibrateAccelBtn_Click(object sender, EventArgs e)
        {
           /* if (_incalibrate)
            {
                AccelCalcount++;
                try
                {
                    Msg_command_ack ackm = new Msg_command_ack;
                    ackm.command = 1;
                    ackm.result = (byte)AccelCalcount;
                    
                    MainV2.comPort.sendPacket(new MAVLink.mavlink_command_ack_t { command = 1, result = count },
                        MainV2.comPort.sysidcurrent, MainV2.comPort.compidcurrent);
                    SendPacket(ackm);

                }
                catch
                {
                    CalLevelLabel.Text = "Accel Calibrate Failed";
                    return;
                }

                return;
            }

            try
            {
                AccelCalcount = 0;

                Msg_command_long m_cmd = new Msg_command_long();

                m_cmd.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;
                m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                m_cmd.command = (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION;

                m_cmd.param1 = 0;
                m_cmd.param2 = 0;
                m_cmd.param3 = 0;
                m_cmd.param4 = 0;
                m_cmd.param5 = 2;
                m_cmd.param6 = 0;
                m_cmd.param7 = 0;

                _incalibrate = true;

                CalAccelLabel.Text = "Level Calibrate Completed";

            }
            catch
            {
                _incalibrate = false;
                CalLevelLabel.Text = "Accel Calibrate Failed";

            }*/
        }

        private void EngineStart1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                return;

            Msg_command_long m_cmd = new Msg_command_long();
            m_cmd.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;
            m_cmd.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
            m_cmd.command = (ushort)MAV_CMD.MAV_CMD_COMPONENT_ARM_DISARM;

            if (EngineStartCon)
            {
                m_cmd.param1 = 0;
                byteEngineStartCon = 0x00;
            }
            else
            {
                m_cmd.param1 = 1;
               byteEngineStartCon = 0xFF;
            }
            m_cmd.param2 = (ushort)0;

            SendPacket(m_cmd);
        }
        private void ForceServo1_Click(object sender, EventArgs e)
        {

                if (ServoPL1RC < ServoThreshold)
                {
                    SetServo(5, 1100, 1900, false);
                }
                else
                {
                    SetServo(5, 1100, 1900, true);
                }

        }
        private void ForceServo2_Click(object sender, EventArgs e)
        {
            if ((ForceServotimer.AddMilliseconds(100) < DateTime.Now))
            {
                if (ServoPL2RC < ServoThreshold)
                    SetServo(8, 1100, 1900, false);
                else
                {
                    SetServo(8, 1100, 1900, true);
                }
                ForceServotimer = DateTime.Now;
            }
        }

    ///////////////////////THREAD///////////////////////

    static void Thread1()
        {
            Console.WriteLine("Thread1 Started using " + Thread.CurrentThread.Name);
            while (true)
            {
                while (gyrovar != null)
                {
                    Yaw = At.yaw > 0 ? (float)(At.yaw * 180 / 3.1415926) : (float)(360 + (At.yaw * 180 / 3.1415926));
                    Pitch = At.pitch > 0 ? (float)(At.pitch * 180 / 3.1415926) : (float)(360 + (At.pitch * 180 / 3.1415926));
                    Roll = At.roll > 0 ? (float)(360 - At.roll * 180 / 3.1415926) : (float)((-At.roll * 180 / 3.1415926));
                    gyrovar.pitch = Pitch;
                    gyrovar.roll = Roll;
                    gyrovar.yaw = Yaw;
                }
            }
        }

        static void Thread2()
        {
            Console.WriteLine("Thread2 Started using " + Thread.CurrentThread.Name);

            while (true)
            {

                if (_CaptureDevice != null)
                    fpsCam = _CaptureDevice.FramesReceived;
                if (_FileVideo != null)
                    fpsVid = _FileVideo.FramesReceived;

                Thread.Sleep(1000);
            }
        }


        /*static void Thread3()
        {
           // ResizeBilinear filterSize = new ResizeBilinear(640, 480);
            // apply the filter
            Console.WriteLine("Thread3 Started using " + Thread.CurrentThread.Name);
            while (true)
            {
                ///////////////////////////HSL Filter///////////////////////////////////////
                _hslFilter.Hue = new IntRange(iHueMin, iHueMax);
                _hslFilter.Saturation = new Range((float)iSatMin / 100, (float)iSatMax / 100);
                _hslFilter.Luminance = new Range((float)iLigMin / 100, (float)iLigMax / 100);
                _HSLcolorFilterImage0 = _hslFilter.Apply(_BsourceFrame);
                  _HSLcolorFilterImage0PostProcess = _HSLcolorFilterImage0;
                // _HSLcolorFilterImage0 = filterSize.Apply(_HSLcolorFilterImage0);
                /////
                  _hslFilter1.Hue = new IntRange(iHueMin1, iHueMax1);
                  _hslFilter1.Saturation = new Range((float)iSatMin / 100, (float)iSatMax / 100);
                   _hslFilter1.Luminance = new Range((float)iLigMin / 100, (float)iLigMax / 100);
                   _HSLcolorFilterImage1 = _hslFilter1.Apply(_BsourceFrame);
                _HSLcolorFilterImage1PostProcess = _HSLcolorFilterImage1;
                //_HSLcolorFilterImage1 = filterSize.Apply(_HSLcolorFilterImage1);

               

                // apply the filter
                 _AddfilterImage = new Add(_HSLcolorFilterImage0);
                 _HSLcolorFilterImage = new Bitmap(_AddfilterImage.Apply(_HSLcolorFilterImage1));
                _HSLcolorFilterImagePostProcess = new Bitmap( _HSLcolorFilterImage);

               
                /////////////////////////Gray Scale Filter///////////////////////////////////////////
                Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
                _bitmapGreyImage = _grayscale.Apply(_HSLcolorFilterImagePostProcess);

                // _BsourceFramePostProcess = _BsourceFrame;
                /*

                /////////////////////////////Blur Filter////////////////////////////////////////

                Threshold _threshold = new Threshold(iThreshold);
                //if (_blurFlag == true)
                _bitmapBinaryImage = _threshold.Apply(_bitmapGreyImage);
                // else
                //    _bitmapBinaryImage = _threshold.Apply(_bitmapGreyImage);

                /////////////////////////////Blop Filter////////////////////////////////////////

                _FillHolefilter.MaxHoleHeight = 20;
                _FillHolefilter.MaxHoleWidth = 20;
                _FillHolefilter.CoupledSizeFiltering = false;
                _bitmapBinaryImage = _FillHolefilter.Apply(_bitmapBinaryImage);

                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);

                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _erosionfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);
                _bitmapBinaryImage = _dilatfilter.Apply(_bitmapBinaryImage);

                _blobfilter.CoupledSizeFiltering = true;
                _blobfilter.MinWidth = iBlobMinFilter;
                _blobfilter.MinHeight = iBlobMinFilter;
                _blobfilterImage = _blobfilter.Apply(_bitmapBinaryImage);
                
            }
        }*/
        ///////////////////////DEBUG///////////////////////
    }
}

