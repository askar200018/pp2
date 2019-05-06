using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_QUIZ
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        int x = 200, y = 200, r = 30;
        int x1, y1, r1 = 6;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            x1 = random.Next(200, 600);
            y1 = random.Next(200, 500);
        }
        int dir = 1;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
        private int Sqr(int x)
        {
            return x * x;
        }
        private void DRawrec()
        {
            g.Clear(Color.White);
            if(Sqr(x  - x1) + Sqr(y1 - y) <= r * r)
            {
                x1 = random.Next(200 , 600);
                y1 = random.Next(200 , 500);
            }
            g.FillEllipse(new SolidBrush(Color.Black), x1 - r1, y1 - r1, 2 * r1, 2 * r1);
            g.FillRectangle(new Pen(Color.Black).Brush, x - r, y - r, 2 * r, 2 * r);
        }
        private void DrawEll()
        {
           // g.FillEllipse(new Pen(Color.Black).Brush, x - r1, y - r1, 2 * r1, 2 * r1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dir = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dir = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dir = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dir = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dir == 1)
            {
                y-= 10;
            }else if(dir == 2)
            {
                x+= 10;
            }else if(dir == 3)
            {
                x-= 10;
            }else if(dir == 4)
            {
                y+= 10;
            }
            DRawrec();
            pictureBox1.Refresh();
        }

       
    }
}
