using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
    public class Endereco {
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public Estado uf { get; set; }
    }
}
