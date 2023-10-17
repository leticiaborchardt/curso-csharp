using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.tipos
{
    public class Flutuantes
    {
        public void Executar()
        {
            // Existem 3 tipos

            // Geralmente usados para valores monetários
            decimal salario = 1000.00m;
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // float f ou F  no final do valor, usado para maioria dos números
            float taxa = 25.989f;
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            // Double não precisa de dados adicionais, é a variável default para números com . mas é exceção pois é muito grande
            double valorDouble = 74564568.6541685;
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
        }
    }
}