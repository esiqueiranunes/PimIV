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
    public partial class FormHospedagem2 : Form {
        public FormHospedagem2() {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign() {
            panelAtualizarHospedagem.Visible = false;
            
        }
        private void hideSubMenu() {
            if (panelAtualizarHospedagem.Visible == true) {
                panelAtualizarHospedagem.Visible = false;
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

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAtualizarHospedagem_Click(object sender, EventArgs e) {
            showSubMenu(panelAtualizarHospedagem);
        }
    }
}
