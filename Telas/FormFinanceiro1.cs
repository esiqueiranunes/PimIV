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
using Enums;
using Control;

namespace Telas {
    public partial class FormFinanceiro1 : Form {
        public FormFinanceiro1() {
            InitializeComponent();
            
        }
        private void RetornarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        private void TirarMascara(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e) {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)) {
                if (e.KeyChar == ',') {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        protected void AplicarEventos(TextBox txt) {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }


        private void FormFinanceiro1_Load(object sender, EventArgs e) {

        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void Limpar() {
            this.tbTitulo.Clear();
           this.tbDescricao.Clear();
            this.comboBoxCategoria.Text = "";
            this.comboBoxStatus.Text = "";
            this.tbValor.Clear();
            this.tbIdHospedagem.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Conta conta = new Conta();

            conta.TituloConta = this.tbTitulo.Text;
            conta.Descricao = this.tbDescricao.Text;
            conta.Categoria = this.comboBoxCategoria.Text;              
            conta.Status = (StatusConta)Enum.Parse(typeof(StatusConta), this.comboBoxStatus.Text);
            conta.Valor = double.Parse(this.tbValor.Text);
            conta.Hospedagem = int.Parse(this.tbIdHospedagem.Text);

            if (Contas.SalvarConta(conta)) {
                MessageBox.Show("Dados salvos com Sucesso!");
                Limpar();
            }


        }
    }
}
