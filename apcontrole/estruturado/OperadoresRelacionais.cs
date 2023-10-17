using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class OperadoresRelacionais
    {
        public void Executar()
        {
            int numero1 = 10;
            int numero2 = 5;

            bool MaiorQue = numero1 > numero2;
            Console.WriteLine($"{numero1} é maior que {numero2}? {MaiorQue}");

            bool MenorQue = numero1 < numero2;
            Console.WriteLine($"{numero1} é menor que {numero2}? {MenorQue}");

            bool MenorIgual = numero1 <= numero2;
            Console.WriteLine($"{numero1} é menor ou igual que {numero2}? {MenorIgual}");

            bool MaiorIgual = numero1 >= numero2;
            Console.WriteLine($"{numero1} é maior ou igual que {numero2}? {MaiorIgual}");

            bool Igual = numero1 == numero2;
            Console.WriteLine($"{numero1} é igual a {numero2}? {Igual}");

            bool Diferente = numero1 != numero2;
            Console.WriteLine($"{numero1} é diferente de {numero2}? {Diferente}");

        }
    }
}