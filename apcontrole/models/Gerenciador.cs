using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class Gerenciador
    {
        public decimal TotalComissao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalComissao += funcionario.AplicarComissao();
        }
    }
}