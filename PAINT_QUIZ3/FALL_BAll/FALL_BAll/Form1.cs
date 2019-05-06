using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FALL_BAll
{
    public partial class Form1 : Form
    {
        List<int> xx = new List<int>();
        List<int> yy = new List<int>();
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
        int x, y, r = 40;
        Pen pen = new Pen(Color.Blue);

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < xx.Count; i++)
            {
                yy[i] += 5;
                g.FillEllipse(pen.Brush, xx[i] - r, yy[i] - r, 2 * r, 2 * r);
            }
            pictureBox1.Refresh();
        }

        private void DrawEll()
        {
            g.FillEllipse(pen.Brush, x - r, y - r, 2 * r, 2 * r);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                xx.Add(e.Location.X);
                yy.Add(e.Location.Y);
                isClicked = true;
                timer1.Start();
        }

    }
}
