using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
        Point location_btn ;
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            string pressed_btn = e.KeyCode + "";
            Point location_btn = button1.Location;
            btn_width = button1.Width;
            btn_height = button1.Location.Y;
            if (e.KeyCode == Keys.A)
            {
                location_btn.X -= 10;
            }else if(e.KeyCode == Keys.D)
            {
                location_btn.X += 10;
            }
            button1.Location = location_btn;
        }
        int dx = 10, dy = 10;
        int btn_height , btn_width;
        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_height = location_btn.Y;
            //MessageBox.Show(btn_height + "");
            Point location = label1.Location;
            if ((location.Y + label1.Height >= 380 || location.Y <= 0)) dy  = dy * (-1);
            location.Y += dy;
            label1.Location = location;
        }
    }
}