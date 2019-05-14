using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMPLE_AKSH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 5;
        int dy = 5;
        int x = 100, y = 100, r = 20;
        Pen pen = new Pen(Color.Red);

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(pen.Brush, x - r, y - r, 2 * r, 2 * r);
            x += dx;
            y += dy;
            if (y + 2 * r >= this.Height || y <= 0)
                dy = -dy;
            if (x + 2 * r >= this.Width || x <= 0)
                dx = -dx;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}