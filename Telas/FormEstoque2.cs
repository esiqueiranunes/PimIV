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
using Entities;

namespace Telas {
    public partial class FormEstoque2 : Form {
        public FormEstoque2() {
            InitializeComponent();
            ListarGrid();
        }

        public void ListarGrid() {
            
            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ID_PRODUTO, NOME, MARCA, FORNECEDOR, UNI_MEDIDA, VALIDADE, ESTOQUE,VALOR ")
                    .Append("  FROM PRODUTOS  ")
                    .Append("ORDER BY NOME ");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }

        public void ListarGrid(string strWhere) {

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE NOME = '" + strWhere + "'";
            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ID_PRODUTO, NOME, MARCA, FORNECEDOR, UNI_MEDIDA, VALIDADE, ESTOQUE,VALOR ")
                    .Append("  FROM PRODUTOS  ")
                    .Append(" " + strWhere + " ")
                    .Append("ORDER BY NOME ");
                    
                dataGridView1.DataSource = GridActions.Listar(sb.ToString());
                
            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            string query = this.comboBox1.Text;

            ListarGrid(query);

            
        }

        private void FormEstoque2_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'hOTELnomeProdutos1.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter1.Fill(this.hOTELnomeProdutos1.PRODUTOS);
            // TODO: esta linha de código carrega dados na tabela 'hOTELnomeProdutos.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter1.Fill(this.hOTELnomeProdutos.PRODUTOS);
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet3.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.hOTELDataSet3.PRODUTOS);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.pRODUTOSTableAdapter1.FillBy(this.hOTELnomeProdutos.PRODUTOS);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            Produto produto = new Produto();
            
            try {
                produto.Id_produto = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                produto.Validade = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());                
                produto.Estoque = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                produto.Valor = double.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                new Estoque().AlterarProduto(produto);
                MessageBox.Show("Dados do produto atualizado");
                
            }
            catch(Exception erro) {
                MessageBox.Show(erro.Message);
            }          
            
        }

        private void btnListarGeral_Click(object sender, EventArgs e) {
            ListarGrid();
        }
    }
}
