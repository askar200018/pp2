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

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 780;
        }
        Mash mash = new Mash(50 , 100);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen black = new Pen(Color.Black);
            e.Graphics.DrawPath(black, mash.gp1);
            e.Graphics.FillPath(black.Brush, mash.gp2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mash.AddFig();
            Refresh();
        }
    }
}
