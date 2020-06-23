using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();            
        }

        private void cartofiToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Cartofii:\n5 Lei");
        }

        private void rosiiToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Rosii:\n6 Lei");
        }

        private void morcovToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Morcov:\n7 Lei");
        }

        private void mereToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Mere:\n8 Lei");
        }

        private void struguriToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Struguri:\n9 Lei");
        }

        private void pereToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Pere:\n10 Lei");
        }

        private void rosuToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Vin Rosu:\n11 Lei");
        }

        private void ablToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Vin Alb:\n12 Lei");
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Spumant Sec:\n13 Lei");
        }

        private void demisecToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Spumant Demisec:\n14 Lei");
        }

        private void deRosiiToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Suc de rosii:\n15 Lei");
        }

        private void deMereToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Suc de mere:\n16 Lei");
        }

        private void dePortocaleToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Suc de portocale:\n17 Lei");
        }
    }
}
