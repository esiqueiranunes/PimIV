using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    class Produto {
        public string nome { get; set; }
        public string marca { get; set; }
        public string fornecedor { get; set; }
        public string unidMedida { get; set; }
        public DateTime validade { get; set; }
        public int qteEstoque { get; set; }
        public double valor { get; set; }

    }
}
