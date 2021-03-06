using M.Entities;
using Entities;
using System;
using Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

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
        private void limparTexbox() {
            this.tbCategoriaLocal.Clear();
            this.tbValorLocal.Clear();
            this.tbDescontoLocal.Clear();

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

        private void btnCadastrarCategoriaLocal_Click(object sender, EventArgs e) {
            CategoriaLocal categoria = new CategoriaLocal();
            bool teste = true;
            categoria.nome = this.tbCategoriaLocal.Text;

           
            if (teste == true) {
                try {
                    categoria.valor = double.Parse(this.tbValorLocal.Text);

                }
                catch {
                    MessageBox.Show("Corrija o valor base do local");
                    teste = false;
                }
                finally {
                    this.tbValorLocal.Focus();
                }
            }
            if (teste == true) {
                try {
                    categoria.descontoMax = double.Parse(this.tbDescontoLocal.Text);

                }
                catch {
                    MessageBox.Show("Corrija a máximo de desconto");
                    teste = false;
                }
                finally {
                    this.tbDescontoLocal.Focus();
                }
            }


            if (teste == true) {
                if (Cadastros.salvarCategoriaLocal(categoria)) {
                    MessageBox.Show("Dados salvos com Sucesso!");
                    limparTexbox();
                }
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e) {
            Local local = new Local();
            local.Nome = this.tbNomeLocal.Text;
            local.Descricao = this.tbDescricaoLocal.Text;
            /*local.Status = (StatusLocal)Enum.Parse(typeof(StatusLocal),this.comboBoxTipoLocal.Text);*/
            local.Categoria = this.comboBoxTipoLocal.Text;


            if (Cadastros.salvarLocal(local)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                limparTexbox();
            }
            
        }
    }
}

