using System;
using System.Collections.Generic;
using System.Text;
using Enums;
using Entities;

namespace Users {
    public class Pessoa {
        private string nome;
        private string cpf;
        private string email;
        private Sexo sexo;
        private DateTime nascimento;
        private string categoria;
        private Endereco endereco;
        private string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public Sexo Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Pessoa(string nome, string cpf, string email, Sexo sexo, DateTime nascimento, string categoria, Endereco endereco, string telefone) {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Sexo = sexo;
            this.Nascimento = nascimento;
            this.Categoria = categoria;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public Pessoa() {
        }
    }
    }





