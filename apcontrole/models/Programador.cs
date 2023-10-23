using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class Programador : Funcionario
    {
        public override decimal AplicarComissao()
        {
            return this.Salario;
        }
    }
}