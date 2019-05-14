using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FORM_1
{
    public partial class Form1 : Form
    {
        int rec, ell;
        Graphics g;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        int x = 20, y = 86, r = 25;
        SolidBrush pen = new SolidBrush(Color.Red);
        SolidBrush black = new SolidBrush(Color.Black);
        private void Draw()
        {
            for (int i = 0; i < rec; i++)
            {
                if (i % 8 == 0)
                {
                    x = 20;
                    y += 2 * r + 2;
                }
                g.FillRectangle(black, x - r, y - r, 2 * r, 2 * r);
                x += 2 * r + 2;               
            }
            x = 20;
            y = 86;
            for (int i = 0; i < ell; i++)
            {
                if (i % 8 == 0)
                {
                    x = 20;
                    y += 2 * r + 2;
                }
                g.FillEllipse(pen, x - r, y - r, 2 * r, 2 * r);
                x += 2 * r + 2;      
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string path = "";
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            path = textBox1.Text;
            DirectoryInfo d = new DirectoryInfo(path);
            bool isCheck = Directory.Exists(path);
            if (!isCheck)
            {
                textBox1.Text = "DIRECTRY NOT FOUND";
            }
            else {
                rec = d.GetFiles().Length;
                ell = d.GetDirectories().Length;
                Draw();
                pictureBox1.Refresh();
            }
        }
    }
}
