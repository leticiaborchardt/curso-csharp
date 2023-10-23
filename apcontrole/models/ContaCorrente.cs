using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.models
{
    internal class ContaCorrente : Conta
    {
        private int _numSaque;

        public ContaCorrente() { }

        public ContaCorrente(string nome, decimal saldo) : base(nome, saldo) {
            while (saldo <= 0)
            {
                Console.WriteLine("Saldo deve ser maior que 0");
                saldo = decimal.Parse(Console.ReadLine());
            }

            this.Saldo = saldo;
        }

        public override decimal Depositar(decimal valor)
        {
            this.Saldo += .1m;

            return base.Depositar(valor);
        }

        public override bool Sacar(decimal valor)
        {
            this._numSaque++;

            if (this._numSaque == 5)
            {
                this.Saldo -= 0.25m;
                this._numSaque = 0;
            }

            return base.Sacar(valor);
        }
    }
}