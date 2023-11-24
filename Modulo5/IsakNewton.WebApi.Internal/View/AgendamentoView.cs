using System.Text.Json;
using IsackNewton.Data;
using IsacNewton.Service.AgendamentoService.Implements;

namespace IsakNewton.WebApi.Internal.View;

public class AgendamentoView: Main
{
    public void Executar()
    {
        Submenu();
        int opcaoSubmenu = int.Parse(Console.ReadLine());
        CrudAgendamento crudAgendamento = new CrudAgendamento();
        List<Agendamento> agendamentosDisponiveis = crudAgendamento.Read();

        switch (opcaoSubmenu)
        {
            case 1:
                if (agendamentosDisponiveis.Count > 0)
                {
                    Read(crudAgendamento.Read());
                }
                else
                {
                    Console.WriteLine("Não existem agendamentos!");
                }
                break;
            case 2:
                crudAgendamento.Create(Criar());
                Console.WriteLine("Agendamento criado com sucesso!");
                break;
            case 3:
                Agendamento agendamento = Atualizar();

                if (agendamentosDisponiveis.Find(x => x.Id == agendamento.Id) != null)
                {
                    crudAgendamento.Update(agendamento);
                    Console.WriteLine("Agendamento atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi encontrado o agendamento!");
                }
                break;
            case 4:
                int id = Deletar();
                if (agendamentosDisponiveis.Find(x => x.Id == id) != null)
                {
                    crudAgendamento.Delete(id);
                    Console.WriteLine("Agendamento deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi encontrado o agendamento!");
                }
                break;
        }
    }

    private Agendamento Criar()
    {
        Agendamento agendamento = new Agendamento();
        Console.WriteLine(JsonSerializer.Serialize(agendamento));

        Console.WriteLine("Digite as informações do agendamento:");
        agendamento.DataAgendamento = ObterValor("data de agendamento");
        agendamento.Medico = ObterMedico();
        agendamento.Paciente = ObterPaciente();
        agendamento.Procedimento = ObterProcedimento();

        return agendamento;
    }

    private void Read(List<Agendamento> agendamentos)
    {
        foreach (var agendamento in agendamentos)
        {
            Console.WriteLine(JsonSerializer.Serialize(agendamento));
        }
    }

    private Agendamento Atualizar()
    {
        Console.Write("Digite o identificador do agendamento para atualizar: ");
        int id = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Agendamento {id} selecionado:");
        Console.WriteLine("Digite as novas informações:");

        Agendamento agendamento = new Agendamento();
        agendamento.Id = id;
        agendamento.DataAgendamento = ObterValor("data de agendamento");
        agendamento.Medico = ObterMedico();
        agendamento.Paciente = ObterPaciente();
        agendamento.Procedimento = ObterProcedimento();

        return agendamento;
    }

    private int Deletar()
    {
        Console.Write("Digite o identificador do agendamento para excluir: ");
        return int.Parse(Console.ReadLine());
    }

    private Procedimentos ObterProcedimento()
    {
        Console.WriteLine("Escolha o procedimento:");
        Console.WriteLine("0 - Radiografia");
        Console.WriteLine("1 - AudioMedritria");
        Console.WriteLine("2 - Tomografia");
        Console.WriteLine("3 - RaioX");

        return (Procedimentos) int.Parse(Console.ReadLine());
    }

    private Medico ObterMedico()
    {
        Medico medico = new Medico();

        Console.WriteLine("Digite as informações do médico:");
        medico.Nome = ObterValor("nome");
        medico.SobreNome = ObterValor("sobrenome");
        medico.Documento = ObterValor("documento");
        medico.DataNacimento = ObterValor("data de nascimento");
        medico.genero = ObterValor("gênero");
        medico.Contato = ObterValor("contato");
        medico.Cargo = ObterValor("cargo");
        medico.Salario = decimal.Parse(ObterValor("salário"));
        medico.Turno = ObterValor("turno");
        medico.NumeroCrm = ObterValor("número do CRM");
        medico.Especialidade = ObterValor("especialidade");

        return medico;
    }

    private Paciente ObterPaciente()
    {
        Paciente paciente = new Paciente();
        
        Console.WriteLine("Digite as informações do paciente:");
        paciente.Nome = ObterValor("nome");
        paciente.SobreNome = ObterValor("sobrenome");
        paciente.Documento = ObterValor("documento");
        paciente.DataNacimento = ObterValor("data de nascimento");
        paciente.genero = ObterValor("gênero");
        paciente.Contato = ObterValor("contato");
        paciente.Convenio = ObterValor("convênio");
        paciente.RestricaoMedica = ObterValor("restrição médica");

        return paciente;
    }
}