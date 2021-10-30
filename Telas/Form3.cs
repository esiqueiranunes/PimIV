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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }


        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void btnCadastrarUser_Click(object sender, EventArgs e) {

            Usuario user = new Usuario();
            bool teste = true;

            user.Login = this.tbEmailUser.Text;
            user.Senha = "hotel123";
            try {
                user.Nivel = (NivelUser)Enum.Parse(typeof(NivelUser), this.comboBoxNivel.Text);
            }
            catch {
                MessageBox.Show("Informe um nível válido");
                teste = false;
            }
            finally {
                this.comboBoxNivel.Focus();
            }


            if (teste == true) {
                if (Cadastros.salvarUsuario(user)) {
                    MessageBox.Show("Dados salvos com Sucesso!");
                    tbEmailUser.Clear();
                    comboBoxNivel.Text = "";
                }
            }
        }
    }
}
