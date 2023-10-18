using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    public class Condominio
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
        private string _documento;
        public string Documento
        {
            get
            {
                return _documento;
            }
            set
            {
                while (value.Length < 14)
                {
                    Console.WriteLine("O documento deve ter no mínimo 14 caracteres. Digite novamente:");
                    value = Console.ReadLine();
                }

                this._documento = value;
            }
        }
        private string _endereco;
        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                while (value.Length < 1)
                {
                    Console.WriteLine("Endereço não pode estar em branco. Digite novamente:");
                    value = Console.ReadLine();
                }

                this._endereco = value;
            }
        }
        private int _qtdUnidades;
        public int QtdUnidades
        {
            get
            {
                return _qtdUnidades;
            }
            set
            {
                while (value < 1)
                {
                    Console.WriteLine("O condomínio precisa ter no mínimo 01 unidade para ser cadastrado. Digite novamente:");
                    value = int.Parse(Console.ReadLine());
                }

                this._qtdUnidades = value;
            }
        }

        public Condominio()
        {
            this.gerarId();
        }

        public Condominio(string nome, string documento)
        {
            this.Nome = nome;
            this.Documento = documento;
            this.gerarId();
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\nNome: {this.Nome}\nDocumento: {this.Documento}\n" + base.ToString();
        }

        private void gerarId()
        {
            this.Id = ++_id;
        }
    }
}