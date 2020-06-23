using System;
using System.Windows.Forms;

namespace ex3
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}
		private void Kilometri2_CheckedChanged(object sender, EventArgs e) {
			double data = double.Parse(textBox1.Text);
			double rezultat = data;
			if (metri1.Checked) {
				rezultat = data / 1000;
			}
			else if (decimetri1.Checked) {
				rezultat = data / 10000;
			}
			else if (centimetri1.Checked) {
				rezultat = data / 100000;
			}
			else if (milimetri1.Checked) {
				rezultat = data / 1000000;
			}
			textBox2.Text = rezultat.ToString();
		}

		private void Metri2_CheckedChanged(object sender, EventArgs e) {
			double data = double.Parse(textBox1.Text);
			double rezultat = data;
			if (kilometri1.Checked) {
				rezultat = data * 1000;
			} else if (decimetri1.Checked) {
				rezultat = data / 10;
			} else if (centimetri1.Checked) {
				rezultat = data / 100;
			} else if (milimetri1.Checked) {
				rezultat = data / 1000;
			}
			textBox2.Text = rezultat.ToString();
		}

		private void Decimetri2_CheckedChanged(object sender, EventArgs e) {
			double data = double.Parse(textBox1.Text);
			double rezultat = data;
			if (kilometri1.Checked) {
				rezultat = data * 10000;
			} else if (metri1.Checked) {
				rezultat = data * 10;
			} else if (centimetri1.Checked) {
				rezultat = data / 10;
			} else if (milimetri1.Checked) {
				rezultat = data / 100;
			}
			textBox2.Text = rezultat.ToString();
		}

		private void Centimetri2_CheckedChanged(object sender, EventArgs e) {
			double data = double.Parse(textBox1.Text);
			double rezultat = data;
			if (kilometri1.Checked) {
				rezultat = data * 100000;
			} else if (metri1.Checked) {
				rezultat = data * 100;
			} else if (decimetri1.Checked) {
				rezultat = data * 10;
			} else if (milimetri1.Checked) {
				rezultat = data / 10;
			}
			textBox2.Text = rezultat.ToString();
		}

		private void Milimetri2_CheckedChanged(object sender, EventArgs e) {
			double data = double.Parse(textBox1.Text);
			double rezultat = data;
			if (kilometri1.Checked) {
				rezultat = data * 1000000;
			} else if (metri1.Checked) {
				rezultat = data * 1000;
			} else if (decimetri1.Checked) {
				rezultat = data * 100;
			} else if (centimetri1.Checked) {
				rezultat = data * 10;
			}
			textBox2.Text = rezultat.ToString();
		}
	}
}
