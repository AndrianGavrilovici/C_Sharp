using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MessageApp {
    public partial class SignIn : UserControl {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
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

        private void btnSignIn_Click(object sender, EventArgs e) {

        }
    }
}
