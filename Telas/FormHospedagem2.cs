using Control;
using DAL;
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
    public partial class FormHospedagem2 : Form {
        public FormHospedagem2() {
            InitializeComponent();
           // customizeDesign();
            listaGrid();
            

        }



        public void  listaGrid() {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            try {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT H.ID_HOSPEDAGEM, P.NOME, P.CPF, L.NOME_LOCAL AS LOCAL, H.STATUS, H.DATA_ENTRADA ,H.HORA_ENTRADA, H.DATA_SAIDA , H.HORA_SAIDA, H.QUANT_PESSOAS ")
                    .Append(" FROM HOSPEDAGEM H ")
                    .Append("INNER JOIN PESSOA P ON P.ID_PESSOA = H.FK_PESSOA ")
                    .Append("INNER JOIN LOCAL L ON L.ID_LOCAL = H.FK_LOCAL");

                dataGridView1.DataSource = GridActions.Listar(sb.ToString());
                
            }
            catch {

                MessageBox.Show("ERRO AO LISTAR");
            }
        }
        private void DataGridView2_Load(object sender, EventArgs e) {
            //dataGridView1.DataSource = GetDataHospedagem();
        }



        private void customizeDesign() {
            panelAtualizarHospedagem.Visible = false;
            
        }
        private void hideSubMenu() {
            if (panelAtualizarHospedagem.Visible == true) {
                panelAtualizarHospedagem.Visible = false;
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

            

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAtualizarHospedagem_Click(object sender, EventArgs e) {
            //showSubMenu(panelAtualizarHospedagem);
        }

        private void FormHospedagem2_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet2.HOSPEDAGEM'. Você pode movê-la ou removê-la conforme necessário.
            this.hOSPEDAGEMTableAdapter.Fill(this.hOTELDataSet2.HOSPEDAGEM);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            listaGrid();
        }

        private void btnListarReservas_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            string query = "UPDATE HOSPEDAGEM SET DATA_ENTRADA = CONVERT (date, GETDATE()), HORA_ENTRADA = CONVERT (time, GETDATE()), STATUS = 'CHECKIN' WHERE ID_HOSPEDAGEM = @ID";
            
            int id;
            
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());       
                       
         
            if (Hospedagens.RealizarCheck(Convert.ToInt32(id), query) != 0) {
                MessageBox.Show("Check-in realizado com sucesso!");
            }
            


            listaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            
                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE FROM HOSPEDAGEM")
                  .Append("WHERE ID_HOSPEDAGEM = @ID");

            string query = "DELETE FROM HOSPEDAGEM WHERE ID_HOSPEDAGEM = @ID";

            int id= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            GridActions.Excluir(Convert.ToInt32(id), query);
            listaGrid();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            this.tbIDHospedagem.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e) {
            string query = "UPDATE HOSPEDAGEM SET DATA_SAIDA = CONVERT (date, GETDATE()), HORA_SAIDA = CONVERT (time, GETDATE()), STATUS = 'CHECKOUT' WHERE ID_HOSPEDAGEM = @ID";

            

            int id= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            if (Hospedagens.RealizarCheck(Convert.ToInt32(id), query) != 0) {
                MessageBox.Show("Check-out realizado com sucesso!");
            }
            listaGrid();
        }
    }
}
