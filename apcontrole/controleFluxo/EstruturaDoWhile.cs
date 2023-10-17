using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaDoWhile
    {
        public void Executar()
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um número maior que 5:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 5)
                {
                    Console.WriteLine("Quase lá!");
                }

                if (numero <= 5)
                {
                    Console.WriteLine("Vou perguntar de novo!");
                }

            } while (numero <= 5);

            Console.WriteLine($"Você digitou {numero}, que é maior que 5. Parabéns!");
        }
    }
}