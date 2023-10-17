using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaFor
    {
        public void Executar()
        {
            Console.WriteLine("Contagem de 0 a 10 utilizando for:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fim.");

            Console.WriteLine("Decremento de 10 a 0 utilizando for:");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fim.");


            Console.WriteLine("Contagem de 1 a 100 de 5 em 5 utilizando for:");
            for (int i = 1; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fim.");
        }
    }
}