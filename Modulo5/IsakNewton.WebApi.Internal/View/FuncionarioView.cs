using System.Text.Json;
using IsackNewton.Data;
using IsacNewton.Service.FuncionarioService.Implements;

namespace IsakNewton.WebApi.Internal.View;

public class FuncionarioView : Main
{
    public void Executar()
    {
        Submenu();
        int opcaoSubmenu = int.Parse(Console.ReadLine());

        CrudFuncionario crud = new CrudFuncionario();

        switch (opcaoSubmenu)
        {
            case 1:
                List<Funcionario> funcionarios = crud.Read();
                Visualizar(funcionarios);
                break;
            case 2:
                Funcionario funcionario = Criar();
                crud.Create(funcionario);
                break;
            case 3:
                List<Funcionario> funcionariosEdicao = crud.Read();
                Visualizar(funcionariosEdicao);

                Console.WriteLine("Digite o ID do funcionário que deseja editar:");
                int idEdicao = int.Parse(Console.ReadLine());

                Funcionario? funcionarioEdicao = funcionariosEdicao.FirstOrDefault(f => f.Id == idEdicao);

                if (funcionarioEdicao != null)
                {
                    Funcionario funcionarioEditado = Editar(funcionarioEdicao);
                    crud.Update(funcionarioEditado);
                }
                else
                {
                    Console.WriteLine($"Funcionário de ID {idEdicao} não encontrado.");
                }
                break;
            case 4:
                List<Funcionario> funcionariosRemocao = crud.Read();
                Visualizar(funcionariosRemocao);

                Console.WriteLine("Digite o ID do funcionário que deseja remover:");
                int idRemocao = int.Parse(Console.ReadLine());

                crud.Delete(idRemocao);
                break;
        }
    }

    public Funcionario Criar()
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine(JsonSerializer.Serialize(funcionario));

        Console.WriteLine("Digite as informações do funcionario:");
        funcionario.Nome = ObterValor("nome");
        funcionario.SobreNome = ObterValor("sobrenome");
        funcionario.Documento = ObterValor("documento");
        funcionario.DataNacimento = ObterValor("data de nascimento");
        funcionario.genero = ObterValor("gênero");
        funcionario.Contato = ObterValor("contato");
        funcionario.Turno = ObterValor("turno");
        funcionario.Cargo = ObterValor("cargo");
        funcionario.Salario = decimal.Parse(ObterValor("salário"));

        return funcionario;
    }

    public Funcionario Editar(Funcionario funcionario)
    {
        Console.WriteLine(JsonSerializer.Serialize(funcionario));

        Console.WriteLine("Digite as novas informações do funcionario:");
        funcionario.Nome = ObterValor("novo nome");
        funcionario.SobreNome = ObterValor("novo sobrenome");
        funcionario.Documento = ObterValor("novo documento");
        funcionario.DataNacimento = ObterValor("nova data de nascimento");
        funcionario.genero = ObterValor("novo gênero");
        funcionario.Contato = ObterValor("novo contato");
        funcionario.Turno = ObterValor("novo turno");
        funcionario.Cargo = ObterValor("novo cargo");
        funcionario.Salario = decimal.Parse(ObterValor("novo salário"));

        return funcionario;
    }

    public void Visualizar(List<Funcionario> funcionarios)
    {
        if (funcionarios.Count > 0)
        {
            Console.WriteLine("Funcionários cadastrados: \n");

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(JsonSerializer.Serialize(funcionario));
            }
        }
        else
        {
            Console.WriteLine("Nenhum funcionário cadastrado.");
        }
    }
}