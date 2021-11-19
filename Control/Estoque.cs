using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    public class Estoque {

        
        public int AlterarProduto(Produto produto) {
            return new DAL.DAOEstoque().AlterarProduto(produto);
        }
    }
}
