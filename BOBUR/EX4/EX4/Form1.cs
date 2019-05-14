using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> buttons = new List<Button>();
        Button[,] btns = new Button[3,3];
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 40;
            int y = 45;
            int k = 0;
            int d = 75;
            int ep = 7;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    k++;
                    Button btn = new Button();
                    btn.Size = new Size(d, d);
                    btn.Location = new Point(d * j + x + ep, d * i + y + ep);
                    btn.Click += BtnClick;
                    btn.Name = i + " " + j;
                    btns[i , j] = btn;
                    Controls.Add(btn);
                    buttons.Add(btn);
                }
            }    
        }
        bool isCick = true , isOver = true;
        private void BtnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] text = button.Name.Split();
            int x = int.Parse(text[0]);
            int y = int.Parse(text[1]);
            int count = 0 , count_z = 0 , count_r = 0;

            
            if (button.Text != "") { }
            else
            {
                if (isCick)
                {
                    btns[x , y].Text = "X";
                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if (count == 3) break;
                            if(i == j)
                            {
                                if (btns[i, j].Text == "X") count_z++;
                            }
                            if(i + j == 2)
                            {
                                if (btns[i, j].Text == "X") count_r++;
                            }
                            if(btns[i , j].Text == "X")
                                count++;
                            else
                                count = 0;
                        }
                        if(count != 3)count = 0;
                    }
                    if(count == 3 || count_z == 3 || count_r == 3)
                    {
                        MessageBox.Show("X WIN");
                    }else
                    {
                        count_z = 0;
                        count_r = 0;
                    }
                    isCick = false;
                }
                else
                {
                    btns[x, y].Text = "0";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (count == 3) break;
                            if (i == j)
                            {
                                if (btns[i, j].Text == "0") count_z++;
                            }
                            if (i + j == 2)
                            {
                                if (btns[i, j].Text == "0") count_r++;
                            }
                            if (btns[i, j].Text == "0")
                                count++;
                            else
                                count = 0;
                        }
                        if(count != 3)count = 0;
                    }
                    if (count == 3 || count_z == 3 || count_r == 3)
                        MessageBox.Show("0 WIN");
                    else
                    {
                        count_z = 0;
                        count_r = 0;
                    }
                    isCick = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (btns[i, j].Text == "") isOver = false;
                }
            }
            if (isOver == true) MessageBox.Show("GAME OVER");
            isOver = true;
        }
    }
}
