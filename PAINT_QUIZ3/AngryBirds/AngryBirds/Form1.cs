using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        Bitmap bitmap;
        Graphics g;
        float x, y , r = 40 , x2 , y2;
        float vx, vy;
        Pen pen = new Pen(Color.Blue, 3);

    

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            x2 = x2 - 2;
            y2 = y2 - 1 - 3/2;
            
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //g.DrawEllipse(pen, e.Location.X - r, e.Location.Y - r, 2 * r, 2 * r);
            vx = Math.Abs(x - e.Location.X);
            vy = Math.Abs(y - e.Location.Y);
            x2 = e.Location.X;
            y2 = e.Location.Y;
            //pictureBox1.Refresh();
            timer1.Start();
        }

        private void Draw()
        {
            g.Clear(Color.White);
            g.DrawEllipse(pen , x2 - r, y2 - r, 2 * r, 2 * r);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
        }
    }
}
