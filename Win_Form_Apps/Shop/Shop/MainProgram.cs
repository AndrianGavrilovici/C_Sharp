using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop {
    public partial class MainProgram : Form {
        public MainProgram() {
            InitializeComponent();
            AnimationAndChangingForm();
            signIn1.BtnSignIn.Click += BtnSignIn_Click;
        }

        private void BtnSignIn_Click(object sender, EventArgs e) {
            User user = new User();
            bunifuTransition3.ShowSync(user);
            this.Hide();
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

        #region Animation And Changing Form

        private void AnimationAndChangingForm() {
            signIn1.BtnRegisterNow.Click += BtnRegisterNow_Click;
            registerNowAccount1.BtnBack.Click += BtnBack_Click;
        }
        private void BtnRegisterNow_Click(object sender, EventArgs e) {
            bunifuTransition2.HideSync(signIn1);
            bunifuTransition1.ShowSync(registerNowAccount1);
        }
        private void BtnBack_Click(object sender, EventArgs e) {
            bunifuTransition2.HideSync(registerNowAccount1);
            bunifuTransition1.ShowSync(signIn1);
        }

        #endregion
    }
}
