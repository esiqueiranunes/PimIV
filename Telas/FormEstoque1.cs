using Control;
using Entities;
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
    public partial class FormEstoque1 : Form {
        public FormEstoque1() {
            InitializeComponent();
            CarregaGrid();
        }
        private void CarregaGrid() {
            string strWhere = " ";
            List<Produto> estoque = new Estoque().CarregarGridEstoque(strWhere);
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = estoque;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
