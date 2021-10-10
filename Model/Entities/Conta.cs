using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
    class Conta {
        public string tituloConta { get; set; }
        public double valor { get; set; }
        public StatusConta status { get; set; }
        public string descricao { get; set; }
    }
}
