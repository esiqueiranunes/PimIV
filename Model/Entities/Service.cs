using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Entities {
    public class Service {

        private string nome;
        private string descricao;
        private double valor;
        private string categoria;
        private string classe;


        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Classe { get => classe; set => classe = value; }

        public Service(string nome, string descricao, double valor, string categoria, string classe) {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Categoria = categoria;
            Classe = classe;
        }

        public Service() {
            Classe = "Servico";
        }
    }
}
