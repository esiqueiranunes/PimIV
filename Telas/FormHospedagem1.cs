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
    public partial class FormHospedagem1 : Form {
        public FormHospedagem1() {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign() {
            panelCadReserva.Visible = false;
            panelListarReserva.Visible = false;


        }
        private void hideSubMenu() {
            if (panelCadReserva.Visible == true) {
                panelCadReserva.Visible = false;
            }
            if (panelListarReserva.Visible == true) {
                panelListarReserva.Visible = false;
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

        private void btnCadReserva_Click(object sender, EventArgs e) {
            showSubMenu(panelCadReserva);
        }

        private void button3_Click(object sender, EventArgs e) {
            showSubMenu(panelListarReserva);
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
