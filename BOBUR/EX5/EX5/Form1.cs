using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5
{
    public partial class Form1 : Form
    {
        int x_d = 20, y_d = 200, x_c = 400, y_c = 230, r_d = 40, r_c = 25;


        SolidBrush black = new SolidBrush(Color.Black);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (y_d == 140)
                {

                }
                else
                {
                    y_d -= 60;
                    timer2.Start();
                }
            }
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y_d += 60;
            timer2.Stop();
            Refresh();
        }

        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush green = new SolidBrush(Color.Green);

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.Yellow;
            if ((x_d + 2 * r_d >= x_c) && (y_d == y_c - 30))
            {
                timer1.Stop();
                label1.Text = "YOUR TOTAL SCORE :" + score;
            }
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 0, 280, Width, 280);
            e.Graphics.FillRectangle(green, 0, 280, Width, Height - 280);
            e.Graphics.FillRectangle(black, x_c, y_c, 2 * r_c, 2 * r_c);
            e.Graphics.FillEllipse(red, x_d, y_d, 2 * r_d, 2 * r_d);
        }
        int score = 0 , dx = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x_c <= 0)
            {
                x_c = Width - 50;
                dx += 5;
            }
            x_c -= dx;
            score += 1;
            label1.Text = score + "";
            Refresh();
        }
    }
}
