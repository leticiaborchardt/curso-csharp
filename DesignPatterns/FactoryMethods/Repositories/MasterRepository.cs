using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Services;

namespace DesignPatterns.FactoryMethods.Repositories
{
    public class MasterRepository : IServico
    {
        public MasterRepository()
        {
            Console.WriteLine("MasterRepository");
        }

        public void ExecutarCobranca()
        {
            throw new NotImplementedException();
        }
    }
}