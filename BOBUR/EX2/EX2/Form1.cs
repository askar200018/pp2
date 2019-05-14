using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x_e = 240, y_e = 50, x_r = 30, y_r = 450 , x_r2 = 30 , y_r2 = 10;
        int r = 20;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (x_r <= 0)
                {

                }
                else {
                    x_r -= 10;
                }
            } else if (e.KeyCode == Keys.Right)
            {
                if (x_r + 80 >= Width) { }
                else
                {
                    x_r += 10;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (x_r2 <= 0)
                {

                }
                else
                {
                    x_r2 -= 10;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (x_r2 + 80 >= Width) { }
                else
                {
                    x_r2 += 10;
                }
            }
            Refresh();
        }
        int dy = 10, dx = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (((y_e + 2 * r >= y_r) && (x_e >= x_r && x_e <= x_r + 80)) || (y_e <= y_r2 + 20) && (x_e >= x_r2 && x_e <= x_r2 + 80)) dy *= -1;
            if (x_e <= 0 || x_e + 2 * r >= Width) dx *= -1;
      
            y_e += dy;
            x_e += dx;
            
            Refresh();
        }

        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush black = new SolidBrush(Color.Black);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(black, x_r2, y_r2, 80, 20);
            e.Graphics.FillEllipse(red , x_e , y_e , 2 * r , 2 * r);
            e.Graphics.FillRectangle(black, x_r, y_r, 80, 20);
        }
    }
}
