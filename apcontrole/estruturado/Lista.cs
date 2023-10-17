using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class Lista
    {
        public void ExecutarLista()
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            
            Console.WriteLine("Elementos da lista");

            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }

        }
    }
}