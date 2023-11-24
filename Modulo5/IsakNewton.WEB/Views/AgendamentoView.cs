using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.AgendamentoService.Implements;
using IsacNewton.Service.MedicoService.Implements;
using IsacNewton.Service.PacienteService.Implements;

namespace IsakNewton.WEB.Views
{
    public class AgendamentoView
    {
        public void ViewAgendamento()
        {
            Console.WriteLine("Opção selecionada: Agendamento\nO que deseja fazer?");
            OpcoesAgendamento();
            string inputAgendamento = Console.ReadLine();

            switch(inputAgendamento)
            {
                case "1":
                    AdicionarAgendamento();
                    break;
                case "2":
                    VisualizarAgendamento();
                    break;
                case "3":
                    EditarAgendamento();
                    break;
                case "4":
                    ExcluirAgendamento();
                    break;
            }
        }

        private string[] OpcoesAgendamento()
        {
            string[] opcoes =
            {
                "Cadastrar Agendamento", "Visualizar Agendamentos", "Atualizar Agendamentos", "Excluir Agendamentos"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }

        public void AdicionarAgendamento()
        {
            CrudAgendamento crudAgendamento = new CrudAgendamento();
            Agendamento agendamento = new Agendamento();

            Console.WriteLine("Data:");
            agendamento.DataAgendamento = Console.ReadLine();

            Console.WriteLine("Escolha o Procedimento:");
            Console.WriteLine("1 - " + Procedimentos.Radiografia);
            Console.WriteLine("2 - " + Procedimentos.AudioMedritria);
            Console.WriteLine("3 - " + Procedimentos.Tomografia);
            Console.WriteLine("4 - " + Procedimentos.RaioX);
            var opcaoProcedimento = Console.ReadLine();
            
            switch (opcaoProcedimento)
            {
                case "1":
                    agendamento.Procedimento = Procedimentos.Radiografia;
                    break;
                case "2":
                    agendamento.Procedimento = Procedimentos.AudioMedritria;
                    break;
                case "3":
                    agendamento.Procedimento = Procedimentos.Tomografia;
                    break;
                case "4":
                    agendamento.Procedimento = Procedimentos.RaioX;
                    break;
                default:
                    Console.WriteLine("opção invalida.");
                    break;
            }
            
            Console.WriteLine("Escolha o médico pelo id:");
            CrudMedico crudMedico = new CrudMedico();
            var listaMedico = crudMedico.Read().ToList();
            foreach (var item in listaMedico) {
                Console.WriteLine(item);
            }

            int opcaoMedico = int.Parse(Console.ReadLine());
            agendamento.Medico = listaMedico.Find(x => x.Id == opcaoMedico);


            Console.WriteLine("Escolha o Paciente pelo id");
            CrudPaciente crudPaciente = new CrudPaciente();
            var listaPaciente = crudPaciente.Read().ToList();
            foreach (var item in listaPaciente) {
                Console.WriteLine(item);
            }

            int opcaoPaciente = int.Parse(Console.ReadLine());
            agendamento.Paciente = listaPaciente.Find(x => x.Id == opcaoPaciente);
            
            crudAgendamento.Create(agendamento);
        }

        public void VisualizarAgendamento()
        {
            CrudAgendamento crudAgendamento = new CrudAgendamento();
            var lista = crudAgendamento.Read();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void ExcluirAgendamento()
        {
            Console.WriteLine("escolha o agendamento para excluir.");
            CrudAgendamento crudAgendamento = new CrudAgendamento();
            var lista = crudAgendamento.Read();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            int id = int.Parse(Console.ReadLine());

            crudAgendamento.Delete(id);
        }

        public void EditarAgendamento()
        {
            CrudAgendamento crudAgendamento = new CrudAgendamento();
            Agendamento agendamento = new Agendamento();

            Console.WriteLine("Escolha o id do agendamento para editar.");
            agendamento.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Data:");
            agendamento.DataAgendamento = Console.ReadLine();

            Console.WriteLine("Escolha o Procedimento:");
            Console.WriteLine("1 - " + Procedimentos.Radiografia);
            Console.WriteLine("2 - " + Procedimentos.AudioMedritria);
            Console.WriteLine("3 - " + Procedimentos.Tomografia);
            Console.WriteLine("4 - " + Procedimentos.RaioX);
            var opcaoProcedimento = Console.ReadLine();
            
            switch (opcaoProcedimento)
            {
                case "1":
                    agendamento.Procedimento = Procedimentos.Radiografia;
                    break;
                case "2":
                    agendamento.Procedimento = Procedimentos.AudioMedritria;
                    break;
                case "3":
                    agendamento.Procedimento = Procedimentos.Tomografia;
                    break;
                case "4":
                    agendamento.Procedimento = Procedimentos.RaioX;
                    break;
                default:
                    Console.WriteLine("opção invalida.");
                    break;
            }
            
            Console.WriteLine("Escolha o médico pelo id:");
            CrudMedico crudMedico = new CrudMedico();
            var listaMedico = crudMedico.Read().ToList();
            foreach (var item in listaMedico) {
                Console.WriteLine(item);
            }

            int opcaoMedico = int.Parse(Console.ReadLine());
            agendamento.Medico = listaMedico.Find(x => x.Id == opcaoMedico);


            Console.WriteLine("Escolha o Paciente pelo id");
            CrudPaciente crudPaciente = new CrudPaciente();
            var listaPaciente = crudPaciente.Read().ToList();
            foreach (var item in listaPaciente) {
                Console.WriteLine(item);
            }

            int opcaoPaciente = int.Parse(Console.ReadLine());
            agendamento.Paciente = listaPaciente.Find(x => x.Id == opcaoPaciente);

            crudAgendamento.Update(agendamento);
        }
    }
}