using System.Windows.Forms;

namespace ex3
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e) {
			hScrollBar1.Value = vScrollBar1.Value;
		}

		private void HScrollBar1_Scroll(object sender, ScrollEventArgs e) {
			vScrollBar1.Value = hScrollBar1.Value;
		}
	}
}
