using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class Tartaruga : Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Tartaruga() { }

        public Tartaruga(string especie, string nome, int idade) : base(especie)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override void Comer()
        {
            base.Comer();
            Console.WriteLine("Tartaruga comendo");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNome: {this.Nome}\nIdade: {this.Idade}";
        }
    }
}