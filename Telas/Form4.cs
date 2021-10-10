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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign() {
            panelCadLocal.Visible = false;
            panelCadCategoriaLocal.Visible = false;
            
           
        }
        private void hideSubMenu() {
            if (panelCadLocal.Visible == true) {
                panelCadLocal.Visible = false;
            }
            if (panelCadCategoriaLocal.Visible == true) {
                panelCadCategoriaLocal.Visible = false;
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

        

        private void button4_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        

        private void btnShowCadEndereco_Click(object sender, EventArgs e) {
            showSubMenu(panelCadLocal);
        }

        private void button1_Click(object sender, EventArgs e) {
            showSubMenu(panelCadCategoriaLocal);
        }
    }
}
