namespace IsakNewton.WebApi.Internal.View;

public class Main
{
    public void Executar()
    {
        do
        {
            Console.WriteLine("Olá, escolha uma opção:");
            Console.WriteLine("1 - Agendamentos");
            Console.WriteLine("2 - Funcionários");
            Console.WriteLine("3 - Médicos");
            Console.WriteLine("4 - Pacientes");
            Console.WriteLine("5 - Salas");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AgendamentoView agendamentoView = new AgendamentoView();
                    agendamentoView.Executar();
                    break;
                case 2:
                    FuncionarioView funcionarioView = new FuncionarioView();
                    funcionarioView.Executar();
                    break;
                case 3:
                    MedicoView medicoView = new MedicoView();
                    medicoView.Executar();
                    break;
                case 4:
                    PacienteView pacienteView = new PacienteView();
                    pacienteView.Executar();
                    break;
                case 5:
                    SalaView salaView = new SalaView();
                    salaView.Executar();
                    break;
            }
        } while (Continuar());
    }

    protected bool Continuar()
    {
        Console.WriteLine($"Você deseja fazer uma nova operação? (s / n)");

        return Console.ReadLine()?.ToUpper() == "S";
    }


    protected String ObterValor(String nome)
    {
        Console.Write($"Digite o(a) {nome}: ");
        return Console.ReadLine(); 
    }

    protected void Submenu()
    {
        Console.WriteLine("1 - GET");
        Console.WriteLine("2 - POST");
        Console.WriteLine("3 - PUT");
        Console.WriteLine("4 - DELETE");
    }
}