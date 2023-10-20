using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente() { }
        public ContaCorrente(string nome, decimal saldo) : base(nome, saldo)
        {
        }

        internal decimal Depositar(decimal valor)
        {
            this.Saldo += Decimal.Subtract(valor, .1m);

            return this.Saldo;
        }
    }
}