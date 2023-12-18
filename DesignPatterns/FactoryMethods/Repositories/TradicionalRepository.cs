using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods.Repositories
{
    public class TradicionalRepository : IServico
    {
        public TradicionalRepository()
        {
            Console.WriteLine("TradicionalRepository");
        }

        public void ExecutarCobranca()
        {
            throw new NotImplementedException();
        }
    }
}