using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class ClassConta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Saldo { get; set; }

        internal decimal Depositar(decimal valor)
        {
            this.Saldo += valor;

            return this.Saldo;
        }

        internal bool Sacar(decimal valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;

                return true;
            }

            return false;
        }

        internal bool Transferir(decimal valor, ClassConta contaDestino)
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
            return $"Id: {Id}\nNome: {Nome}\nSaldo: {Saldo}";
        }
    }
}