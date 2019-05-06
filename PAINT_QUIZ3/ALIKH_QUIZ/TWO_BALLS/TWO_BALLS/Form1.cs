using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWO_BALLS
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width , pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        bool isCor = false;
        int x, y, r = 20;
        Random random = new Random();
        List<Color> colors = new List<Color>();
        Color[] twoColor = new Color[] 
        {
            Color.Red,
            Color.Green
        };
        Rectangle rectangle;
        SolidBrush solid;
        Point p;
        Color color;
        int k;

        private void timer1_Tick(object sender, EventArgs e)
        {
            SolidBrush sol = new SolidBrush(Color.White);
            g.FillEllipse(sol, rectangles[k]);
            g.FillEllipse(sol, rectangle);
            colors[k] = Color.White;
            g.DrawLine(new Pen(Color.White, 4), rectangle.X + r, rectangle.Y + r, rectangles[k].X + r, rectangles[k].Y + r);
            isCor = false;
            timer1.Stop();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            x = e.Location.X;
            y = e.Location.Y;
            color = twoColor[random.Next(0, 2)];
            solid = new SolidBrush(color);
            rectangle = new Rectangle(x - r, y - r, 2 * r, 2 * r);
            g.FillEllipse(solid, rectangle);
            for(int i = 0; i < rectangles.Count; i++)
            {
                if (colors[i] == Color.White) continue;
                else
                g.FillEllipse(new SolidBrush(colors[i]), rectangles[i]);
            }
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (colors[i] == Color.White) continue;
                if (color != colors[i])
                {
                    k = i;
                    isCor = true;
                    break;
                }
            }
            if (isCor)
            {
                g.DrawLine(new Pen(Color.Black, 4), rectangle.X + r, rectangle.Y + r, rectangles[k].X + r, rectangles[k].Y + r);
                timer1.Start();
            }
            else
            {
                rectangles.Add(rectangle);
                colors.Add(color);
            }
           pictureBox1.Refresh();
        }
        List<Rectangle> rectangles = new List<Rectangle>();
    }
}
