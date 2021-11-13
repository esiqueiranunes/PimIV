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
    public class GridActions {

        public static int Excluir(int id, string query) {
            return new DAL.BD().ExcluirRegistro(id, query);
        }

        public static DataTable Listar(string query) {
            return new DAL.BD().ListarGrid(query);
        }
    }

}
