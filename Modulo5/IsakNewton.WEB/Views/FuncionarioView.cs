using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.FuncionarioService.Implements;

namespace IsakNewton.WEB.Views
{
    public class FuncionarioView
    {
        private readonly CrudFuncionario _crudFuncionario = new CrudFuncionario();
        private readonly Funcionario _funcionario = new Funcionario();

        public void ViewFuncionario()
        {
            Console.WriteLine("Opção selecionada: Funcionário\nO que deseja fazer?");
            OpcoesFuncionario();
            string inputFuncionario = Console.ReadLine();
            switch (inputFuncionario)
            {
                case "1":
                    AdicionarFuncionario();
                    break;
                case "2":
                    VisualizarFuncionarios();
                    break;
                case "3":
                    AtualizarFuncionario();
                    break;
                case "4":
                    ExcluirFuncionario();
                    break;
            }
        }

        private string[] OpcoesFuncionario()
        {
            string[] opcoes =
            {
                "Cadastrar Funcionario", "Visualizar Funcionarios", "Atualizar Funcionarios", "Excluir Funcionarios"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }

        private void AdicionarFuncionario()
        {
            Console.WriteLine("Opção Selecionada: Adicionar Funcionário");
            Console.WriteLine("Insira o Nome do funcionário:");
            _funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Sobrenome do funcionário:");
            _funcionario.SobreNome = Console.ReadLine();

            Console.WriteLine("Insira o Cargo do funcionário:");
            _funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Insira o Turno do funcionário:");
            _funcionario.Turno = Console.ReadLine();

            Console.WriteLine("Insira o Salario do funcionário:");
            _funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Data de Nascimento do funcionário:");
            _funcionario.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o nº de CPF do funcionário:");
            _funcionario.Documento = Console.ReadLine();

            Console.WriteLine("Insira o nº de Telefone do funcionário:");
            _funcionario.Contato = Console.ReadLine();

            Console.WriteLine("Insira o Gênero do funcionário:");
            _funcionario.genero = Console.ReadLine();

            _crudFuncionario.Create(_funcionario);

        }

        private void VisualizarFuncionarios()
        {
            List<Funcionario> funcionarios = _crudFuncionario.Read();

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }

        private void AtualizarFuncionario()
        {
            Console.WriteLine("Opção selecionada: Atualizar");

            Console.WriteLine("Insira o Id do funcionário que deseja atualizar:");
            VisualizarFuncionarios();
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o novo Nome do funcionário:");
            _funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo Sobrenome do funcionário:");
            _funcionario.SobreNome = Console.ReadLine();

            Console.WriteLine("Insira o novo Cargo do funcionário:");
            _funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Insira o novo Turno do funcionário:");
            _funcionario.Turno = Console.ReadLine();

            Console.WriteLine("Insira o novo Salario do funcionário:");
            _funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nova Data de Nascimento do funcionário:");
            _funcionario.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o novo nº de CPF do funcionário:");
            _funcionario.Documento = Console.ReadLine();

            Console.WriteLine("Insira o novo nº de Telefone do funcionário:");
            _funcionario.Contato = Console.ReadLine();

            Console.WriteLine("Insira o Gênero do funcionário:");
            _funcionario.genero = Console.ReadLine();

            _crudFuncionario.Update(_funcionario);
        }

        private void ExcluirFuncionario()
        {
            Console.WriteLine("Opção selecionada: Excluir");

            Console.WriteLine("Insira o Id do funcionário que deseja excluir:");
            VisualizarFuncionarios();
            int id = int.Parse(Console.ReadLine());

            _crudFuncionario.Delete(id);
        }
    }
}