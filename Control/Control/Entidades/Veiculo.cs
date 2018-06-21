using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Entidades
{
    public class Veiculo
    {
        public Int32 Id { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public Int32 chassi { get; set; }

        public string placa { get; set; }

        public Int32 frota { get; set; }

        public Int32 ano { get; set; }

        public Int32 km { get; set; }

        public string motorista { get; set; }

    }
}
