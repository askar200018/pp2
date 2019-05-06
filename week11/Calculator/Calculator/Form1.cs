using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalcBase calc;
        public Form1()
        {
            InitializeComponent();
            calc = new CalcBase();
            
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += btn.Text;
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.first_number = float.Parse(textBox1.Text);
            calc.operation = btn.Text;
            textBox1.Text = "";
        }
        private void result_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.second_number = float.Parse(textBox1.Text);
            calc.Calculate();
            textBox1.Text = calc.result + "";
        }
        private void clear_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "0";
            calc = new CalcBase();
        }
        private void zero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text != "0")
            {
                textBox1.Text += btn.Text;
            }
        }
        private void BackSpace_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            s = s.Remove(s.Length - 1);
            textBox1.Text = s;
        }
        private void square_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            calc.first_number = float.Parse(textBox1.Text);
            calc.operation = btn.Text;
            calc.Calculate();
            textBox1.Text = calc.result + "";
        }
    }
}
