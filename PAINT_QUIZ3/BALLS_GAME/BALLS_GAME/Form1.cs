using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Color[] colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Pink,
            Color.Orange
        };

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //int k = 0;
            for(int i = 0; i < 2; i++)
            {
                int k = 0;
                for(int j = 0; j < 5; j++)
                {
                    g.FillEllipse(new Pen(colors[k], 3).Brush, x + i * 70, y + j * 70, 2 * r, 2 * r);
                    k++;
                }
            }
            //g.FillEllipse(new Pen(colors[k], 3).Brush, x - r, y - r + d, 2 * r, 2 * r);
            pictureBox1.Refresh();
        }
    }
}
