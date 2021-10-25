using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using Control;



using Enums;
using System.Data.SqlClient;

namespace Telas {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            customizeDesign();
            // colocar o ponteiro no campo nome ao abrir o Form2 e demais tbm
        }
        

        private void customizeDesign() {
            panelEndereco.Visible = false;
        }
        private void hideSubMenu() {
            if (panelEndereco.Visible == true) {
                panelEndereco.Visible = false;
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
            tbNome.Focus();
            tbNome.Clear();
            tbCpf.Clear();
            tbEmail.Clear();
            tbNascimento.Clear();
            tbCelular.Clear();
            tbBairro.Clear();
            tbLogradouro.Clear();
            comboBoxSexo.Items.Clear();
            comboBoxCategoria.Items.Clear();
        }
        
        private void btmCadPessoa_Click(object sender, EventArgs e) {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = this.tbNome.Text;
            pessoa.Cpf = this.tbCpf.Text;
            pessoa.Nascimento = DateTime.Parse(this.tbNascimento.Text);
            pessoa.Email = this.tbEmail.Text;
            pessoa.Categoria = this.comboBoxCategoria.Text;
            //pessoa.Sexo = char.Parse(this.comboBoxSexo.Text);
            pessoa.Sexo = (Sexo)Enum.Parse(typeof(Sexo),this.comboBoxSexo.Text);            
            pessoa.Telefone = this.tbCelular.Text;

            if (Cadastros.salvarPessoa(pessoa)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                limparTexbox();
            }
            else {
                MessageBox.Show("ERRO AO SALVAR DADOS");
            }
            /*try {
                if (Cadastros.salvarPessoa(pessoa)) {
                    MessageBox.Show("Dados salvos com Sucesso!");
                    limparTexbox();
                }
            }
            catch (SqlException erro) {

                MessageBox.Show("ERRO AO SALVAR DADOS: " +  erro);
            }*/


        }
        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void btnShowCadEndereco_Click(object sender, EventArgs e) {
            showSubMenu(panelEndereco);
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button4_Click_1(object sender, EventArgs e) {
            this.Close();
        }

       
    }
}
