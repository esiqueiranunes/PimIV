using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Users;
using M.Entities;
using Entities;

namespace Control {
    public class Cadastros {

        public static Boolean salvarCategoria(CategoriaGeral categoria) {
            if(DAOCategoria.cadastrarCategoria(categoria)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static Boolean salvarPessoa(string nome, string cpf, string nascimento, string email, int categoria, char sexo, string telefone) {
            if (DAOPessoa.cadastrarPessoa(nome, cpf, nascimento, email, categoria, sexo, telefone)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static Boolean salvarLocal(Local local) {
            if (DAOLocal.cadastrarLocal(local)) {
                return true;
            }
            else {
                return false;
            }
        }

        public static Boolean salvarCategoriaLocal(CategoriaLocal categoria) {
            if (DAOLocal.cadastrarCategoriaLocal(categoria)){
                return true;
            }
            else {
                return false;
            }
        }
    }
}
