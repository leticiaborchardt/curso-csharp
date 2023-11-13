using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaakNewton.Data
{
    public class Medico : Funcionario
    {
        public int NumeroCrm { get; set; }
        public string Especialidade { get; set; }
    }
}