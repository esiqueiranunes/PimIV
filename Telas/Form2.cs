using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            customizeDesign();
            // colocar o ponteiro no campo nome ao abrir o Form2 e demais tbm
        }

        private void customizeDesign() {
            panelEndereco.Visible = false;
        }
        private void hideSubMenu() {
            if (panelEndereco.Visible == true) {
                panelEndereco.Visible = false;
            }
         
        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }

        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void btnShowCadEndereco_Click(object sender, EventArgs e) {
            showSubMenu(panelEndereco);
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button4_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
