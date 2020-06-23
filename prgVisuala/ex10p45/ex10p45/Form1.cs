using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex10p45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            float[] num = new float[text.Length];
            float rs = Int32.Parse(text[0].ToString());;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '+' && text[i] != '-' && text[i] != '*' && text[i] != '/'){}
                else {
                    int num1 = Int32.Parse(text[i+1].ToString());
                        if (text[i] == '+')
                            rs += num1;
                        else if (text[i] == '-')
                            rs -= num1;
                        else if (text[i] == '*')
                            rs *= num1;
                        else if (text[i] == '/')
                            rs /= num1;
                }
            }
            label1.Text = rs.ToString();
        }
    }
}
