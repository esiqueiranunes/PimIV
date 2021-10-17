using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Users;

namespace Control {
    public class Cadastros {

        public static Boolean salvarCategoria(string classe, string nome) {
            if(DAOCategoria.cadastrarCategoria(classe, nome)) {
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
    }
}
