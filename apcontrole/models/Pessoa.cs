using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class Pessoa
    {
        private static int _id;
        public int Id { get; private set; }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                while (value.Length <= 2)
                {
                    Console.WriteLine("Insira mais de 2 caracteres:");
                    value = Console.ReadLine();
                }

                this._nome = value;
            }
        }


        private byte _idade;
        public byte Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Insira a idade:");
                    value = byte.Parse(Console.ReadLine());
                }

                this._idade = value;
            }
        }

        public Pessoa()
        {
            this.gerarId();
        }

        public Pessoa(string nome, byte idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.gerarId();
        }

        public override string ToString()
        {
            return $"{this.Id}\n{this.Nome}\n{this.Idade}" + base.ToString();
        }

        public override bool Equals(object? obj)
        {
            Pessoa objeto = obj as Pessoa;

            if (objeto.Nome == this.Nome)
            {
                return true;
            }

            return false;
        }

        private void gerarId()
        {
            this.Id = ++_id;
        }
    }
}