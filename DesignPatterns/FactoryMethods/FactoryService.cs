using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Enums;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods
{
    public abstract class FactoryService
    {
        public abstract IServico FabricandoProduto(ETipoServico eTipoServico);
    }
}