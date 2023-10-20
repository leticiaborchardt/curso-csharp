using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class CadastrarAnimal
    {
        public void Executar()
        {
            do
            {
                Console.WriteLine("Qual animal deseja cadastrar? (tartaruga, cachorro, gato ou passaro)");

                string animal = Console.ReadLine();

                switch (animal)
                {
                    case "tartaruga":
                        Tartaruga tartaruga = new Tartaruga();
                        tartaruga.Especie = "Tartaruga";
                        Console.WriteLine("Digite o nome:");
                        tartaruga.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade:");
                        tartaruga.Idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Animal cadastrado:\n\n" + tartaruga);
                        break;
                    case "cachorro":
                        Cachorro cachorro = new Cachorro();
                        cachorro.Especie = "Cachorro";
                        Console.WriteLine("Digite o nome:");
                        cachorro.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a raça do cachorro:");
                        cachorro.Raca = Console.ReadLine();

                        Console.WriteLine("Animal cadastrado:\n\n" + cachorro);
                        break;
                    case "gato":
                        Gato gato = new Gato();
                        gato.Especie = "Gato";
                        Console.WriteLine("Digite o nome:");
                        gato.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a raça do gato:");
                        gato.Raca = Console.ReadLine();

                        Console.WriteLine("Animal cadastrado:\n\n" + gato);
                        break;
                    case "passaro":
                        Passaro passaro = new Passaro();
                        passaro.Especie = "Pássaro";
                        Console.WriteLine("Digite o nome:");
                        passaro.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a raça do pássaro:");
                        passaro.Raca = Console.ReadLine();

                        Console.WriteLine("Animal cadastrado:\n\n" + passaro);
                        break;
                    default:
                        Console.WriteLine("Não é possível cadastrar este animal!");
                        break;
                }
            } while (Continuar());
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja cadastrar mais um animal? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }
    }
}