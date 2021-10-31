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
    public class Hospedagens {

        public static Boolean salvarReserva(Hospedagem hospedagem) {
            if (DAOReserva.reservar(hospedagem)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
