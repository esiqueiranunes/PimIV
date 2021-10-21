using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
   public class Local {
        private string nome;
        private string descricao;
        private StatusLocal status;
        private string categoria;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public StatusLocal Status { get => status; set => status = value; }

        public Local() {
            Status = StatusLocal.Desocupado;
        }

        public Local(string nome, string descricao, string categoria, StatusLocal status) {
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;
            Status = status;
        }
    }
}
