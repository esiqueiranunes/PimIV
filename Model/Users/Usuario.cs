using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Enums;

namespace Users {
    public class Usuario {
        private string login;
        private string senha;
        private NivelUser nivel;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public NivelUser Nivel { get => nivel; set => nivel = value; }

        public Usuario() {

        }
        public Usuario(string login, string senha, NivelUser nivel) {
            Login = login;
            Senha = senha;
            Nivel = nivel;
        }
    }


    // corrigir o diagrama de classes
    // fazer usuário herdar de pessoa, para que cliente e funcionario herdem do mesmo
    //implementar os metodos que um usuario geral pode fazer
}
