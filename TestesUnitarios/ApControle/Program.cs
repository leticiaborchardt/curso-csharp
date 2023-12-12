// See https://aka.ms/new-console-template for more information
using Banco;
using BancoTestes;
using Calculadora;
using CalculadoraTestes;

Console.WriteLine("Hello, World!");

ClassCalculadora calculadora = new ClassCalculadora();

CalculadoraTeste calculadoraTeste = new CalculadoraTeste();

// Console.WriteLine("Número 1:");
// int n1 = Convert.ToInt32(Console.ReadLine());   

// Console.WriteLine("Número 2:");
// int n2 = Convert.ToInt32(Console.ReadLine());   

// calculadoraTeste.TestarSoma(n1, n2);
// calculadoraTeste.TestarSubtracao(n1, n2);


ContaBancaria contaBancaria = new ContaBancaria(2000);   
ContaBancariaTestes contaBancariaTestes = new ContaBancariaTestes();   

Console.WriteLine("CPF da conta:");
contaBancaria.Cpf = Console.ReadLine();

contaBancariaTestes.TestarCpf(contaBancaria.Cpf);