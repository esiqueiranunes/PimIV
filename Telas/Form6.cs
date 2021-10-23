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
using Entities;

namespace Telas {
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
            customizeDesign();
            //AplicarEventos(tbValorProduto);
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
            CategoriaGeral produto = new CategoriaGeral();
            produto.Classe = "Servico";
            produto.Nome = this.tbNomeCategoria.Text;

            if (Cadastros.salvarCategoriaProduto(produto)) {
                MessageBox.Show("Dados salvos com Sucesso!");

                this.tbNomeCategoria.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Produto produto = new Produto();
            produto.Nome = this.tbNomeProduto.Text;
            produto.Marca = this.tbMarca.Text;
            produto.Fornecedor = this.tbFornecedor.Text;
            produto.UnidMedida = this.comboBoxUnidade.Text;
            produto.Validade = DateTime.Parse(this.tbValidade.Text);
            produto.QteEstoque = int.Parse(this.numericUpDown1.Text);
            produto.Valor = double.Parse(this.tbValorProduto.Text);
            produto.Categoria = this.tbCategoriaProduto.Text;
            


            if (Cadastros.salvarProduto(produto)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                this.tbNomeProduto.Text = "";
                this.tbMarca.Text = "";
                this.tbFornecedor.Text = "";
                this.comboBoxUnidade.Text = "";
                this.tbValidade.Text = "";
                this.numericUpDown1.Text = "";
                this.tbValorProduto.Text = "";
                this.tbCategoriaProduto.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
