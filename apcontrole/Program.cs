using apcontrole.estrutura;
using apcontrole.models;

// Conta conta = new()
// {
//     Id = 1,
//     Nome = "Leticia Struct",
//     Saldo = 15000
// };

// Console.WriteLine("Dados da conta STRUCT:");
// Console.WriteLine(conta);

// Console.WriteLine("\nDeposite um valor:");
// conta.Depositar(decimal.Parse(Console.ReadLine()));
// Console.WriteLine("Saldo atual: " + conta.Saldo);


// Console.WriteLine("\n-----------------------\n");

ClassConta classConta1 = new()
{
    Id = 2,
    Nome = "Leticia Class 1",
    Saldo = 2500
};

Console.WriteLine("Dados da conta CLASS 1:");
Console.WriteLine(classConta1);

Console.WriteLine("\nDeposite um valor:");
classConta1.Depositar(decimal.Parse(Console.ReadLine()));
Console.WriteLine("Saldo atual: " + classConta1.Saldo);

Console.WriteLine("\n-----------------------\n");

ClassConta classConta2 = new()
{
    Id = 3,
    Nome = "Leticia Class 2",
    Saldo = 1000
};

Console.WriteLine("Dados da conta CLASS 2:");
Console.WriteLine(classConta2);

Console.WriteLine("\nDeposite um valor:");
classConta2.Depositar(decimal.Parse(Console.ReadLine()));
Console.WriteLine("Saldo atual: " + classConta2.Saldo);
Console.WriteLine("\nSaque um valor:");
classConta2.Sacar(decimal.Parse(Console.ReadLine()));
Console.WriteLine("Saldo atual: " + classConta2.Saldo);

Console.WriteLine("\n-----------------------\n");

Console.WriteLine("Saldo anterior conta 1: " + classConta1.Saldo);
Console.WriteLine("Saldo anterior conta 2: " + classConta2.Saldo);
Console.WriteLine("Transferir valor da conta 1 para conta 2:");

classConta1.Transferir(decimal.Parse(Console.ReadLine()), classConta2);

Console.WriteLine("Saldo atual conta 1: " + classConta1.Saldo);
Console.WriteLine("Saldo atual conta 2: " + classConta2.Saldo);
