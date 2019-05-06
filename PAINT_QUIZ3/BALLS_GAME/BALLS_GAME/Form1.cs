using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BALLS_GAME
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        int x = 60, y = 60, r = 30 , d = 60;
        SolidBrush[] ss = new SolidBrush[] 
        {
            new SolidBrush(Color.Red),
            new SolidBrush(Color.Blue),
            new SolidBrush(Color.Yellow),
            new SolidBrush(Color.Pink),
            new SolidBrush(Color.Orange),
            new SolidBrush(Color.Red),
            new SolidBrush(Color.Blue),
            new SolidBrush(Color.Yellow),
            new SolidBrush(Color.Pink),
            new SolidBrush(Color.Orange)
        };
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush last = new SolidBrush(Color.Violet);
        int lastone = 1000;
        List<Rectangle> rectangles = new List<Rectangle>();
        List<Point> points = new List<Point>();
        List<bool> bools = new List<bool>();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point curPoint = e.Location;
            for(int i =0; i < 10; i++)
            {
                if(Sqr(curPoint.X - points[i].X) + Sqr(curPoint.Y - points[i].Y) <= r * r)
                {
                    if (!bools[i])
                    {
                        g.DrawEllipse(new Pen(Color.Black, 3), rectangles[i]);
                        if(ss[i].Color == last.Color && bools[lastone])
                        {
                            ss[lastone].Color = Color.White;
                            ss[i].Color = Color.White;
                            g.DrawEllipse(new Pen(Color.White, 3), rectangles[i]);
                            g.DrawEllipse(new Pen(Color.White, 3), rectangles[lastone]);
                        }
                        else
                        {
                            last.Color = ss[i].Color;
                            lastone = i;
                        }
                        bools[i] = true;
                    }

                    else
                    {
                        g.DrawEllipse(new Pen(Color.White, 3), rectangles[i]);
                        bools[i] = false;
                    }
                }
            }
            pictureBox1.Refresh();
        }

        int Sqr(int v)
        {
            return v * v;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.White;
            int c = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bools.Add(false);
                    points.Add(new Point(x + i * 70 , y + j * 70 ));
                    rectangles.Add(new Rectangle(points[c].X - r, points[c].Y - r, 2 * r, 2 * r));
                    g.FillEllipse(ss[c], rectangles[c]);
                    c++;
                }
            }
            pictureBox1.Refresh();
        }
    }
}
