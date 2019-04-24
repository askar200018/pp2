using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temir
{
    public partial class Form1 : Form
    {
        bool clicked = false;
        Point prev = new Point();
        Point then = new Point();
        int vx, vy;
        int k = 1;
        Graphics g, f;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            f = CreateGraphics();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            g.Clear(Color.White);
            prev = new Point();
            then = new Point();
            k = 1;

            clicked = true;
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(e.X - 10, e.Y - 10, 20, 20));
            prev = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked) Refresh();
            if (clicked) g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(e.X - 10, e.Y - 10, 20, 20));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.FillEllipse(new SolidBrush(Color.White), ((then.X - 20) + (float)(vx * (k - 1) / 50)), (then.Y - 20 - (float)(vy * (k - 1) / 50) + (float)((k - 1) * (k - 1) / 50)), 40, 40);
            g.FillEllipse(new SolidBrush(Color.Red), ((then.X - 10) + (float)(vx * k / 50)), (then.Y - 10 - (float)(vy * k / 50) + (float)(k * k / 50)), 20, 20);
            //g.DrawLine(new Pen(Color.LightGreen), then.X + (float)(vx * k / 50), then.Y - (float)(vy * k / 50) + (float)(k * k / 50), then.X + (float)(vx * (k + 1) / 50), then.Y - (float)(vy * (k + 1) / 50) + (float)((k + 1) * (k + 1) / 50));
            k++;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            then = new Point(e.X, e.Y);
            vx = (prev.X - then.X);
            vy = (then.Y - prev.Y);

            timer1.Enabled = true;
        }

    }
}