using System.Drawing;
using System.Windows.Forms;

namespace ex2_d
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e) {
			panel1.Location = new Point(0, vScrollBar1.Value);
		}
	}
}
