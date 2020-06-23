using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
namespace Shop {
    public partial class User : Form {
        public User() {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;
            VSReactive<int>.Subscribe("menu", e => BtnsContent.SelectedIndex = e);
            OnClick(btnCastelMIMI);
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
                pnlUserMenu.Width = 275;
                AnimatedSideOn.ShowSync(pnlUserMenu);
                //animate content 1
                castelMIMIContent1.Visible = false;
                castelMIMIContent1.Left += 221;
                castelMIMIContent1.Width -= 221;
                AnimatedContentOnOffSide.ShowSync(castelMIMIContent1);
            } else {
                menuExpanded = false;                
                pnlUserMenu.Visible = false;
                pnlUserMenu.Width = 50;
                AnimatedSideOff.ShowSync(pnlUserMenu);
                //animate content 1
                castelMIMIContent1.Visible = false;
                castelMIMIContent1.Left -= 221;
                castelMIMIContent1.Width += 221;
                AnimatedContentOnOffSide.ShowSync(castelMIMIContent1);
            }
        }
        #endregion

        #region Click Buttons
        private void btnMenu_Click(object sender, EventArgs e) {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            BtnsContent.Visible = false;
            AnimatedContentOnOffSide.ShowSync(BtnsContent);
            ResetColorButtons();
            int btn = int.Parse(((Control)sender).Tag.ToString());
            switch (btn) {
                case 0:
                    OnClick(btnCastelMIMI);
                    break;
                case 1:
                    OnClick(btnRestaurant);
                    break;
                case 2:
                    OnClick(btnWine);
                    break;
                case 3:
                    OnClick(btnResort);
                    break;
                case 4:
                    OnClick(btnEvents);
                    break;
                case 5:
                    OnClick(btnGallery);
                    break;
                case 6:
                    OnClick(btnProgram);
                    break;
                case 7:
                    OnClick(btnContact);
                    break;
                case 8:
                    OnClick(btnAboutUS);
                    break;
            }           
        }
        private void ResetColorButtons() {
            btnCastelMIMI.Normalcolor = Color.FromArgb(46, 139, 87);
            btnRestaurant.Normalcolor = Color.FromArgb(46, 139, 87);
            btnWine.Normalcolor = Color.FromArgb(46, 139, 87);
            btnResort.Normalcolor = Color.FromArgb(46, 139, 87);
            btnEvents.Normalcolor = Color.FromArgb(46, 139, 87);
            btnGallery.Normalcolor = Color.FromArgb(46, 139, 87);
            btnProgram.Normalcolor = Color.FromArgb(46, 139, 87);
            btnContact.Normalcolor = Color.FromArgb(46, 139, 87);
            btnAboutUS.Normalcolor = Color.FromArgb(46, 139, 87);
            //hover color
            btnCastelMIMI.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnRestaurant.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnWine.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnResort.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnEvents.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnGallery.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnProgram.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnContact.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnAboutUS.OnHovercolor = Color.FromArgb(36, 129, 77);
        }

        private void OnClick (Bunifu.Framework.UI.BunifuFlatButton button) {
            button.OnHovercolor = Color.FromArgb(26, 119, 67);
            button.Normalcolor = Color.FromArgb(26, 119, 67);
        }
        #endregion
    }
}
