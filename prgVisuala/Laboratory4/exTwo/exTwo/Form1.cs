using System;
using System.Windows.Forms;

namespace exTwo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ButtonPosition();
        }
        private void ButtonPosition() {
            button1.Top = (this.Height / 2) - button1.Height;
            button1.Left = (this.Width / 2) - button1.Width;
            button2.Top = (this.Height / 2) - button2.Height;
            button2.Left = (this.Width / 2) - button2.Width + button1.Width;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Width += 10;
            this.Height += 10;
            ButtonPosition();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Width -= 10;
            this.Height -= 10;
            ButtonPosition();
        }
    }
}
