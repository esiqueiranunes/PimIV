using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class Form0 : Form
    {
        Thread tela;
        public Form0()
        {
            InitializeComponent();
        }
        GridActions usuario = new GridActions();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e) {
            if (this.tbUsuario.Text == "" || this.tbSenha.Text == "") {
                MessageBox.Show("Campo em branco! Favor digitar USUÁRIO e SENHA.");
            }
            else {

                if (usuario.autenticarUsuario(this.tbUsuario.Text, this.tbSenha.Text)) {
                    this.Close();
                    tela = new Thread(Logar);
                    tela.SetApartmentState(ApartmentState.STA);
                    tela.Start();
                }
                else {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
        }
        private void Logar(object obj) {
            Application.Run(new Form1());
        }
    }
}
