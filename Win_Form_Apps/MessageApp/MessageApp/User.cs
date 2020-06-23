using System;
using System.Drawing;
using System.Windows.Forms;

namespace MessageApp {
    public partial class User : Form {
        
        public User() {
            InitializeComponent();
            pnlUserMenu.Width = 50;
        }
        #region Move And Exit Application

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) {
            _dragging = true; // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e) {
            _dragging = false;
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e) {
            if (_dragging) {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion
        #region Side Panel On / Off
        bool menuExpanded = false;
        

        private void btnSidePanel_Click(object sender, EventArgs e) {
            if (!menuExpanded) {
                menuExpanded = true;
                pnlUserMenu.Visible = false;
                userTitle.Visible = true;                
                pnlUserMenu.Width = 215;
                AnimatedSideOn.Show(pnlUserMenu);
            } else {
                menuExpanded = false;
                while (pnlUserMenu.Width > 0) pnlUserMenu.Width -= 8;
                pnlUserMenu.Visible = false;
                userTitle.Visible = false;
                pnlUserMenu.Width = 50;                
                AnimatedSideOff.Show(pnlUserMenu);
            }
        }
        #endregion

        private void messages_Click(object sender, EventArgs e) {
            //subMenu1.Visible = false;
            //subMenu1.Page(0);
            //AnimatedSideOn.Show(subMenu1);
        }

        private void btnContact_Click(object sender, EventArgs e) {
            //subMenu1.Visible = false;
            //subMenu1.Page(1);
            //AnimatedSideOn.Show(subMenu1);
        }

        private void setting_Click(object sender, EventArgs e) {
            //subMenu1.Visible = false;
            //subMenu1.Page(2);
            //AnimatedSideOn.Show(subMenu1);
        }

        private void btnAboutUS_Click(object sender, EventArgs e) {
            //AnimatedSideOff.Hide(subMenu1);
        }
    }
}
