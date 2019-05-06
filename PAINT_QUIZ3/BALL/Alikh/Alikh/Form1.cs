using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alikh
{
    public partial class Form1 : Form
    {
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        Graphics g;
        int dy, dx;
        Bitmap bitmap;
        Random random = new Random();
        int r = 20;
        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.FromArgb(random.Next()));
            timer1.Start();
        }
        private void Draw()
        {
            g.Clear(Color.Black);
            for(int i = 0; i <5; i++)
            {
                int x = random.Next(0, pictureBox1.Width);
                int y = random.Next(0, pictureBox1.Height);
                g.FillEllipse(pen.Brush, x - r + dx, y - r + dy, 2 * r, 2 * r);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dx = random.Next(0, 5);
            dy = random.Next(0, 5);
            Draw();
            pictureBox1.Refresh();
        }
    }
}
