using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaakNewton.Data
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }   
        public string Turno { get; set; }
        public decimal Salario { get; set; }
    }
}