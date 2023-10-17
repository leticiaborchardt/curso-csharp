using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaCase
    {
        public void ExecutarCase()
        {
            Console.WriteLine("Insira um número");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Número 1");
                    break;
                case 2:
                    Console.WriteLine("Número 2");
                    break;
                case 3:
                    Console.WriteLine("Número 3");
                    break;
                default:
                    Console.WriteLine("Não encontramos o seu número!");
                    break;
            }
        }
    }
}