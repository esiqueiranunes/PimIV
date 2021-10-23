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
            //AplicarEventos(tbValorServico);

        }
        
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

            CategoriaGeral categoria = new CategoriaGeral();
            categoria.Classe = "Servico";
            categoria.Nome = this.tbNomeCategoria.Text;

            if (Cadastros.salvarCategoriaService(categoria)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                
                this.tbNomeCategoria.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e) {
            Service service = new Service();
            service.Nome = this.tbNomeServico.Text;
            service.Descricao = this.tbDescricaoServico.Text;
            service.Valor = double.Parse(this.tbValorServico.Text);
            service.Categoria = this.tbCategoriaServico.Text;


            if (Cadastros.salvarService(service)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                this.tbNomeServico.Text= "";
                this.tbDescricaoServico.Text = "";
                this.tbValorServico.Text = "";
                this.tbCategoriaServico.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }
    }
    }

