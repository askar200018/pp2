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

namespace Graph
{
    public partial class Form1 : Form
    {
        bool isClicked = false;
        Bitmap bitmap;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        int x, y, r = 50, d = 0;
        Color[] colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Green,
            Color.Green,
            Color.Violet,
            Color.Bisque,
            Color.Brown,
            Color.BurlyWood
        };
        Random random = new Random();
       

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isClicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                d = 0;
                //r = 1; //с нуля
                timer1.Start();
                isClicked = true;
            }
            else
            {
                isClicked = false;
                timer1.Stop();
            }
        }

        private void DrawEllipse()
        {
            g.Clear(Color.White);
            int index = random.Next(0, colors.Length - 1);
            Pen pen = new Pen(colors[index], 3);
            g.DrawEllipse(pen, x - r + d, y - r, 2 * r, 2 * r);
            g.DrawEllipse(pen, x - r, y - r + d, 2 * r, 2 * r);
            g.DrawEllipse(pen, x - r - d, y - r, 2 * r, 2 * r);
            g.DrawEllipse(pen, x - r, y - r - d, 2 * r, 2 * r);
            pictureBox1.Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //int index = random.Next(0, colors.Length - 1);
            //Pen pen = new Pen(colors[index], 3);
            //x = e.Location.X;
            //y = e.Location.Y;
            //g.FillRectangle(pen.Brush, x - r, y - r, 2 * r, 2 * r);
            //this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d += 3;
            DrawEllipse();
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //int index = random.Next(0, colors.Length - 1);
            //Pen pen = new Pen(colors[index], 3);
            ////g.FillRectangle(new SolidBrush(Color.Yellow), 10, 10, 100, 100);
            //g.FillRectangle(pen.Brush, x - r, y - r, 2 * r, 2 * r);

            //pictureBox1.Refresh();
        }
    }
}
