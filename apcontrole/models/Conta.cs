using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal abstract class Conta
    {
        private static int _id;
        private int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta()
        {
            this.gerarId();
        }

        public Conta(string nome, decimal saldo)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.gerarId();
        }

        public virtual decimal Depositar(decimal valor)
        {
            this.Saldo += valor;

            return this.Saldo;
        }

        public virtual bool Sacar(decimal valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;

                return true;
            }

            return false;
        }

        public bool Transferir(decimal valor, Conta contaDestino)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nTitular: {Titular}\nSaldo: {Saldo}";
        }

        private void gerarId()
        {
            this.Id = ++_id;
        }
    }
}