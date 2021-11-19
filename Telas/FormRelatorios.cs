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
            ListarGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }
        public void ListarGrid() {

            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT H.STATUS, COUNT(*) AS QUANTIDADE FROM HOSPEDAGEM H GROUP BY H.STATUS ");


                dataGridView1.DataSource = GridActions.Listar(sb.ToString());

            }
            catch (SqlException erro) {
                MessageBox.Show("ERRO AO LISTAR: " + erro.Message);
            }
        }
        public void ListarGrid(string where1, string where2) {
            string strWhere = "";
            if (!string.IsNullOrWhiteSpace(where1) && !string.IsNullOrWhiteSpace(where2))
                strWhere = " WHERE H.DATA_ENTRADA = " + where1+ " AND H.DATA_SAIDA " + where2 ;

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

        private void btnGerarRelatorio_Click(object sender, EventArgs e) {

            
            string relatorio = this.comboBox1.Text;
            DateTime entrada = DateTime.Parse(this.dateTimePicker1.Text);
            DateTime saida = DateTime.Parse(this.dateTimePicker2.Text);

            if (relatorio == "Ocupação") {
                ListarGrid(entrada.ToString(), saida.ToString());
            }
        }
    }
}
