using System.Text.Json;
using IsackNewton.Data;
using IsacNewton.Service.MedicoService.Implements;

namespace IsakNewton.WebApi.Internal.View;

public class MedicoView: Main
{
    public void Executar()
    {
        Submenu();
        int opcaoSubmenu = int.Parse(Console.ReadLine());
        CrudMedico crudMedico = new CrudMedico();
        List<Medico> medicosDisponiveis = crudMedico.Read();

        switch (opcaoSubmenu)
        {
            case 1:
                if (medicosDisponiveis.Count > 0)
                {
                    Read(crudMedico.Read());
                }
                else
                {
                    Console.WriteLine("Não existem médicos!");
                }
                break;
            case 2:
                crudMedico.Create(Criar());
                Console.WriteLine("Médico cadastrado com sucesso!");
                break;
            case 3:
                Medico medico = Atualizar();

                if (medicosDisponiveis.Find(x => x.Id == medico.Id) != null)
                {
                    crudMedico.Update(medico);
                    Console.WriteLine("Médico atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi encontrado o médico!");
                }
                break;
            case 4:
                int id = Deletar();
                if (medicosDisponiveis.Find(x => x.Id == id) != null)
                {
                    crudMedico.Delete(id);
                    Console.WriteLine("Médico deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não foi encontrado o médico!");
                }
                break;
        }
    }

    private void Read(List<Medico> medicos)
    {
        foreach (var medico in medicos)
        {
            Console.WriteLine(JsonSerializer.Serialize(medico));
        }
    }

    public Medico Criar()
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

    private Medico Atualizar()
    {
        Console.Write("Digite o identificador do médico para atualizar: ");
        int id = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Médico {id} selecionado:");
        Console.WriteLine("Digite as novas informações:");

        Medico medico = new Medico();
        medico.Id = id;
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

    private int Deletar()
    {
        Console.Write("Digite o identificador do médico para deletar: ");
        return int.Parse(Console.ReadLine());
    }
}