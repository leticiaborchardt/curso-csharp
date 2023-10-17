using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class Dicionario
    {
        public void ExecutarDicionario()
        {
            Console.Write("Insira a idade de Letícia:");            
            byte idade1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Insira a idade de João:");            
            byte idade2 = Convert.ToByte(Console.ReadLine());

            Console.Write("Insira a idade de José:");            
            byte idade3 = Convert.ToByte(Console.ReadLine());

            Dictionary<string, byte> idades = new Dictionary<string, byte> {
                {"Letícia", idade1},
                {"João", idade2},
                {"José", idade3}
            };

            Console.WriteLine($"Idade da Leticia {idades["Letícia"]}\nIdade do João: {idades["João"]}\nIdade do José: {idades["José"]}");
        }
    }
}