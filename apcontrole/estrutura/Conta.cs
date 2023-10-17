using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estrutura
{
    // Struct - são estruturas mais "leves", que não carregam todas as funcionalidades de uma classe normal
    internal struct Conta
    {
        public int Id;
        public string Nome;
        public decimal Saldo;

        internal decimal Depositar(decimal valor)
        {
            this.Saldo += valor;

            return this.Saldo;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nSaldo: {Saldo}";
        }

    }
}