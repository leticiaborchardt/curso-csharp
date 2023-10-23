using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }

        public virtual decimal AplicarComissao()
        {
            return this.Salario * 0.10m;
        }
    }
}