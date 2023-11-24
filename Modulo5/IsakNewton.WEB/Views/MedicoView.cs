using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.MedicoService.Implements;

namespace IsakNewton.WEB.Views
{
    public class MedicoView
    {
        CrudMedico _crudMedico = new CrudMedico();
        Medico _medico = new Medico();
        public void ViewMedico()
        {
            Console.WriteLine("Opção selecionada: Médico\nO que deseja fazer?");
            OpcoesMedico();
            string inputMecico = Console.ReadLine();

            switch (inputMecico)
            {
                case "1":
                    AdicionarMedico();
                    break;
                case "2":
                    VisualizarMedico();
                    break;
                case "3":
                    AtualizarMedico();
                    break;
                case "4":
                    ExcluirMedico();
                    break;
            }
        }

        private string[] OpcoesMedico()
        {
            string[] opcoes =
            {
                "Cadastrar Médico", "Visualizar Médicos", "Atualizar Médicos", "Excluir Médicos"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }

        private void AdicionarMedico()
        {
            Console.WriteLine("Opção Selecionada: Adicionar Médico");
            Console.WriteLine("Insira o Nome do médico:");
            _medico.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Sobrenome do médico:");
            _medico.SobreNome = Console.ReadLine();

            Console.WriteLine("Insira o Cargo do médico:");
            _medico.Cargo = Console.ReadLine();

            Console.WriteLine("Insira o Turno do médico:");
            _medico.Turno = Console.ReadLine();

            Console.WriteLine("Insira o Salario do médico:");
            _medico.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Data de Nascimento do médico:");
            _medico.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o nº de CPF do médico:");
            _medico.Documento = Console.ReadLine();

            Console.WriteLine("Insira o nº de Telefone do médico:");
            _medico.Contato = Console.ReadLine();

            Console.WriteLine("Insira o Gênero do médico:");
            _medico.genero = Console.ReadLine();

            Console.WriteLine("Insira o número do CRM do médico:");
            _medico.NumeroCrm = Console.ReadLine();

            Console.WriteLine("Insira a especialidade do médico:");
            _medico.Especialidade = Console.ReadLine();

            _crudMedico.Create(_medico);
        }

        private void VisualizarMedico()
        {
            List<Medico> medicos = _crudMedico.Read();

            foreach (var medico in medicos)
            {
                Console.WriteLine(medico.ToString());
            }
        }

        private void AtualizarMedico()
        {
            Console.WriteLine("Opção selecionada: Atualizar");

            Console.WriteLine("Insira o Id do médico que deseja atualizar:");
            VisualizarMedico();
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Nome do médico:");
            _medico.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Sobrenome do médico:");
            _medico.SobreNome = Console.ReadLine();

            Console.WriteLine("Insira o Cargo do médico:");
            _medico.Cargo = Console.ReadLine();

            Console.WriteLine("Insira o Turno do médico:");
            _medico.Turno = Console.ReadLine();

            Console.WriteLine("Insira o Salario do médico:");
            _medico.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Data de Nascimento do médico:");
            _medico.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o nº de CPF do médico:");
            _medico.Documento = Console.ReadLine();

            Console.WriteLine("Insira o nº de Telefone do médico:");
            _medico.Contato = Console.ReadLine();

            Console.WriteLine("Insira o Gênero do médico:");
            _medico.genero = Console.ReadLine();

            Console.WriteLine("Insira o número do CRM do médico:");
            _medico.NumeroCrm = Console.ReadLine();

            Console.WriteLine("Insira a especialidade do médico:");
            _medico.Especialidade = Console.ReadLine();

            _crudMedico.Create(_medico);
        }

        private void ExcluirMedico()
        {
            Console.WriteLine("Opção selecionada: Excluir");

            Console.WriteLine("Insira o Id do médico que deseja excluir:");
            VisualizarMedico();
            int id = int.Parse(Console.ReadLine());

            _crudMedico.Delete(id);
        }
    }
}