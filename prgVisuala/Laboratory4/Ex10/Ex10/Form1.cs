using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        bool _dragging1 = false;
        bool _dragging2 = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            _dragging1 = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            _dragging1 = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (_dragging1) {
                panel1.Location = new Point(MousePosition.X - this.Left - 8, MousePosition.Y - this.Top - 30);
            } 
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            _dragging2 = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e) {
            _dragging2 = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e) {
            if (_dragging2) {
                panel2.Location = new Point(MousePosition.X - this.Left - 8, MousePosition.Y - this.Top - 30);
            }
        }
    }
}
