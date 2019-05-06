using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alikh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x = 10;
        int size = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value -= 1;
            size -= 5;
            label1.Font = new Font("Hello Word", (float)size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value += 1;
            size += 5;
            label1.Font = new Font("Hello Word", (float)size);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Size = ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
