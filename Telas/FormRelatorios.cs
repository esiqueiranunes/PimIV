using Control;
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
    public partial class FormRelatorios : Form {
        public FormRelatorios() {
            InitializeComponent();
            
        }

        private string local = "SELECT L.NOME_LOCAL AS LOCAL, L.DESCRICAO AS 'DESCRIÇÃO', L.STATUS, C.NOME, C.VALOR, H.STATUS, H.QUANT_PESSOAS	FROM LOCAL L	INNER JOIN C_LOCAL C ON L.FK_C_LOCAL = C.ID_C_LOCAL	INNER JOIN HOSPEDAGEM H ON H.FK_LOCAL = L.ID_LOCAL";
        private string hospedagem = "SELECT H.ID_HOSPEDAGEM AS 'ID', P.NOME, P.CPF, L.NOME_LOCAL AS 'LOCAL', H.STATUS, H.DATA_ENTRADA,H.HORA_ENTRADA, H.DATA_SAIDA, H.HORA_SAIDA, H.QUANT_PESSOAS	FROM HOSPEDAGEM H INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA	INNER JOIN LOCAL L ON L.ID_LOCAL = H.FK_LOCAL";
        private string conta = "SELECT C.ID_CONTA, C.NOME AS TIPO, C.VALOR, C.STATUS, C.DESCRICAO, CA.NOME_CATEGORIA, P.NOME AS TITULAR, H.ID_HOSPEDAGEM	FROM CONTAS C	INNER JOIN CATEGORIA CA ON CA.ID_CATEGORIA = C.FK_CATEGORIA	INNER JOIN HOSPEDAGEM H ON H.ID_HOSPEDAGEM = C.FK_HOSPEDAGEM	INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA";
        private string pessoa = "SELECT P.NOME, P.CPF, P.SEXO, P.EMAIL, P.DATA_NASC AS IDADE, C.NOME_CATEGORIA AS CATEGORIA, E.NOME AS LOGRADOURO, E.BAIRRO, E.CIDADE, E.ESTADO	FROM PESSOA P	INNER JOIN CATEGORIA C ON P.FK_CATEGORIA = C.ID_CATEGORIA		INNER JOIN ENDERECO E ON E.FK_PESSOA = P.ID_PESSOA	ORDER BY P.NOME";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }
        public void ListarGrid(string tipo) {

            try {
                
                dataGridView1.DataSource = GridActions.Listar(tipo);

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        public void ListarGrid(string where1, string where2) {
            string strWhere = "";
            if (!string.IsNullOrWhiteSpace(where1) && !string.IsNullOrWhiteSpace(where2))
                strWhere = " WHERE H.DATA_ENTRADA = " + where1 + " AND H.DATA_SAIDA " + where2;

            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT H.STATUS, COUNT(*) AS QUANTIDADE FROM HOSPEDAGEM ")
                    .Append(" " + strWhere + " ")
                    .Append(" H GROUP BY H.STATUS ");



                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }



        private void btnListarLocal_Click(object sender, EventArgs e) {
            this.dataGridView1.DataSource = "";
            ListarGrid(local);
        }

        private void btnListarHospedagem_Click(object sender, EventArgs e) {
            this.dataGridView1.DataSource = "";
            ListarGrid(hospedagem);
        }

        private void btnListarConta_Click(object sender, EventArgs e) {
            this.dataGridView1.DataSource = "";
            ListarGrid(conta);
        }

        private void btnListarPessoas_Click(object sender, EventArgs e) {
            this.dataGridView1.DataSource = "";
            ListarGrid(pessoa);
        }
    }
}
