using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace Entities {
    class Hospedagem {

        public StatusHospedagem status { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime horarioEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime horarioSaida { get; set; }
        public int qtePessoas { get; set; }
       
    }
}
