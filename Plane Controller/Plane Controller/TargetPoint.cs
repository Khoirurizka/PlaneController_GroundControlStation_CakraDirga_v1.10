using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using GMap.NET;

namespace Plane_Controller
{
    class TargetPoint : GMap.NET.WindowsForms.GMapMarker
    {
        private PointLatLng point_;
        private int size_;

        public PointLatLng Point
        {
            get
            {
                return point_;
            }
            set
            {
                point_ = value;
            }
        }

        public TargetPoint(PointLatLng pos, int Size) :base(pos)
        {
            point_ = pos;
            size_ = Size;
        }
        public override void OnRender(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush solidBrush = new SolidBrush(Color.FromArgb(255, 200, 0, 0));
            Pen _pen = new Pen(solidBrush,2);
            g.FillEllipse(solidBrush, LocalPosition.X- size_/2, LocalPosition.Y- size_/2, size_, size_);
            g.DrawEllipse(_pen, LocalPosition.X-(size_ + 8)/2, LocalPosition.Y - (size_ + 8) / 2, size_ + 8, size_ + 8);
        }
    }
}
