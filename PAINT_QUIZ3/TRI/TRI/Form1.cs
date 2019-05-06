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

namespace TRI
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        List<Triangle> triangles = new List<Triangle>();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        int k = 1 , x , y;
        Pen pen = new Pen(Color.Black , 3);
        Random random = new Random();
        List<int> num2 = new List<int>();
        List<int> num1 = new List<int>();

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < k; i++)
            {
                x = random.Next(0, pictureBox1.Width);
                y = random.Next(0, pictureBox1.Height);
                Triangle t = new Triangle(x, y);
                num1.Add(2);
                num2.Add(2);
                triangles.Add(t);
            }
            k++;
            for (int i = 0; i < triangles.Count; i++)
            {
                if (triangles[i].x + 10 >= pictureBox1.Width || triangles[i].x <= 0)
                {
                    num1[i] = num1[i] * (-1);
                }
                if (triangles[i].y + 10 >= pictureBox1.Height || triangles[i].y <= 0)
                {
                    num2[i] = num2[i] * (-1);
                }
                triangles[i].x += num1[i];
                triangles[i].y += num2[i];
                triangles[i].Draw();
            }
           //pictureBox1.Refresh();
            Draw();
        }
        private void Draw()
        {
            g.Clear(Color.White);
            for (int i = 0; i < triangles.Count; i++)
            {
                g.DrawPath(pen, triangles[i].gp);
            }
            pictureBox1.Refresh();
        }
    }
}
