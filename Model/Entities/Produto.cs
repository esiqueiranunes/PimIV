using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    public class Produto {
        private string nome;
        private string marca;
        private string fornecedor;
        private string unidMedida;
        private DateTime validade;
        private int qteEstoque;
        private double valor;
        private string categoria;

        public string Nome { get => nome; set => nome = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string UnidMedida { get => unidMedida; set => unidMedida = value; }
        public DateTime Validade { get => validade; set => validade = value; }
        public int QteEstoque { get => qteEstoque; set => qteEstoque = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public Produto() {
        }

        public Produto(string nome, string marca, string fornecedor, string unidMedida, DateTime validade, int qteEstoque, double valor, string categoria) {
            Nome = nome;
            Marca = marca;
            Fornecedor = fornecedor;
            UnidMedida = unidMedida;
            Validade = validade;
            QteEstoque = qteEstoque;
            Valor = valor;
            Categoria = categoria;

        }
    }
}
