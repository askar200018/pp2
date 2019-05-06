using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            s = "";
        }
        string s;
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            s = textBox1.Text;
            a = int.Parse(s);
            textBox2.Text += a / 3600 + "h";
            a %= 3600;
            textBox2.Text += a / 60 + "mm";
            a %= 60;
            textBox2.Text += a + "ss";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
