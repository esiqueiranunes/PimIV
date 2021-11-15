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
    public partial class FormFinanceiro2 : Form {
        public FormFinanceiro2() {
            InitializeComponent();
            ListarGrid();
        }

        private void label9_Click(object sender, EventArgs e) {

        }
        public void ListarGrid() {

            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT C.ID_CONTA, P.NOME,C.VALOR, C.STATUS, C.DESCRICAO, CA.NOME_CATEGORIA,  H.ID_HOSPEDAGEM ")
                    .Append("  FROM CONTAS C ")
                    .Append(" INNER JOIN CATEGORIA CA ON CA.ID_CATEGORIA = C.FK_CATEGORIA ")
                    .Append(" INNER JOIN HOSPEDAGEM H ON H.ID_HOSPEDAGEM = C.FK_HOSPEDAGEM ")
                    .Append(" INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA ");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
        public void ListarGrid(string strWhere) {

            if (!string.IsNullOrWhiteSpace(strWhere))
                strWhere = " WHERE C.FK_HOSPEDAGEM = " + strWhere + "";
            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT C.ID_CONTA, P.NOME,C.VALOR, C.STATUS, C.DESCRICAO, CA.NOME_CATEGORIA,  H.ID_HOSPEDAGEM ")
                    .Append("  FROM CONTAS C ")
                    .Append(" INNER JOIN CATEGORIA CA ON CA.ID_CATEGORIA = C.FK_CATEGORIA ")
                    .Append(" INNER JOIN HOSPEDAGEM H ON H.ID_HOSPEDAGEM = C.FK_HOSPEDAGEM ")
                    .Append(" INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA ")
                    .Append(" " + strWhere + " ");                   

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }

        private void FormFinanceiro2_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet2.HOSPEDAGEM'. Você pode movê-la ou removê-la conforme necessário.
            this.hOSPEDAGEMTableAdapter.Fill(this.hOTELDataSet2.HOSPEDAGEM);

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            string id = this.comboBox2.Text;

            ListarGrid(id);

            

        }
    }
}
