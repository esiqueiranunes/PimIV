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
    public class Hospedagens {

        public static Boolean salvarReserva(Hospedagem hospedagem) {
            if (DAOReserva.reservar(hospedagem)) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<Hospedagem> CarregarGridHospedagem(string strWhere) {
            return new DAL.DAOReserva().CarregarGridDao(strWhere);
        }

        public static DataTable CarregarHospedagem(string query) {
            return new DAL.DAOReserva().directQuery(query);

                    }

        public static int RealizarCheck(int id, string query) {
            return new DAL.DAOReserva().Check(id, query);
        }
    }
}
