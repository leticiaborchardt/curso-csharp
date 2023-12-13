namespace BancoTeste;

public class Conta
{
    public string? Cpf { get; set; }
    public decimal Saldo { get; set; }

    public Conta(string cpf, decimal saldo)
    {
        this.Cpf = cpf;
        this.Saldo = saldo;
    }

    public Conta()
    { }

    public bool Depositar(decimal valor)
    {
        if (valor < 0)
        {
            return false;
        }

        Saldo += valor;
        return true;
    }

    public bool Sacar(decimal valor)
    {
        if (Saldo < valor)
        {
            return false;
        }

        Saldo -= valor;
        return true;
    }
}
