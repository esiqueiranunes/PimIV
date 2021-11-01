using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    public class Produto {
        private int id_produto;
        private string nome;
        private string marca;
        private string fornecedor;
        private string uni_medida;
        private DateTime validade;
        private int estoque;
        private double valor;
        private string nome_categoria;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }        
        public DateTime Validade { get => validade; set => validade = value; }      
        public double Valor { get => valor; set => valor = value; }
            
        public string Uni_medida { get => uni_medida; set => uni_medida = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public string Nome_categoria { get => nome_categoria; set => nome_categoria = value; }

        public Produto() {
        }

        public Produto(int id,string nome, string marca, string fornecedor, string unidMedida, DateTime validade, int qteEstoque, double valor, string categoria) {
            Nome = nome;
            Marca = marca;
            Fornecedor = fornecedor;
            Uni_medida = unidMedida;
            Validade = validade;
            Estoque = qteEstoque;
            Valor = valor;
            Nome_categoria = categoria;
            Id_produto = id;

        }
    }
}
