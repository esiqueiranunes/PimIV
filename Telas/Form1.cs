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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign() {
            panelMenuCadastro.Visible = false;
            panelMenuHospedagem.Visible = false;
            panelMenuEstoque.Visible = false;
            panelMenuFinanceiro.Visible = false;
        }
        private void hideSubMenu() {
            if(panelMenuCadastro.Visible == true) {
                panelMenuCadastro.Visible = false;
            }
            if (panelMenuHospedagem.Visible == true) {
                panelMenuHospedagem.Visible = false;
            }
            if (panelMenuEstoque.Visible == true) {
                panelMenuEstoque.Visible = false;
            }
            if (panelMenuFinanceiro.Visible == true) {
                panelMenuFinanceiro.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu) {
            if(subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            
        }
        

        private void Form1_Load(object sender, EventArgs e) {
           
        }
        // CADASTRO
        #region CADASTRO


        private void btnCadastro_Click(object sender, EventArgs e) {
            showSubMenu(panelMenuCadastro);
        }

        private void btnPessoas_Click(object sender, EventArgs e) {
            openChildForm(new Form2());
            // criar Forms
            hideSubMenu();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            // criar Forms
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void btnLocais_Click(object sender, EventArgs e) {
            openChildForm(new Form4());
            
            hideSubMenu();
        }

        private void btnServicos_Click(object sender, EventArgs e) {
            openChildForm(new Form5());
            hideSubMenu();
        }

        private void btnProdutos_Click(object sender, EventArgs e) {
            // criar Forms
            openChildForm(new Form6());
            hideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e) {
            // criar Forms
            openChildForm(new Form7());
            hideSubMenu();
        }

        
        #endregion
        // HOSPEDAGEM
        #region HOSPEDAGEM

        private void button1_Click(object sender, EventArgs e) {
            showSubMenu(panelMenuHospedagem);
        }
        private void btnReservar_Click(object sender, EventArgs e) {
            openChildForm(new FormHospedagem1());            
            hideSubMenu();
        }
        private void btnAtualizarHospedagem_Click(object sender, EventArgs e) {
            openChildForm(new FormHospedagem2());
            hideSubMenu();
        }


        private void btnListar_Click(object sender, EventArgs e) {
            // criar Forms
            hideSubMenu();
        }
        #endregion
        // ESTOQUE
        #region ESTOQUE

        private void btnEstoque_Click(object sender, EventArgs e) {
            showSubMenu(panelMenuEstoque);
        }

        private void btnAnaliseEstoque_Click(object sender, EventArgs e) {
            openChildForm(new FormEstoque1());
            hideSubMenu();
        }

        private void btnContagemEstoque_Click(object sender, EventArgs e) {
            openChildForm(new FormEstoque2());
            hideSubMenu();
        }
        #endregion
        //FINANCEIRO
        #region FINANCEIRO

        private void btnFinanceiro_Click(object sender, EventArgs e) {
            showSubMenu(panelMenuFinanceiro);
        }

        private void btnTransacao_Click(object sender, EventArgs e) {
            openChildForm(new FormFinanceiro1());
            hideSubMenu();
        }

        private void btnContas_Click(object sender, EventArgs e) {
            openChildForm(new FormFinanceiro2());
            hideSubMenu();
        }
        #endregion
        // OPÇÕES
        #region RELATORIOS

        private void button1_Click_1(object sender, EventArgs e) {
            openChildForm(new FormRelatorios());
            hideSubMenu();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
