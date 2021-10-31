using Control;
using Entities;
using Enums;
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
    public partial class FormHospedagem1 : Form {
        public FormHospedagem1() {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign() {
            panelCadReserva.Visible = false;
            panelListarReserva.Visible = false;


        }
        private void hideSubMenu() {
            if (panelCadReserva.Visible == true) {
                panelCadReserva.Visible = false;
            }
            if (panelListarReserva.Visible == true) {
                panelListarReserva.Visible = false;
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
        private void limparTexbox() {
            tbCPF.Focus();
            tbCPF.Clear();
            tbCpfTitular.Clear();
            tbDataEntrada.Clear();
            tbDataSaida.Clear();
            tbHoraSaida.Clear();
            tbHoraEntrada.Clear();
            tbID.Clear();
            comboBoxLocal.Text="";
            comboBoxSituacao.Text = "";
            comboBoxStatus.Text = "";
            numericUpDownHospedes.Value = 0;
        }

        private void btnCadReserva_Click(object sender, EventArgs e) {
            showSubMenu(panelCadReserva);
        }

        private void button3_Click(object sender, EventArgs e) {
            showSubMenu(panelListarReserva);
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormHospedagem1_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'hOTELDataSet.LOCAL'. Você pode movê-la ou removê-la conforme necessário.
            this.lOCALTableAdapter.Fill(this.hOTELDataSet.LOCAL);

        }

        private void btnReservar_Click(object sender, EventArgs e) {
            bool teste = true;
            Hospedagem hospedagem = new Hospedagem();
            hospedagem.Titular= this.tbCPF.Text;
            hospedagem.LocalHospedagem = this.comboBoxLocal.Text;
            hospedagem.QtePessoas = int.Parse(this.numericUpDownHospedes.Text);


            if (teste == true) {
                try {
                    hospedagem.Status = (StatusHospedagem)Enum.Parse(typeof(StatusHospedagem), this.comboBoxStatus.Text);
                }
                catch {
                    MessageBox.Show("Informe um status válido");
                    teste = false;
                }
                finally {
                    this.comboBoxStatus.Focus();
                }
            }
            if (teste == true) {
                try {
                    if (DateTime.Parse(this.tbDataEntrada.Text) > DateTime.Today) {
                        hospedagem.DataEntrada = DateTime.Parse(this.tbDataEntrada.Text);
                    }
                    else {
                        MessageBox.Show("Data de entrada inválida");
                        teste = false;
                    }

                }
                catch {
                    MessageBox.Show("Data de entrada inválida");
                    teste = false;
                }
                finally {
                    this.tbDataEntrada.Focus();
                }
            }
            if (teste == true) {
                try {
                    hospedagem.HorarioEntrada = TimeSpan.Parse(this.tbHoraEntrada.Text);

                }
                catch {
                    MessageBox.Show("Horário de entrada inválido");
                    teste = false;
                }
                finally {
                    this.tbHoraEntrada.Focus();
                }
            }
            if (teste == true) {
                try {
                    hospedagem.HorarioSaida = TimeSpan.Parse(this.tbHoraSaida.Text);

                }
                catch {
                    MessageBox.Show("Horário de saída inválido");
                    teste = false;
                }
                finally {
                    this.tbHoraSaida.Focus();
                }
            }
            if (teste == true) {
                try {
                    if (DateTime.Parse(this.tbDataEntrada.Text) < DateTime.Parse(this.tbDataSaida.Text)) {
                        hospedagem.DataSaida = DateTime.Parse(this.tbDataSaida.Text);
                    }
                    else {
                        MessageBox.Show("Data de saída menor do que a de entrada");
                        teste = false;
                    }
                }
                catch {
                    MessageBox.Show("Data de entrada inválida");
                    teste = false;
                }
                finally {
                    this.tbDataSaida.Focus();
                }
            }


            if (teste == true) {
                if (Hospedagens.salvarReserva(hospedagem)) {
                    MessageBox.Show("Dados salvos com Sucesso!");
                    limparTexbox();
                }

            }
        }
    }
}
