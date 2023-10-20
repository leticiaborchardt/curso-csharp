using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class Passaro : Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public Passaro() { }

        public Passaro(string especie, string raca, string nome) : base(especie)
        {
            this.Nome = nome;
            this.Raca = raca;
        }

        public override void Comer()
        {
            base.Comer();
            Console.WriteLine("Passaro comendo");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNome: {this.Nome}\nRaça: {this.Raca}";
        }
    }
}