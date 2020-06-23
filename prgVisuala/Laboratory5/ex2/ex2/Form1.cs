using System;
using System.Windows.Forms;

namespace ex2
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e) {
			String text = textBox1.Text;
			String newText = "";
			int t = 0;
			for (int i = 0; i < text.Length; i++) {
				if (text[i] == '(' || t % 2 != 0) {
					t = 1;
					if (text[i] != ')') {
						continue;
					}
					if (text[i] == ')') {
						text = text.Remove(i, 1);
						if (i == text.Length) {
							break;
						}
					}
				}
				t = 0;
				newText += text[i];
			}
			textBox1.Text = newText;
		}
	}
}
