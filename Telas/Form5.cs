using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using M.Entities;

namespace Telas {
    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();
            customizeDesign();
            AplicarEventos(tbValorServico);

        }
        CategoriaGeral categoria = new CategoriaGeral();
        private void customizeDesign() {
            panelCadServico.Visible = false;
            panelCadCategoria.Visible = false;


        }
        private void hideSubMenu() {
            if (panelCadServico.Visible == true) {
                panelCadServico.Visible = false;
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

        private void btnCadServico_Click(object sender, EventArgs e) {
            showSubMenu(panelCadServico);
        }

        private void btnCadCategoria_Click(object sender, EventArgs e) {
            showSubMenu(panelCadCategoria);
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e) {
            categoria.Classe = this.comboBoxCategoriaServico.Text;
            categoria.Nome = this.tbNomeCategoria.Text;

            if (Cadastros.salvarCategoria(categoria)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                this.comboBoxCategoriaServico.Text = "";
                this.tbNomeCategoria.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }
    }
    }

