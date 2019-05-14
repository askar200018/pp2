using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = textBox1.Location.X;
            int y = textBox1.Location.Y + textBox1.Height + 5;
            int k = 0;
            int d = 75;
            int ep = 7;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    k++;
                    Button btn = new Button();
                    btn.Text = 0.ToString();
                    btn.Size = new Size(d, d);
                    btn.Location = new Point(d * j + x + ep, d * i + y + ep);
                    btn.Click += BtnClick;
                    Controls.Add(btn);
                }
            }
        }
        int y = 0;
        private void BtnClick(object sender, EventArgs e)
        {
            int x = 0;
            Button button = sender as Button;
            x = int.Parse(button.Text) + 1;
            if(x % 2== 0)
            {
                y++;
                textBox1.Text = y + "";
            }
            button.Text = x + "";
        }
    }
}
