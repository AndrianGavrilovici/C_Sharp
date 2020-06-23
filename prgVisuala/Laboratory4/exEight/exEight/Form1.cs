using System;
using System.Drawing;
using System.Windows.Forms;

namespace exEight {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Panel[] p = new Panel[9];
            int x = 12;
            int y = 20;
            for (int i = 0; i < p.Length; i++) {                
                p[i] = new Panel {
                    Location = new Point(x, y),
                    Width = 75,
                    Height = 55,
                    BackColor = Color.FromArgb(222, 222, 222)
                };                
                x += p[i].Width + 12;
                this.Controls.Add(p[i]);
                int index = i;
                p[i].Click += (sender, e) => Panel_Click(p[index]);
            }
        }

        private void Panel_Click(Panel panel) {
            panel.BackColor = panelColor.BackColor;
        }

        private void red_Click(object sender, EventArgs e) {
            panelColor.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void green_Click(object sender, EventArgs e) {
            panelColor.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void blue_Click(object sender, EventArgs e) {
            panelColor.BackColor = Color.FromArgb(0, 0, 255);
        }
    }
}
