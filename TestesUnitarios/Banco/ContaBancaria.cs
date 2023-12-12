namespace Banco;

public class ContaBancaria
{
    public string? Cpf { get; set; }

    public decimal Saldo { get; set; }

    public ContaBancaria(decimal saldo)
    {
        Saldo = saldo;

    }
    public ContaBancaria()
    { }

    public decimal Depositar(decimal valorDeposito)
    {
        Saldo += valorDeposito;
        return Saldo;
    }

    public decimal Sacar(decimal valorSaque)
    {
        Saldo -= valorSaque;
        return Saldo;
    }
}
