using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.controleFluxo
{
    public class EstruturaForEach
    {
        public void Executar()
        {
            List<int> numeros = new List<int>{
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Dictionary<string, int> nomeIdades = new Dictionary<string, int>{
                {"Letícia", 15},
                {"Joãozinho", 24},
                {"Paulo", 18}
            };

            foreach (var valor in nomeIdades)
            {
                Console.WriteLine($"Nome: {valor.Key} - Idade: {valor.Value}");
            }

            string texto = "Ap.Controle é O Software De Administração De Condomínios mais sólido do Brasil";

            foreach (char caractere in texto)
            {
                if (char.IsUpper(caractere))
                {
                    Console.WriteLine(caractere);
                }
            }
        }
    }
}