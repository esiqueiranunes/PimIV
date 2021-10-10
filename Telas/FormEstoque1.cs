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
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
