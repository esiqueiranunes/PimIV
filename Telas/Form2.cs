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

namespace Telas {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            customizeDesign();
            // colocar o ponteiro no campo nome ao abrir o Form2 e demais tbm
        }
        Pessoa pessoa = new Pessoa();

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
            tbCpf.Clear();
            tbEmail.Clear();
            tbNascimento.Clear();
            tbCelular.Clear();
            tbBairro.Clear();
            tbLogradouro.Clear();
                    }
        private int setarCategoria(string nome) {
            if(nome == "Cliente") {
                return 1;
            }
            else {
                return 2;
            }
        }
        private void btmCadPessoa_Click(object sender, EventArgs e) {
            //"INSERT INTO PESSOA VALUES(@NOME,@CPF,@EMAIL,@NASCIMENTO,@FK_CATEGORIA,@SEXO, @TELEFONE)";
            /*pessoa.nome = this.tbNome.Text;
            pessoa.cpf = this.tbCpf.Text;
            pessoa.nascimento = this.tbNascimento.Text;
            pessoa.email = this.tbEmail.Text;
            pessoa.categoria = setarCategoria(this.comboBoxCategoria.Text);
            pessoa.sexo = Char.Parse(this.comboBoxSexo.Text);
            pessoa.telefone = this.tbCelular.Text;*/


            if (Cadastros.salvarPessoa(this.tbNome.Text, this.tbCpf.Text, this.tbNascimento.Text, this.tbEmail.Text,int.Parse(this.comboBoxCategoria.Text), Char.Parse(this.comboBoxSexo.Text), this.tbCelular.Text)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                limparTexbox();
            }


            else {
                MessageBox.Show("ERRO AO SALVAR DADOS");
            }
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
