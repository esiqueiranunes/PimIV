using System;
using System.Collections.Generic;
using System.Text;
using Enums;
using Entities;

namespace Users {
    public class Pessoa {
        private string nome { get; set; }
        private string cpf { get; set; }
        private string email { get; set; }
        private Sexo sexo { get; set; }
        private DateTime nascimento { get; set; }
        private CategoriaPessoa categoria { get; set; }
        private Endereco endereco { get; set; }
        private List<Telefone> telefone { get; set; } = new List<Telefone>();

        public Pessoa(string nome, string cpf, string email, Sexo sexo, DateTime nascimento, CategoriaPessoa categoria, Endereco endereco, List<Telefone> telefone) {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sexo = sexo;
            this.nascimento = nascimento;
            this.categoria = categoria;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Pessoa() {
        }
    }
    }





