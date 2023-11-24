using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.PacienteService.Implements;

namespace IsakNewton.WEB.Views
{
    public class PacienteView
    {
        private readonly CrudPaciente _crudPaciente = new CrudPaciente();
        private readonly Paciente _paciente = new Paciente();
        public void ViewPaciente()
        {
            Console.WriteLine("Opção selecionada: Paciente\nO que deseja fazer?");
            OpcoesPaciente();
            string inputPaciente = Console.ReadLine();

            switch (inputPaciente)
            {
                case "1":
                    CadastrarPaciente();
                    break;
                case "2":
                    VisualizarPacientes();
                    break;
                case "3":
                    AtualizarPaciente();
                    break;
                case "4":
                    ExcluirPaciente();
                    break;
            }
        }

        private string[] OpcoesPaciente()
        {
            string[] opcoes =
            {
                "Cadastrar Paciente", "Visualizar Pacientes", "Atualizar Pacientes", "Excluir Pacientes"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }

        private void CadastrarPaciente()
        {
            Console.WriteLine("Opção selecionada: Cadastrar");

            Console.WriteLine("Insira o Nome do paciente:");
            _paciente.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Sobrenome do paciente:");
            _paciente.SobreNome = Console.ReadLine();

            Console.WriteLine("Possui Convênio? (S/N)");
            char inputConvenio = char.Parse(Console.ReadLine());

            if (inputConvenio == 's')
            {
                Console.WriteLine("Insira o número de Convênio do Paciente:");
                _paciente.Convenio = Console.ReadLine();
            }
            else
            {
                _paciente.Convenio = "Não possui convênio";
            }

            Console.WriteLine("Insira a Data de Nascimento do paciente:");
            _paciente.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o nº de CPF do paciente:");
            _paciente.Documento = Console.ReadLine();

            Console.WriteLine("Insira o Responsável do paciente:");
            _paciente.Contato = Console.ReadLine();

            Console.WriteLine("Insira o nº de Telefone do paciente:");
            _paciente.Contato = Console.ReadLine();

            Console.WriteLine("Insira o Gênero do paciente:");
            _paciente.genero = Console.ReadLine();

            Console.WriteLine("Possui alguma restrição médica? (S/N)");
            char inputRestricao = char.Parse(Console.ReadLine().ToLower());

            if (inputRestricao == 's')
            {
                Console.WriteLine("Qual a restrição?");
                _paciente.RestricaoMedica = Console.ReadLine();
            }
            else
            {
                _paciente.RestricaoMedica = "Não possui restrições.";
            }

            _crudPaciente.Create(_paciente);
        }

        private void VisualizarPacientes()
        {
            List<Paciente> pacientes = _crudPaciente.Read();

            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.ToString());
            }
        }

        private void AtualizarPaciente()
        {
            Console.WriteLine("Opção selecionada: Atualizar");

            Console.WriteLine("Insira o Id do Paciente que deseja atualizar:");
            VisualizarPacientes();
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o novo Nome do paciente selecionado:");
            _paciente.Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo Sobrenome do paciente selecionado:");
            _paciente.SobreNome = Console.ReadLine();

            Console.WriteLine("Insira o novo Nº de Convênio do paciente selecionado:");
            _paciente.Convenio = Console.ReadLine();

            Console.WriteLine("Insira a nova Data de Nascimento do paciente selecionado:");
            _paciente.DataNacimento = Console.ReadLine();

            Console.WriteLine("Insira o novo Documento do paciente selecionado:");
            _paciente.Documento = Console.ReadLine();

            Console.WriteLine("Insira o novo Contato do paciente selecionado:");
            _paciente.Contato = Console.ReadLine();

            Console.WriteLine("Insira o novo Genero do paciente selecionado:");
            _paciente.genero = Console.ReadLine();

            Console.WriteLine("Possui alguma restrição médica? (S/N)");
            char inputRestricao = char.Parse(Console.ReadLine().ToLower());

            if (inputRestricao == 's')
            {
                Console.WriteLine("Qual a restrição?");
                _paciente.RestricaoMedica = Console.ReadLine();
            }
            else
            {
                _paciente.RestricaoMedica = "Não possui restrições.";
            }

            _crudPaciente.Update(_paciente);

        }

        private void ExcluirPaciente()
        {
            Console.WriteLine("Opção selecionada: Excluir");

            Console.WriteLine("Insira o Id do paciente que deseja excluir:");
            VisualizarPacientes();
            int id = int.Parse(Console.ReadLine());

            _crudPaciente.Delete(id);
        }
    }
}