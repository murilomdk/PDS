using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Entidades
{
   public  class Ordem
    {

        public int id { get; set; }

        public string tipo { get; set; }

        public int fornecedor { get; set; }

        public int motorista { get; set; }

        public int veiculo { get; set; }

        public string descricao { get; set; }

        public string Status { get; set; }

    }
}
