using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class Vetor
    {
        // Um vetor é um índice ordenado de elementos do mesmo tipo primitivo.
        string[] semana = new string[7];

        public void Executar()
        {
            semana[0] = "Domingo";
            semana[1] = "Segunda-feira";
            semana[2] = "Terça-feira";
            semana[3] = "Quarta-feira";
            semana[4] = "Quinta-feira";
            semana[5] = "Sexta-feira";
            semana[6] = "Sábado";

            Console.WriteLine(semana[6]);
        }
    }
}