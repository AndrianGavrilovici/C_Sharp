using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop {
    public partial class RegisterNowAccount : UserControl {
        public RegisterNowAccount() {
            InitializeComponent();
        }
        private void inputPassword_OnValueChanged(object sender, EventArgs e) {
            inputPassword.isPassword = true;
        }
        private void inputRetryPassword_OnValueChanged(object sender, EventArgs e) {
            inputRetryPassword.isPassword = true;
        }

        public Bunifu.Framework.UI.BunifuImageButton BtnBack {
            get { return btnBack; }
            set { btnBack = value; }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (inputEmail == null) {

            } 
            else if (inputUserName == null) {

            } 
            else if (inputPassword == null) {

            } 
            else if (inputRetryPassword == null) {

            }
        }

    }
}
