using apcontrole.estrutura;
using apcontrole.models;

// ClassConta classConta1 = new()
// {
//     Id = 2,
//     Nome = "Leticia Class 1",
//     Saldo = 2500
// };

// Console.WriteLine("Dados da conta CLASS 1:");
// Console.WriteLine(classConta1);

// Console.WriteLine("\nDeposite um valor:");
// classConta1.Depositar(decimal.Parse(Console.ReadLine()));
// Console.WriteLine("Saldo atual: " + classConta1.Saldo);

// Console.WriteLine("\n-----------------------\n");

// ClassConta classConta2 = new()
// {
//     Id = 3,
//     Nome = "Leticia Class 2",
//     Saldo = 1000
// };

// Console.WriteLine("Dados da conta CLASS 2:");
// Console.WriteLine(classConta2);

// Console.WriteLine("\nDeposite um valor:");
// classConta2.Depositar(decimal.Parse(Console.ReadLine()));
// Console.WriteLine("Saldo atual: " + classConta2.Saldo);
// Console.WriteLine("\nSaque um valor:");
// classConta2.Sacar(decimal.Parse(Console.ReadLine()));
// Console.WriteLine("Saldo atual: " + classConta2.Saldo);

// Console.WriteLine("\n-----------------------\n");

// Console.WriteLine("Saldo anterior conta 1: " + classConta1.Saldo);
// Console.WriteLine("Saldo anterior conta 2: " + classConta2.Saldo);
// Console.WriteLine("Transferir valor da conta 1 para conta 2:");

// classConta1.Transferir(decimal.Parse(Console.ReadLine()), classConta2);

// Console.WriteLine("Saldo atual conta 1: " + classConta1.Saldo);
// Console.WriteLine("Saldo atual conta 2: " + classConta2.Saldo);

// Condominio condominio = new Condominio();

// Console.WriteLine("Insira o nome do condomínio:");
// condominio.Nome = Console.ReadLine();

// Console.WriteLine("Insira o documento do condomínio:");
// condominio.Documento = Console.ReadLine();

// Console.WriteLine("Insira a quantidade de unidades do condomínio:");
// condominio.QtdUnidades = int.Parse(Console.ReadLine());

// Console.WriteLine("Insira o endereço do condomínio:");
// condominio.Endereco = Console.ReadLine();

// Console.WriteLine("\nDados do condomínio 1:\n");
// Console.WriteLine(condominio);

// Condominio condominio2 = new Condominio("Moradas do norte", "090.898.909-545");
// Console.WriteLine("\n\nDados do condomínio 2:\n");
// Console.WriteLine(condominio2);

// CadastrarAnimal cadastrarAnimal = new CadastrarAnimal();
// cadastrarAnimal.Executar();

ContaCorrente contaCorrente = new ContaCorrente("Conta corrente", 1000);

contaCorrente.Depositar(10);

Console.WriteLine(contaCorrente);

ContaPoupanca contaPoupanca = new ContaPoupanca("Conta poupança", 1000);

contaPoupanca.Depositar(10);

Console.WriteLine(contaPoupanca);