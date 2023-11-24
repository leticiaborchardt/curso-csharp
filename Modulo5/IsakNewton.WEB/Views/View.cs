using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsakNewton.WEB.Views
{
    public class View
    {

        public void Main()
        {
            while (true)
            {
                Console.WriteLine("Bem-Vindo ao Hospital Isaac Newton.\nO que deseja fazer?");
                OpcoesMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PacienteView pacienteView = new PacienteView();
                        pacienteView.ViewPaciente();
                        break;
                    case "2":
                        FuncionarioView funcionarioView = new FuncionarioView();
                        funcionarioView.ViewFuncionario();
                        break;
                    case "3":
                        SalaView salaView = new SalaView();
                        salaView.ViewSala();
                        break;
                    case "4":
                        AgendamentoView agendamentoView = new AgendamentoView();
                        agendamentoView.ViewAgendamento();
                        break;
                    case "5":
                        MedicoView medicoView = new MedicoView();
                        medicoView.ViewMedico();
                        break;
                }
            }
        }

        private string[] OpcoesMenu()
        {
            string[] opcoes =
            {
                "Paciente", "Funcionário", "Sala", "Agendamento", "Médico"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }
    }
}