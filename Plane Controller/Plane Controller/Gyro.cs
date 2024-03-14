using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Plane_Controller
{

    public partial class Gyro : Form
    {

        PointF CenterUI = new PointF(150, 150);
        GyroUI GyroDrawer = new GyroUI();

        public float pitch;
        public float roll;
        public float yaw;

        //Transform
        private PointF RotatePoint = new PointF(0, 0);
        public Gyro()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Gyro_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            StringFormat str = new StringFormat();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RotatePoint.X = 0;
            RotatePoint.Y = 0;
            GyroDrawer.DrawBackground(g, CenterUI, 0, 0, RotatePoint, roll, pitch, str);
            RotatePoint.X = 0;
            RotatePoint.Y = 0;
            GyroDrawer.PitchScale(g, CenterUI, 0, 0, RotatePoint, roll, pitch, str);
            GyroDrawer.YawScale(g, CenterUI, 0, 150, yaw, str);
            RotatePoint.X = 0;
            RotatePoint.Y = 0;
            GyroDrawer.Needle(g, CenterUI, 0, 0, RotatePoint, 0, str);
            RotatePoint.X = 0;
            RotatePoint.Y = 0;
            GyroDrawer.RollScale(g, CenterUI, 0, 0, RotatePoint, 0, roll, str);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
