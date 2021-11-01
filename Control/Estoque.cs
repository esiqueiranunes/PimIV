using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    public class Estoque {

        public List<Produto> CarregarGridEstoque(string strWhere) {
            return new DAL.DAOEstoque().CarregarGridDao(strWhere);
        }
    }
}
