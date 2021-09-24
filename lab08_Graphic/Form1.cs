using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab08_Graphic
{
    public partial class Form1 : Form
    { 

        public struct ResultPoint
        {
            public override string ToString()
            {
                if(x4 != null & y4 != null & y3 != null & x3 != null)
                {
                    return $"({Math.Round((double) x3, 2)}, {Math.Round((double)y3, 2)})" +
                        $" ({Math.Round((double)x4, 2)}, + {Math.Round((double)y4, 2)})";
                }
                else if (y3 != null & x3 != null)
                {
                    return $"({Math.Round((double)x3, 2)}, {Math.Round((double)y3, 2)})";
                }
                return "";
            }

            public double? x3 { get; set; }
            public double? y3 { get; set; }
            public double? x4 { get; set; }
            public double? y4 { get; set; }
        }

        //рисуем окружность
        public static void PrintCircle(Graphics graphics, Pen pen, int x0, int y0, int r, int count)
        {

            double da = 2 * Math.PI / count;
   
            List<PointF> vector = new List<PointF>();
            for (double i = 0; i <= 2 * Math.PI; i += da)
            {
                double x = r * Math.Cos(i) + x0;
                double y = r * Math.Sin(i) + y0;
                vector.Add(new PointF((float)x, (float)y));
            }

            graphics.DrawLines(pen, vector.ToArray());
        }

        public static ResultPoint CalcIntersection(int x1, int y1, int r1, int x2,int y2, int r2)
        {
            ResultPoint resultPoint = new ResultPoint();
            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double t = 0.00001;
            if((d > r1 + r2) | (d < Math.Abs(r1 - r2)))
            {
                
                //точек пересечения нет
            }
            else if (Math.Abs(d - (r1 + r2)) < t)
            {
                //окружности касаются в точке
                double x3 = (x1 + x2) / 2;
                double y3 = (y1 + y2) / 2;
                
                resultPoint.x3 = x3;
                resultPoint.y3 = y3;
            }
            else
            {
                double b = (Math.Pow(r2, 2) - Math.Pow(r1, 2) + Math.Pow(d, 2)) /(2 * d);
                double a = d - b;
                double h = Math.Sqrt(Math.Pow(r2, 2) - Math.Pow(b, 2));
                double x = x1 + (x2 - x1) / (d / a);
                double y = y1 + (y2 - y1) / (d / a);
                //Точки пересечения
                double x3 = x - (y - y2) * h / b;
                double y3 = y + (x - x2) * h / b;
                double x4 = x + (y - y2) * h / b;
                double y4 = y - (x - x2) * h / b;

                
                resultPoint.x3 = x3;
                resultPoint.x4 = x4;
                resultPoint.y3 = y3;
                resultPoint.y4 = y4;
                

            }
            return resultPoint;


        }




        int width { get; set; }
        int height { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
            int x1 = int.Parse(textBoxX1.Text) * 10;
            int y1 = int.Parse(textBoxY1.Text) * 10;
            int r1 = int.Parse(textBoxR1.Text) * 10;
                                              
            int x2 = int.Parse(textBoxX2.Text) * 10;
            int y2 = int.Parse(textBoxY2.Text) * 10;
            int r2 = int.Parse(textBoxR2.Text) * 10;
            


            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(BackColor);
            graphics.PageUnit = GraphicsUnit.Millimeter;
            //x 724 //y 259
            int margin = 30;
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            Pen pen = new Pen(Color.Black, 0.5f);

            //рисуем сетку
            for (int i = 0; i <= width; i += 10)
            {
                Point point1 = new Point(i, 0);
                Point point2 = new Point(i, height);
                graphics.DrawLine(pen, point1, point2);
            }

            for (int i = 0; i <= height; i += 10)
            {
                Point point1 = new Point(0, i);
                Point point2 = new Point(width, i);
                graphics.DrawLine(pen, point1, point2);
            }



            Pen redPen = new Pen(Color.IndianRed, 1f);
            Pen pinkPen = new Pen(Color.LightPink, 1f);

            PrintCircle(graphics, redPen, x1, y1, r1, 20);

            PrintCircle(graphics, pinkPen, x2, y2, r2, 20);

            //  graphics.DrawEllipse(pen ,new Rectangle(new Point(0, 0), new Size(20, 20)));


            ResultPoint resultPoint = new ResultPoint();
            
            
            resultPoint = CalcIntersection(x1 / 10, y1 / 10, r1 / 10, x2 / 10, y2 / 10, r2 / 10);
            Pen pointsPen = new Pen(Color.LightBlue, 0.2f);
                
            if (resultPoint.x3 != null & resultPoint.y3 != null & resultPoint.x4 != null & resultPoint.y4 != null)
            {
                graphics.DrawEllipse(pointsPen, new RectangleF((float)(resultPoint.x3 * 10 - 1f), (float)(resultPoint.y3 * 10 - 1f), 2f, 2f));
                graphics.DrawEllipse(pointsPen, new RectangleF((float)(resultPoint.x4 * 10 - 1f), (float)(resultPoint.y4 * 10 - 1f), 2f, 2f));
                labelAnswer.Text = "точки пересечения -  " + resultPoint.ToString();
            }
            else if(resultPoint.x3 != null & resultPoint.y3 != null)
            {
                graphics.DrawEllipse(pointsPen, new RectangleF((float)(resultPoint.x3 * 10 - 1f), (float)(resultPoint.y3 * 10 - 1f), 2f, 2f));
                labelAnswer.Text = "точка пересечения - " + resultPoint.ToString();
            }
            else
            {
                labelAnswer.Text = "Нет точек пересечения";
                //нет точек пересечения
            }


            //graphics.DrawLine(pen, new PointF((float)resultPoint.x3 * 10, (float)resultPoint.y3 * 10),
            //                       new PointF((float)resultPoint.x4 * 10, (float)resultPoint.y4 * 10));


            





        }
    }
}
