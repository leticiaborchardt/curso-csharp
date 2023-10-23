using apcontrole.estrutura;
using apcontrole.models;

Console.WriteLine("Criação da conta corrente");
ContaCorrente contaCorrente = new ContaCorrente("Conta corrente", 0);
contaCorrente.Titular = "Letícia";

Console.WriteLine("Deposite um valor:");
contaCorrente.Depositar(decimal.Parse(Console.ReadLine()));
Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");

Console.WriteLine("Saque um valor:");
contaCorrente.Sacar(decimal.Parse(Console.ReadLine()));
Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");

Console.WriteLine("\nDados da Conta corrente:");
Console.WriteLine(contaCorrente);
Console.WriteLine("\n------------------------------------\n");

Console.WriteLine("Criação da conta poupança");

ContaPoupanca contaPoupanca = new ContaPoupanca("Conta poupança", 0);
contaPoupanca.Titular = "Letícia";

Console.WriteLine("Deposite um valor:");
contaPoupanca.Depositar(decimal.Parse(Console.ReadLine()));
Console.WriteLine($"Saldo atual: {contaPoupanca.Saldo}");

Console.WriteLine("Saque um valor:");
contaPoupanca.Sacar(decimal.Parse(Console.ReadLine()));
Console.WriteLine($"Saldo atual: {contaPoupanca.Saldo}");

Console.WriteLine("\nDados da Conta poupança");
Console.WriteLine(contaPoupanca);

Console.WriteLine("\n------------------------------------\n");
Console.WriteLine("Transfira um valor da conta corrente para a poupança");
contaCorrente.Transferir(decimal.Parse(Console.ReadLine()), contaPoupanca);

Console.WriteLine($"Saldo Conta Corrente: {contaCorrente.Saldo}\n");
Console.WriteLine($"Saldo Conta Poupança: {contaPoupanca.Saldo}");