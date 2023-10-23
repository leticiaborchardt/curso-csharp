using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca() { }

        public ContaPoupanca(string nome, decimal saldo) : base(nome, saldo) { }

        public override decimal Depositar(decimal valor)
        {
            this.Saldo += .5m;

            return base.Depositar(valor);
        }
    }
}