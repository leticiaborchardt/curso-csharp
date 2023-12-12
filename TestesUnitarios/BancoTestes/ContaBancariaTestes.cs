using Banco;

namespace BancoTestes;

public class ContaBancariaTestes
{
    public void TestarDeposito(decimal valorTeste)
    {
        ContaBancaria conta = new ContaBancaria();

        decimal saldoInicial = conta.Saldo;

        decimal novoSaldo = conta.Depositar(valorTeste);

        if (novoSaldo != saldoInicial + valorTeste)
        {
            Console.WriteLine("Erro: O saldo não foi atualizado corretamente após o depósito.");
        }

        // Tente depositar um valor negativo
        novoSaldo = conta.Depositar(-valorTeste);

        if (novoSaldo != saldoInicial)
        {
            Console.WriteLine("Erro: O saldo não deve ser alterado por um depósito negativo.");
        }
    }

    public void TestarSaque(decimal valorTeste)
    {
        ContaBancaria conta = new ContaBancaria();
        decimal saldoInicial = conta.Saldo;

        decimal novoSaldo = conta.Sacar(valorTeste);

        if (novoSaldo > saldoInicial)
        {
            Console.WriteLine(" O saldo de saque e maior qu o valor em conta.");
        }

        novoSaldo = conta.Sacar(-valorTeste);
        if (novoSaldo != saldoInicial)
        {
            Console.WriteLine("Erro: O saldo não deve ser alterado por um saque negativo.");
        }

        novoSaldo = conta.Sacar(saldoInicial);
        if (novoSaldo != 0)
        {
            Console.WriteLine("Erro: O saldo não foi zerado corretamente após um saque igual ao saldo.");
        }
    }

    public void TestarCpf(string cpf)
    {
        if (!cpf.Contains(".") || !cpf.Contains("-"))
        {
            Console.WriteLine("Erro: CPF deve conter a formatação.");
        }
        else if (cpf.Contains(".") && cpf.Contains("-") && cpf.Length != 14)
        {
            Console.WriteLine("Erro: CPF formatado deve conter 14 dígitos.");
        }
    }
}
