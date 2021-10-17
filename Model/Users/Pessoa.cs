using System;
using System.Collections.Generic;
using System.Text;
using Enums;
using Entities;

namespace Users {
    public class Pessoa {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public char sexo { get; set; }
        public string nascimento { get; set; }
        public int categoria { get; set; }
        //public Endereco endereco { get; set; }
        public string telefone { get; set; } 

        public Pessoa(string nome, string cpf, string email, char sexo, string nascimento, int categoria, /*Endereco endereco,*/ string telefone) {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sexo = sexo;
            this.nascimento = nascimento;
            this.categoria = categoria;
            //this.endereco = endereco;
            this.telefone = telefone;
        }

        public Pessoa() {
        }
    }
    }





