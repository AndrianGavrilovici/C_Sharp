using System;
using System.Windows.Forms;

namespace ex2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e) {
			if (textBox1.Lines.Length >= 2) {
				label1.Text = "Rindul al 2-lea din zona -- " + textBox1.Lines[1];
			}
			label1.Text += "\nNumarul de randuri -- "+ textBox1.Lines.Length.ToString();
			if (textBox1.Lines.Length >= 2) {
				label1.Text += "\nPenultimul rind din zona -- " + textBox1.Lines[textBox1.Lines.Length-2];
			}
			if (textBox1.Lines[0].Length >= 3) {
				label1.Text += "\nSimbolul al 3 lea din primul rind -- " + textBox1.Lines[0][2];
			}
			if (textBox1.Lines.Length % 2 != 0) {
				label1.Text += "\nRindul din mijloc -- " + textBox1.Lines[textBox1.Lines.Length/2];
			}
			else {
				label1.Text += "\nRindurile din mijloc -- " + textBox1.Lines[textBox1.Lines.Length / 2 - 1];
				label1.Text += "\nRindurile din mijloc -- " + textBox1.Lines[textBox1.Lines.Length / 2];
			}
			bool exists = false;
			for(int i = 0; i < textBox1.Lines.Length; i++) {
				for(int j = i + 1; j < textBox1.Lines.Length; j++) {
					if (textBox1.Lines[i] == textBox1.Lines[j]) {
						exists = true;
					}
				}
			}
			label1.Text += "\nExista doua rinduri identice -- ";
			if (exists)
				label1.Text += "DA";
			else
				label1.Text += "NU";
		}

		private void BtnConfirma_Click(object sender, EventArgs e) {
			int num = int.Parse(textBox2.Text);
			if (num > textBox1.Lines.Length) {
				label1.Text = "Numarul la rand nu exista";
			} else {
				
			}
		}
	}
}
