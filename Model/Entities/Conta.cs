using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
    public class Conta {

        private string tituloConta;
        private double valor;
        private StatusConta status;
        private string descricao;
        private string categoria;
        private int hospedagem;

        public string TituloConta { get => tituloConta; set => tituloConta = value; }
        public double Valor { get => valor; set => valor = value; }
        public StatusConta Status { get => status; set => status = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Hospedagem { get => hospedagem; set => hospedagem = value; }

        public Conta() {            
        }

        public Conta(string tituloConta, double valor, StatusConta status, string descricao, string categoria, int hospedagem) {
            TituloConta = tituloConta;
            Valor = valor;
            Status = status;
            Descricao = descricao;
            Categoria = categoria;
            Hospedagem = hospedagem;
        }

    }
}
