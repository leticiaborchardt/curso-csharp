using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods.Repositories
{
    public class PremiumRepository : IServico
    {
        public PremiumRepository()
        {
            Console.WriteLine("PremiumRepository");
        }

        public void ExecutarCobranca()
        {
            throw new NotImplementedException();
        }
    }
}