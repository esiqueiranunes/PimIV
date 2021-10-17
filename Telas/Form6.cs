using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M.Entities;
using Control;

namespace Telas {
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
            customizeDesign();
            AplicarEventos(tbValorProduto);
        }
        CategoriaGeral categoria6 = new CategoriaGeral();
        
        private void customizeDesign() {
            panelCadProduto.Visible = false;
            panelCadCategoria.Visible = false;

        }
        private void hideSubMenu() {
            if (panelCadProduto.Visible == true) {
                panelCadProduto.Visible = false;
            }
            if (panelCadCategoria.Visible == true) {
                panelCadCategoria.Visible = false;
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
        private void RetornarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        private void TirarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e) {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)) {
                if (e.KeyChar == ',') {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        protected void AplicarEventos(TextBox txt) {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tbValorProduto_TextChanged(object sender, EventArgs e) {

        }

        private void btnCadServico_Click(object sender, EventArgs e) {
            showSubMenu(panelCadProduto);
        }

        private void btnCadCategoria_Click(object sender, EventArgs e) {
            showSubMenu(panelCadCategoria);
        }

        private void button7_Click(object sender, EventArgs e) {
            categoria6.Classe = this.comboBoxCategoriaServico6.Text;
            categoria6.Nome = this.tbNomeCategoria6.Text;

            if (Cadastros.salvarCategoria(categoria6)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                this.comboBoxCategoriaServico6.Text = "";
                this.tbNomeCategoria6.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }
    }
}
