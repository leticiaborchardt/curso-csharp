using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class Matriz
    {
        int[,] matriz = new int[3,3];

        public void Executar()
        {
            matriz[0,0] = 1;
            matriz[0,1] = 2;
            matriz[0,2] = 3;
            matriz[1,0] = 4;
            matriz[1,1] = 5;
            matriz[1,2] = 6;
            matriz[2,0] = 7;
            matriz[2,1] = 8;
            matriz[2,2] = 9;

            Console.WriteLine("Percorrendo matriz com for");
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matriz[i, a] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}