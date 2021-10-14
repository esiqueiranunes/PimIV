using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Control {
    public class Cadastros {

        public static Boolean salvarCategoria(string classe, string nome) {
            if(DAOCadastros.cadastrarCategoria(classe, nome)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
