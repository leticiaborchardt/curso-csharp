using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.tipos
{
    public class Caracteres
    {
        public void Executar()
        {
            char letra = 'A';
            char digito = '1';
            char simbolo = '@';

            Console.WriteLine("Char");
            Console.WriteLine(letra + digito + simbolo);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);

            string nome = "Letícia";
            string frase = "Olá ap.controle!";
            string texto = "Olá ap.controle! Tudo bem? Que belo dia de chuva...";
            int comprimento = texto.Length;
            Console.WriteLine("String");
            Console.WriteLine(nome);
            Console.WriteLine(frase);

            Console.WriteLine("String Length");
            Console.WriteLine(comprimento);
        }
    }
}