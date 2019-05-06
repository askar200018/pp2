using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BALL
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        bool isClicked = false;
        int x, y, r = 40;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 10;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            x = e.Location.X;
            y = e.Location.Y;
            Draw();
            timer1.Start();
        }
        private void Draw()
        {
            g.Clear(Color.White);
            if (isClicked)
            {
                g.FillEllipse(new SolidBrush(Color.FromArgb(random.Next())) , x - r , y - r ,2 * r , 2 *r);
                //g.FillEllipse(new SolidBrush(Color.Red), x - r, y - r, 2 * r, 2 * r);
            }
            //y += 5;
            pictureBox1.Refresh();
        }
    }
}
