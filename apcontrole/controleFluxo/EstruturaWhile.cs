using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaWhile
    {
        public void Executar()
        {
            int pontuacao = 0;
            bool jogadorGanhou = false;

            while (!jogadorGanhou)
            {
                Console.WriteLine($"Sua pontuação atual é: {pontuacao}");

                Console.WriteLine("Você ganhou (sim/nao)");
                string resposta = Console.ReadLine();

                if (resposta.Equals("sim", StringComparison.OrdinalIgnoreCase))
                {
                    jogadorGanhou = true;
                    Console.WriteLine("Parabéns você ganhou!");
                }
                else
                {
                    Console.WriteLine("Continue Jogando");
                    pontuacao++;
                }
            }
        }
    }
}