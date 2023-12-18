using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods.Repositories
{
    public class CoberturaRepository : IServico
    {
        public CoberturaRepository()
        {
            Console.WriteLine("CoberturaRepository");
        }

        public void ExecutarCobranca()
        {
            throw new NotImplementedException();
        }
    }
}