using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exSeven {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region MovePanel
        private bool _dragging = false;
        private void Panel_MouseDown(object sender, MouseEventArgs e) {
            _dragging = true;
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e) {
            _dragging = false;
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e) {
            if (_dragging) {
                Point p = new Point((MousePosition.X - this.Left) - 8, (MousePosition.Y - this.Top) - 31);
                panel1.Location = new Point(p.X, p.Y);
            }

        }
        #endregion
    }
}
