using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageApp {
    public partial class SubMenu : UserControl {
        public SubMenu() {
            InitializeComponent();
            ButtonsMessagePage0();
        }
        private void ButtonsMessagePage0() {
            string[] nameAcc = {
                "Ana",
                "Slavic"
            };
            Image[] image = {
                Properties.Resources.icons8_Secured_Letter_50px,
                Properties.Resources.icons8_Contacts_50px
            };
            Bunifu.Framework.UI.BunifuFlatButton[] flatButton = new Bunifu.Framework.UI.BunifuFlatButton[2];
            for(int i = 0; i < flatButton.Length; i++) {
                flatButton[i] = new Bunifu.Framework.UI.BunifuFlatButton {
                    Text = nameAcc[i],
                    Iconimage = image[i],
                    Dock = DockStyle.Top,
                    IconMarginLeft = 2,
                    Left = 10
                };
                panel1Page0.Controls.Add(flatButton[i]);
            }
        }
        public void Page(int index) {
            tabControl.SelectTab(index);
        }
    }
}
