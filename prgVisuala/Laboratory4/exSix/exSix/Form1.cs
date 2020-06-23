using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exSix {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void down_Click(object sender, EventArgs e) {
            panel1.Top += 5;
        }

        private void right_Click(object sender, EventArgs e) {
            panel1.Left += 5;
        }

        private void up_Click(object sender, EventArgs e) {
            panel1.Top -= 5;
        }

        private void left_Click(object sender, EventArgs e) {
            panel1.Left -= 5;
        }
    }
}
