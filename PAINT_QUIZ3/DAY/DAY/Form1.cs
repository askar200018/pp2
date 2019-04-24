using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        People people = new People(200 , 250);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Green;
            Pen blue = new Pen(Color.Blue, 3);
            Pen yellow = new Pen(Color.Yellow, 3);
            Pen white = new Pen(Color.White, 3);
            Pen black = new Pen(Color.Black, 3);
            e.Graphics.FillRectangle(blue.Brush, 0, 0, 800, 300);
            e.Graphics.FillPolygon(white.Brush, Stars(550, 80));
            e.Graphics.FillPolygon(white.Brush, Stars(150, 60));
            e.Graphics.FillPolygon(white.Brush, Stars(230, 45));
            e.Graphics.FillPolygon(white.Brush, Stars(430, 90));

            e.Graphics.FillEllipse(yellow.Brush, 25, 25, 70, 70);
            e.Graphics.FillEllipse(blue.Brush, 35, 25, 60, 60);

            e.Graphics.FillPath(black.Brush, people.gp1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 600;
        }
        Point [] Stars(int x , int y)
        {
            Point[] star = 
            {
                new Point(x , y),
                new Point(x + 8 , y + 10),
                new Point(x , y + 20),
                new Point(x - 8 , y + 10)
            };
            return star;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            people.Move();
            Refresh();
        }
    }
}
