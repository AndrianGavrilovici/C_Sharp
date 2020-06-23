using System;
using System.Windows.Forms;

namespace ex5p39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X: " + MousePosition.X.ToString() + "   Y: " + MousePosition.Y.ToString();
        }

    }
}
