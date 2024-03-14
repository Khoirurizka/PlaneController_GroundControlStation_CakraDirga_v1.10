using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Plane_Controller
{
    struct Coordinates2D
    {
        public float x;
        public float y;
        public Coordinates2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class GyroUI 
    {
        PointF[] Triangle = new PointF[3];
        PointF[] Square = new PointF[4];
        PointF[] InvV = new PointF[6];

        public void DrawBackground(Graphics g, PointF center, float transx, float transy, PointF rotatepoint, float rollVal, float pitchVal, StringFormat str)
        {
            SolidBrush solidBrush;
            solidBrush = new SolidBrush(Color.FromArgb(255, 10, 147, 147));

            int DistScale = 10;
            float Transpitch = DistScale * 2 * ((pitchVal % 360) / 10);
            double rollValrad = rollVal * Math.PI / 180;


            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(rollVal, rotatepoint, MatrixOrder.Append);
            matrix.Translate(center.X + transx - Transpitch * (float)(Math.Sin(rollValrad)), center.Y - transy + Transpitch * (float)(Math.Cos(rollValrad)), MatrixOrder.Append);
            g.Transform = matrix;
            for (int i = -2; i < 4; i++)
            {
                if (Math.Abs(i % 2) == 1)
                {
                    g.FillRectangle(Brushes.LightBlue, -250, -(36 * DistScale) * i, 500, 36 * DistScale);
                }
                else
                {
                    g.FillRectangle(solidBrush, -250, -(36 * DistScale) * i, 500, 36 * DistScale);
                }
            }
        }
        public void Needle(Graphics g, PointF center, float transx, float transy, PointF rotatepoint, float rotateAngle, StringFormat str)
        {
            var YawNbrush = new SolidBrush(Color.FromArgb(120, 255, 0, 0));//150, 34, 0, 0

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(rotateAngle, rotatepoint, MatrixOrder.Append);
            matrix.Translate(center.X + transx, center.Y - transy, MatrixOrder.Append);

            g.Transform = matrix;
            g.FillRectangle(Brushes.Red, -120, -1, 40, 2);
            g.FillRectangle(Brushes.Red, 80, -1, 40, 2);
            Triangle[0].X = -10;
            Triangle[0].Y = -80;
            Triangle[1].X = 0;
            Triangle[1].Y = -90;
            Triangle[2].X = 10;
            Triangle[2].Y = -80;
            g.FillPolygon(Brushes.Red, Triangle);
            InvV[0].X = -35;
            InvV[0].Y = 15;
            InvV[1].X = 0;
            InvV[1].Y = 0;
            InvV[2].X = 35;
            InvV[2].Y = 15;
            InvV[3].X = 35;
            InvV[3].Y = 17;
            InvV[4].X = -0;
            InvV[4].Y = 2;
            InvV[5].X = -35;
            InvV[5].Y = 17;
            g.FillPolygon(Brushes.Red, InvV);

            g.FillRectangle(YawNbrush, -10, -150, 20, 20);

        }
        public void PitchScale(Graphics g, PointF center, float x, float y, PointF rotatepoint, float rollVal, float pitchVal, StringFormat str)
        {
            int DistScale = 10;
            int DisplayScale = 7;
            double rollValrad = rollVal * Math.PI / 180;

            pitchVal *= 2;// untuk kalibrasi skala ketika antara skala +-5 nilai skala utama
            Matrix matrix = new Matrix();

            g.ResetTransform();
            matrix.RotateAt(rollVal, rotatepoint, MatrixOrder.Append);
            matrix.Translate(center.X + x - ((pitchVal / 10) * DistScale * (float)(Math.Sin(rollValrad))), center.Y - y + ((pitchVal / 10) * DistScale * (float)(Math.Cos(rollValrad))), MatrixOrder.Append);
            g.Transform = matrix;

            int transcount = (int)(pitchVal / 10);

            for (int i = -DisplayScale / 2 + transcount; i < DisplayScale / 2 + 1 + transcount; i++)
            {
                var fontFamily = new FontFamily("Times New Roman");
                var font = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);
                var solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

                if (i % 2 == 0)
                {
                    g.FillRectangle(Brushes.Black, -35, -1 - (DistScale * i), 70, 2);// Display scale
                    /// Display scale value
                    if (i >= 0)
                    {
                        g.DrawString((((i / 2) * 10) % 360).ToString(), font, solidBrush, -65, -8 - (DistScale * i));
                        g.DrawString((((i / 2) * 10) % 360).ToString(), font, solidBrush, 40, -8 - (DistScale * i));
                    }
                    else
                    {
                        g.DrawString(((360 + ((i / 2) * 10) % 360)).ToString(), font, solidBrush, -65, -8 - (DistScale * i));
                        g.DrawString(((360 + ((i / 2) * 10) % 360)).ToString(), font, solidBrush, 40, -8 - (DistScale * i));
                    }
                }
                else
                {
                    g.FillRectangle(Brushes.Black, -20, -1 - (DistScale * i), 40, 2); // Display half scale
                }
            }
        }

        public void RollScale(Graphics g, PointF center, float x, float y, PointF rotatepoint, float angle, float rollVal, StringFormat str)
        {
            int DisplayScale = 25;
            Rectangle rect = new Rectangle();
            SolidBrush solidBrush;
            //Pen solidPens = new Pen(Color.FromArgb(255, 255, 255, 255));

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(angle, rotatepoint, MatrixOrder.Append);
            matrix.Translate(center.X + x, center.Y - y, MatrixOrder.Append);
            g.Transform = matrix;

            solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

            //RollMeter
            int transcount = (int)(rollVal / 5);
            for (int i = -DisplayScale / 2 - transcount; i < DisplayScale / 2 + 1 - transcount; i++)
            {

                if (i % 2 == 0)
                {
                    if (i > 0)
                        DrawRollMeterOnArc(g, 0, -20, -75, 10, 5 * i + rollVal, (i / 2) * 10, true);
                    else
                        DrawRollMeterOnArc(g, 0, -20, -75, 10, 5 * i + rollVal, ((i / 2) * 10)+360, true);

                }
                else
                {
                    DrawRollMeterOnArc(g, 0, -20, -75, 7, 5 * i + rollVal, (i / 2) * 10, false);

                }
            }

            ////
            //Foreground
            ///

            Pen _pen = new Pen(Brushes.Black, 3);

            rect = new Rectangle(-95 - (3 / 2), -95 - (3 / 2), 190 + 3, 190 + 3);
                g.DrawArc(_pen, rect, -20, -140);
        }

        public void YawScale(Graphics g, PointF center, float x, float y, float YawVal, StringFormat str)
        {
            int DistScale = 20;
            int DisplayScale = 21;
            SolidBrush solidBrush;

            YawVal *= 2;// untuk kalibrasi skala ketika antara skala +-2.5 nilai skala utama
            Matrix matrix = new Matrix();

            g.ResetTransform();
            matrix.Translate(center.X + x - ((YawVal / 10) * DistScale), center.Y - y, MatrixOrder.Append);
            g.Transform = matrix;

            ////
            //Background
            ///
            g.FillRectangle(Brushes.Black, -150 + ((YawVal / 10) * DistScale), -1, 300, 3);
            solidBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));
            g.FillRectangle(solidBrush, -150 + ((YawVal / 10) * DistScale), 20, 300, 1);
            solidBrush = new SolidBrush(Color.FromArgb(120, 255, 255, 255));
            g.FillRectangle(solidBrush, -150 + ((YawVal / 10) * DistScale), 0, 300, 20);

            int transcount = (int)(YawVal / 10);
            for (int i = -DisplayScale / 2 + transcount; i < DisplayScale / 2 + 1 + transcount; i++)
            {
                var fontFamily = new FontFamily("Times New Roman");
                var font = new Font(fontFamily, 10, FontStyle.Bold, GraphicsUnit.Pixel);
                solidBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));

                if (i % 2 == 0)
                {
                    g.FillRectangle(Brushes.Black, -1 + (DistScale * i), 0, 2, 5);// Display scale
                    /// Display scale value
                    if (i >= 0)
                    {
                        if (((i / 2) * 10) % 360 == 0)
                        {
                            g.DrawString("N", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 90 == 1 && (((i / 2) * 10) % 360) % 90 == 0)
                        {
                            g.DrawString("E", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 180 == 1 && (((i / 2) * 10) % 360) % 180 == 0)
                        {
                            g.DrawString("S", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 270 == 1 && (((i / 2) * 10) % 360) % 270 == 0)
                        {
                            g.DrawString("W", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else
                        {
                            g.DrawString((((i / 2) * 10) % 360).ToString(), font, solidBrush, -6 + (DistScale * i), 6);
                        }
                    }
                    else
                    {
                        if (((i / 2) * 10) % 360 == 0)
                        {
                            g.DrawString("N", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 90 == -1 && (((i / 2) * 10) % 360) % 90 == 0)
                        {
                            g.DrawString("W", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 180 == -1 && (((i / 2) * 10) % 360) % 180 == 0)
                        {
                            g.DrawString("S", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else if ((((i / 2) * 10) % 360) / 270 == -1 && (((i / 2) * 10) % 360) % 270 == 0)
                        {
                            g.DrawString("E", font, solidBrush, -6 + (DistScale * i), 6);

                        }
                        else
                        {
                            g.DrawString((360 + ((i / 2) * 10) % 360).ToString(), font, solidBrush, -6 + (DistScale * i), 6);//- ((YawVal / 10) * DistScale)
                        }
                    }
                }
                else
                {
                    g.FillRectangle(Brushes.Black, -1 + (DistScale * i), 0, 2, 3); // Display half scale
                }
            }
        }

        public void DrawRollMeterOnArc(Graphics g, float x, float y, float r,float l, float angle,float Val,bool showVal)
        {
            double anglerad = angle * Math.PI / 180;

            PointF rotatepoint = new PointF(0, 0);
            PointF Fontpoint = new PointF(-5, -l + y + r-15);
            PointF rotateFontpoint = new PointF(-10, 0);


            Square[0].X = -1 - x;
            Square[0].Y = -l+y + r;
            Square[1].X = 1-x;
            Square[1].Y = -l + y + r;
            Square[2].X = 1-x;
            Square[2].Y = 0 + y + r;
            Square[3].X = -1 + x;
            Square[3].Y = 0 + y + r;

            ///Transform///
            Square[0] = RotatePoint(Square[0], anglerad, rotatepoint);
            Square[1] = RotatePoint(Square[1], anglerad, rotatepoint);
            Square[2] = RotatePoint(Square[2], anglerad, rotatepoint);
            Square[3] = RotatePoint(Square[3], anglerad, rotatepoint);

            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 10, FontStyle.Bold, GraphicsUnit.Pixel);
            Fontpoint = RotatePoint(Fontpoint,anglerad, rotateFontpoint);

            if (showVal)
            {
                g.FillPolygon(Brushes.Black, Square);

                if (Val > 0)
                    g.DrawString((Val % 360).ToString(), font, Brushes.Black, Fontpoint.X, Fontpoint.Y);
                else
                    g.DrawString(((360 + Val) % 360).ToString(), font, Brushes.Black, Fontpoint.X, Fontpoint.Y);
            }
            else
            {
                g.FillPolygon(Brushes.Black, Square);
            }
        }
        PointF RotatePoint(PointF pointf, double anglerad,PointF rotatepoint)
        {
            PointF temp = new PointF(0, 0);
            temp.X = (pointf.X - rotatepoint.X) * (float)(Math.Cos(anglerad)) - (pointf.Y - rotatepoint.Y) * (float)(Math.Sin(anglerad))+ rotatepoint.X;
            temp.Y = (pointf.X - rotatepoint.X) * (float)(Math.Sin(anglerad)) + (pointf.Y - rotatepoint.Y) * (float)(Math.Cos(anglerad))+ rotatepoint.Y;
            return temp;
        }
        PointF TranslatePoint(PointF pointf, float x, float y)
        {
            PointF temp = new PointF(0, 0);
            temp.X = pointf.X +x;
            temp.Y = pointf.Y +y;
            return temp;
        }
    }
}
