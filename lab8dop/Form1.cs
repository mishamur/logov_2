using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8dop
{
    public partial class Form1 : Form
    {

        public string bet;
        public Form1()
        {
            InitializeComponent();
            bet = this.radioButtonRedHorse.Name;
        }


        //запускаем лошадей
        public static void RunHorse(string bet,Graphics graphics, Pen pen, int x0, int y0, int r, int count, int a, int b)
        {
            Pen redPen = new Pen(Color.Red, 1f);
            Pen greenPen = new Pen(Color.Green, 1f);
            Pen bluePen = new Pen(Color.Blue, 1f);

            Pen blackPen = new Pen(Color.Black, 2f);
            double da = 2 * Math.PI / count;
            double redHorseScore = 0;
            double blueHorseScore = 0;
            double greenHorseScore = 0;
            Random random = new Random();
            List<PointF> vector = new List<PointF>();

            while (redHorseScore <= Math.PI * 2 & blueHorseScore <= Math.PI * 2 & greenHorseScore <= Math.PI * 2) { 
            
                //double x = r * Math.Cos(i) * a + x0;
                //double y = r * Math.Sin(i) * b + y0;

                double ir = random.NextDouble() * 0.3;
                redHorseScore += ir;
                double xr = r * Math.Cos(redHorseScore) * a + x0;
                double yr = r * Math.Sin(redHorseScore) * b + y0;


                double ig = random.NextDouble() * 0.3;
                greenHorseScore += ig;
                double xg = r * Math.Cos(greenHorseScore) * a + x0;
                double yg = r * Math.Sin(greenHorseScore) * b + y0;


                double ib = random.NextDouble() * 0.3;
                blueHorseScore += ib;
                double xb = r * Math.Cos(blueHorseScore) * a + x0;
                double yb = r * Math.Sin(blueHorseScore) * b + y0;


                graphics.Clear(DefaultBackColor);

                //метка финиша/старта
                graphics.DrawLine(new Pen(Color.Black, 1f), new PointF(x0 + r * a - 2, y0), new PointF(x0 + r * a + 2, y0));
                graphics.DrawString("Финиш ", new Font(new FontFamily(GenericFontFamilies.SansSerif), 10f),
                    Brushes.Red, new PointF(x0 + r * a + 4, y0));
                
                PrintEllipse(graphics, blackPen, 70, 40, 30, 60, 2, 1);

                PrintEllipse(graphics, redPen, xr, yr, 3, 20, 1, 1);
                PrintEllipse(graphics, bluePen, xb, yb, 3, 20, 1, 1);
                PrintEllipse(graphics, greenPen, xg, yg, 3, 20, 1, 1);

                Thread.Sleep(400);
                
            }
            
            switch (bet)
            {
                case "radioButtonBlueHorse":
                    if(blueHorseScore > Math.PI * 2)
                    {
                        MessageBox.Show("ты победил");
                    }
                    else
                    {
                        MessageBox.Show("ты проиграл");
                    }
                    // (blueHorseScore > Math.PI * 2) ? MessageBox.Show("ты победил"); : MessageBox.Show("ты проиграл");
                    break;
                case "radioButtonRedHorse":
                    if (redHorseScore > Math.PI * 2)
                    {
                        MessageBox.Show("ты победил");
                    }
                    else
                    {
                        MessageBox.Show("ты проиграл");
                    }
                    break;
                case "radioButtonGreenHorse":

                    if (blueHorseScore > Math.PI * 2)
                    {
                        MessageBox.Show("ты победил");
                    }
                    else
                    {
                        MessageBox.Show("ты проиграл");
                    }
                    break;
            }
            
            
        }



        //рисуем окружность
        public static void PrintEllipse(Graphics graphics, Pen pen, double x0, double y0, int r, int count, int a, int b)
        {
            
            double da = 2 * Math.PI / count;

            List<PointF> vector = new List<PointF>();
            for (double i = 0; i <= 2 * Math.PI; i += da)
            {
                double x = r * Math.Cos(i) * a + x0;
                double y = r * Math.Sin(i) * b + y0;
                vector.Add(new PointF((float)x, (float)y));
            }

            graphics.DrawLines(pen, vector.ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(BackColor);
            graphics.PageUnit = GraphicsUnit.Millimeter;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Pen pen = new Pen(Color.Black, 0.1f);


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
            

            
            RunHorse(bet, graphics, pinkPen, 70, 40, 30, 60, 2, 1);

        }

        private void radioButtonRedHorse_CheckedChanged(object sender, EventArgs e)
        {
            this.bet = "radioButtonRedHorse";
        }

        private void radioButtonBlueHorse_CheckedChanged(object sender, EventArgs e)
        {
            this.bet = "radioButtonBlueHorse";

        }

        private void radioButtonGreenHorse_CheckedChanged(object sender, EventArgs e)
        {
            this.bet = "radioButtonGreenHorse";
        }
    }
}
