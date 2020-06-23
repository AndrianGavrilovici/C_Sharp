using System;
using System.Drawing;
using System.Windows.Forms;

namespace exThree {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 0, 0);
        }
        int i = 0;
        int redColor = 255;
        private void button1_Click(object sender, EventArgs e) {
            if (i > 0) i-= 10;
            else redColor-= 10;
            this.BackColor = Color.FromArgb(redColor, i, i);
        }

        private void button2_Click(object sender, EventArgs e) {
            if (redColor < 255) redColor+= 10;
            else i+= 10;        
            this.BackColor = Color.FromArgb(redColor, i, i);
        }
    }
}
