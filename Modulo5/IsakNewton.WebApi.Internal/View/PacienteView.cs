using System.Text.Json;
using IsackNewton.Data;
using IsacNewton.Service.PacienteService.Implements;

namespace IsakNewton.WebApi.Internal.View;

public class PacienteView : Main
{
    public void Executar()
    {
        Submenu();
        int opcaoSubmenu = int.Parse(Console.ReadLine());

        CrudPaciente crud = new CrudPaciente();

        switch (opcaoSubmenu)
        {
            case 1:
                List<Paciente> pacientes = crud.Read();
                Visualizar(pacientes);
                break;
            case 2:
                Paciente paciente = Criar();
                crud.Create(paciente);
                break;
            case 3:
                List<Paciente> pacientesEdicao = crud.Read();
                Visualizar(pacientesEdicao);

                Console.WriteLine("Digite o ID do paciente que deseja editar:");
                int idEdicao = int.Parse(Console.ReadLine());

                Paciente? pacienteEdicao = pacientesEdicao.Find(f => f.Id == idEdicao);

                if (pacienteEdicao != null)
                {
                    Paciente pacienteEditado = Editar(pacienteEdicao);
                    crud.Update(pacienteEditado);
                }
                else
                {
                    Console.WriteLine($"Paciente de ID {idEdicao} não encontrado.");
                }
                break;
            case 4:
                List<Paciente> pacientesRemocao = crud.Read();
                Visualizar(pacientesRemocao);

                Console.WriteLine("Digite o ID do paciente que deseja remover:");
                int idRemocao = int.Parse(Console.ReadLine());

                crud.Delete(idRemocao);
                break;
        }
    }

    public Paciente Criar()
    {
        Paciente paciente = new Paciente();

        Console.WriteLine(JsonSerializer.Serialize(paciente));

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

    public Paciente Editar(Paciente paciente)
    {
        Console.WriteLine(JsonSerializer.Serialize(paciente));

        Console.WriteLine("Digite as novas informações do paciente:");
        paciente.Nome = ObterValor("novo nome");
        paciente.SobreNome = ObterValor("novo sobrenome");
        paciente.Documento = ObterValor("novo documento");
        paciente.DataNacimento = ObterValor("nova data de nascimento");
        paciente.genero = ObterValor("novo gênero");
        paciente.Contato = ObterValor("novo contato");
        paciente.Convenio = ObterValor("novo convênio");
        paciente.RestricaoMedica = ObterValor("nova restrição médica");

        return paciente;
    }

    public void Visualizar(List<Paciente> pacientes)
    {
        if (pacientes.Count > 0)
        {
            Console.WriteLine("Pacientes cadastrados: \n");

            foreach (var paciente in pacientes)
            {
                Console.WriteLine(JsonSerializer.Serialize(paciente));
            }
        }
        else
        {
            Console.WriteLine("Nenhum paciente cadastrado.");
        }
    }
}