using Control;
using Entities;
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

namespace Telas {
    public partial class FormEstoque1 : Form {
        public FormEstoque1() {
            InitializeComponent();
            ListarGrid();
        }

        public void ListarGrid() {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT P.ID_PRODUTO, P.NOME , P.MARCA, P.FORNECEDOR, P.UNI_MEDIDA, P.VALIDADE, P.ESTOQUE, P.VALOR, C.NOME_CATEGORIA ")
                    .Append(" FROM PRODUTOS P ")
                    .Append("INNER JOIN CATEGORIA C ON P.FK_CATEGORIA = C.ID_CATEGORIA ")
                    .Append(" ORDER BY ID_PRODUTO");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro){
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        public void ListarGrid(string strWhere) {

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE NOME = '" + strWhere + "'";
            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT P.ID_PRODUTO, P.NOME , P.MARCA, P.FORNECEDOR, P.UNI_MEDIDA, P.VALIDADE, P.ESTOQUE, P.VALOR, C.NOME_CATEGORIA ")
                    .Append(" FROM PRODUTOS P ")
                    .Append("INNER JOIN CATEGORIA C ON P.FK_CATEGORIA = C.ID_CATEGORIA ")
                    .Append(" " + strWhere + " ")
                    .Append("ORDER BY NOME ");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        public void ListarGridCriterios(string strWhere, string strWhere2) {

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE NOME = '" + strWhere + "'";

            if (!string.IsNullOrWhiteSpace(strWhere2))
                strWhere2 = " FK_CATEGORIA = (SELECT ID_CATEGORIA FROM CATEGORIA WHERE '" + strWhere2 + "'= NOME_CATEGORIA)" ;
            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT P.ID_PRODUTO, P.NOME , P.MARCA, P.FORNECEDOR, P.UNI_MEDIDA, P.VALIDADE, P.ESTOQUE, P.VALOR, C.NOME_CATEGORIA ")
                   .Append(" FROM PRODUTOS P ")
                   .Append("INNER JOIN CATEGORIA C ON P.FK_CATEGORIA = C.ID_CATEGORIA ")
                   .Append(" " + strWhere + " ")
                   .Append(" AND ")
                    .Append(" " + strWhere2 + "")
                    .Append("ORDER BY NOME ");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        private void CarregaGrid() {

            
            /*string strWhere = " ";
            List<Produto> estoque = new Estoque().CarregarGridEstoque(strWhere);
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = estoque;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;*/
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            string query = this.comboBox1.Text;

            ListarGrid(query);
        }

        private void btnListarGeral_Click(object sender, EventArgs e) {
            ListarGrid();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            string query = this.comboBox1.Text;
            string query2 = this.tbNomeProduto.Text;

            ListarGridCriterios(query2, query);
        }

        private void FormEstoque1_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet3.CATEGORIA'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIATableAdapter.Fill(this.hOTELDataSet3.CATEGORIA);
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet3.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.hOTELDataSet3.PRODUTOS);

        }
    }
}
