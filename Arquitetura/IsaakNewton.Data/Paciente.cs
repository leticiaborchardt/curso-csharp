using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaakNewton.Data
{
    public class Paciente : Pessoa
    {
        public string? Convenio { get; set; }
        public string? RestricaoMedica { get; set; }
    }
}