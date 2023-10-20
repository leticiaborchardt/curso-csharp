using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca() { }
        public ContaPoupanca(string nome, decimal saldo) : base(nome, saldo)
        {
        }

        internal decimal Depositar(decimal valor)
        {
            this.Saldo += Decimal.Add(valor, .5m);

            return this.Saldo;
        }
    }
}