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
    public partial class SignIn : UserControl {
        public SignIn() {
            InitializeComponent();
        }

        private void inputPassword_OnValueChanged(object sender, EventArgs e) {
            inputPassword.isPassword = true;
            
        }
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSignIn {
            get { return btnSignIn; }
            set { btnSignIn = value; }
        }
        public Bunifu.Framework.UI.BunifuThinButton2 BtnRegisterNow {
            get { return btnRegisterNow; }
            set { btnRegisterNow = value; }
        }
    }
}
