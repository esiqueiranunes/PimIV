using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Users;
using M.Entities;
using Entities;
using System.Data;


namespace Control {
    public class Contas {

        public static Boolean SalvarConta(Conta conta) {
            if (DAOFinanceiro.CadastrarContas(conta)){
                return true;
            }
            else {
                return false;
            }
        }
    }
}
