using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Entidades
{
   public class Peças
    {

        public int id { get; set; }

        public string nome { get; set; }

        public int preco { get; set; }

        public string descricao { get; set; }

        public string fabricante { get; set; }

        public int numOriginal { get; set; }

        public int preVenda { get; set; }

        public int idfornecedor { get; set; }
    }
}
