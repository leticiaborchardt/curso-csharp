using System.Text.Json;
using IsackNewton.Data;
using IsacNewton.Service.SalaService.Implements;

namespace IsakNewton.WebApi.Internal.View;

public class SalaView : Main
{
    private CrudSala crudSala = new CrudSala();

    public void Executar()
    {
        Submenu();
        int opcaoSubmenu = int.Parse(Console.ReadLine());

        switch (opcaoSubmenu)
        {
            case 1:
                Visualizar();
                break;
            case 2:
                Criar();
                break;
            case 3:
                Atualizar();
                break;
            case 4:
                Deletar();
                break;
        }
    }

    private void Criar()
    {
        Sala sala = new Sala();
        
        Console.WriteLine("Digite as informações da sala:");
        sala.Numero = ObterValor("número");
        crudSala.Create(sala);
    }

    private void Atualizar()
    {
        Visualizar();
        Sala sala = new Sala();
        
        Console.WriteLine("Digite o Id da sala que você deseja atualizar: ");
        sala.Id = int.Parse(Console.ReadLine());
        sala.Numero = ObterValor("número");
        
        crudSala.Update(sala);
    }

    private void Visualizar()
    {
        List<Sala> lista = crudSala.Read();

        if (lista.Count > 0)
        {
            Console.WriteLine("Salas cadastradas: \n");

            foreach (var sala in lista)
            {
                Console.WriteLine(JsonSerializer.Serialize(sala));
            }
        }
        else 
        {
            Console.WriteLine("Nenhuma sala foi encontrada.");
        }
    }

    private void Deletar()
    {
        Visualizar();

        Console.WriteLine("Digite o Id da sala que você deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        crudSala.Delete(id);
    }

}