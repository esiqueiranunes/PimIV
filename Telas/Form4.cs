using M.Entities;
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

namespace Telas {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
            customizeDesign();

        }
        CategoriaLocal categoria = new CategoriaLocal();
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

        private void btnCadastrarCategoriaLocal_Click(object sender, EventArgs e) {
            categoria.nome = this.tbCategoriaLocal.Text;
            categoria.qteMaxPessoas = int.Parse(this.numericUpDownQuantidade.Text);
            categoria.valor = double.Parse(this.tbValorLocal.Text);
            categoria.descontoMax = double.Parse(this.tbDescontoLocal.Text);

            if (Cadastros.salvarCategoriaLocal(categoria)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                this.tbCategoriaLocal.Text = "";
                this.numericUpDownQuantidade.Text = "";
                this.tbValorLocal.Text = "";
                this.tbDescontoLocal.Text = "";
            }
            else {
                MessageBox.Show("Erro ao salvar os dados!");
            }
        }
    }
    }

