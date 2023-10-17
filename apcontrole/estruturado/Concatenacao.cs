using System;

namespace apcontrole.estruturado
{
    public class Concatenacao
    {
        public void Executar()
        {
            Console.WriteLine("Por favor, insira as informações da pessoa!");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            byte idade = Convert.ToByte(Console.ReadLine());

            Console.Write("Gênero: ");
            string genero = Console.ReadLine();

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Profissão: ");
            string profissao = Console.ReadLine();

            Console.Write("Hobby: ");
            string hobby = Console.ReadLine();

            // Concatenação do resultado
            string mensagem = "Aqui estão as informações da pessoa: \n" + 
                              "\nNome: "      + nome + 
                              "\nIdade: "     + idade + 
                              "\nGênero: "    + genero + 
                              "\nCidade: "    + cidade + 
                              "\nProfissão: " + profissao + 
                              "\nHobby: "     + hobby;

            Console.WriteLine(mensagem); 
            Console.WriteLine("Pressione Enter para sair"); 
            Console.ReadLine(); 
        }
    }
}