using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Enums;
using DesignPatterns.FactoryMethods.Repositories;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods
{
    public class SelecionaServico : FactoryService
    {
        public override IServico FabricandoProduto(ETipoServico eTipoServico)
        {
            switch (eTipoServico)
            {
                case ETipoServico.premium:
                    return new PremiumRepository();
                case ETipoServico.master:
                    return new MasterRepository();
                case ETipoServico.cobertura:
                    return new CoberturaRepository();
                default:
                    return new TradicionalRepository();
            }
        }
    }
}