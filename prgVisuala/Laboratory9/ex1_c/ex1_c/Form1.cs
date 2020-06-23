using System;
using System.Windows.Forms;

namespace ex1_c
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}
		string text_check;
		private void Cheched(object sender, EventArgs e) {
			if (radioButton1.Checked == true) {
				text_check = radioButton1.Text;
			}
			if (radioButton2.Checked == true) {
				text_check = radioButton2.Text;
			}
			if (radioButton3.Checked == true) {
				text_check = radioButton3.Text;
			}
			if (radioButton4.Checked == true) {
				text_check = radioButton4.Text;
			}
			if (radioButton5.Checked == true) {
				text_check = radioButton5.Text;
			}
			if (radioButton6.Checked == true) {
				text_check = radioButton6.Text;
			}
			if (radioButton7.Checked == true) {
				text_check = radioButton7.Text;
			}
		}

		private void Button1_Click(object sender, EventArgs e) {
			int number = int.Parse(text_check);
			label1.Text = (number * number).ToString();
		}
	}
}
