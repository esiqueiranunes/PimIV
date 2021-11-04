using System;
using System.Collections.Generic;
using System.Text;
using Enums;
using Users;

namespace Entities {
    public class Hospedagem {
        private int idHospedagem;
        private StatusHospedagem status;
        private DateTime dataEntrada;
        private TimeSpan horarioEntrada;
        private DateTime dataSaida;
        private TimeSpan horarioSaida;
        private int qtePessoas;
        private string titular;
        private string localHospedagem;
        private double valor;
        
        
        public StatusHospedagem Status { get => status; set => status = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public TimeSpan HorarioEntrada { get => horarioEntrada; set => horarioEntrada = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public TimeSpan HorarioSaida { get => horarioSaida; set => horarioSaida = value; }
        public int QtePessoas { get => qtePessoas; set => qtePessoas = value; }
        public string Titular { get => titular; set => titular = value; }
        public string LocalHospedagem { get => localHospedagem; set => localHospedagem = value; }
        public double Valor { get => valor; set => valor = value; }
        public int IdHospedagem { get => idHospedagem; set => idHospedagem = value; }

        public Hospedagem() {
           
        }

        public Hospedagem(StatusHospedagem status, DateTime dataEntrada, TimeSpan horarioEntrada, DateTime dataSaida, TimeSpan horarioSaida, int qtePessoas, string titular, string localHospedagem) {
            Status = status;
            DataEntrada = dataEntrada;
            HorarioEntrada = horarioEntrada;
            DataSaida = dataSaida;
            HorarioSaida = horarioSaida;
            QtePessoas = qtePessoas;
            Titular = titular;
            LocalHospedagem = localHospedagem;
            Valor = 0.0;

        }
    }
}
