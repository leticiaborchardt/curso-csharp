using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaIf
    {
        public void ExecutarIf()
        {
            System.Console.WriteLine("Digite um numero entre 1 e 5");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Você digitou 1!!!");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Você digitou 2!!!");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Você digitou 3!!!");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Você digitou 4!!!");
            }
            else
            {
                Console.WriteLine("Você digitou 5!!!");
            }
        }
    }
}