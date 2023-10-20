using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class Animal
    {
        private static int _id;
        private int Id { get; set; }
        public string Especie { get; set; }

        public Animal()
        {
            this.gerarId();
        }

        public Animal(string especie)
        {
            this.Especie = especie;
            this.gerarId();
        }

        // "virtual" => método que pode ser sobrescrito
        public virtual void Comer()
        {
            Console.WriteLine("O animal está comendo");
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\nEspecie: {this.Especie}";
        }

        private void gerarId()
        {
            this.Id = ++_id;
        }
    }
}