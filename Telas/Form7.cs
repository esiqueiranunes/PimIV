using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using M.Entities;



namespace Telas {
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();

        }
        CategoriaGeral categoria = new CategoriaGeral();



        private void label10_Click(object sender, EventArgs e) {

        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e) {
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

        private void button7_Click_1(object sender, EventArgs e) {
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

        private void btnCadCategoria_Click(object sender, EventArgs e) {

        }
    }
}
