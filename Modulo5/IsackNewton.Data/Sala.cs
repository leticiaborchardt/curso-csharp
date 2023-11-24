using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsackNewton.Data
{

    public class Sala : Base
    {
        public string Numero { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nNumero: {Numero}";
        }
    }
}
