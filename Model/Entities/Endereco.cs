using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
    public class Endereco {
        private string logradouro;
        private string bairro;
        private string cidade;
        private Estado uf;

        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public Estado Uf { get => uf; set => uf = value; }

        public Endereco(string logradouro, string bairro, string cidade, Estado uf) {
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco() {
        }
    }
}
