using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.exemploFinal
{
    public class ApexEscola
    {
        public void Main()
        {
            Console.WriteLine("Sejam bem-vindos à escola de programação Apex!");

            do
            {
                string nome = ObterDado("nome");
                string sobrenome = ObterDado("sobrenome");
                byte idade = ObterIdade();
                float nota1 = ObterNota("nota 1");
                float nota2 = ObterNota("nota 2");
                float media = CalcularMedia(nota1, nota2);

                List<string> disciplinas = ObterDisciplinas();

                Dictionary<string, object> aluno = new Dictionary<string, object> {
                    {"Nome", nome},
                    {"Sobrenome", sobrenome},
                    {"Idade", idade},
                    {"Nota 1", nota1},
                    {"Nota 2", nota2},
                    {"Média", media},
                    {"Disciplinas", disciplinas}
                };

                ExibirDadosAluno(aluno);
                VerificarAprovacao(media);
            } while (Continuar());

            Console.WriteLine("Seu programa foi finalizado.");
        }

        private string ObterDado(String dado)
        {
            Console.WriteLine($"Digite o seu {dado}:");
            return Console.ReadLine();
        }

        private byte ObterIdade()
        {
            Console.WriteLine("Digite sua idade:");

            return byte.Parse(Console.ReadLine());
        }

        private float ObterNota(string nota)
        {
            Console.WriteLine($"Digite a {nota}:");

            return float.Parse(Console.ReadLine());
        }

        private float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        private List<string> ObterDisciplinas()
        {
            Console.WriteLine("Digite suas disciplinas separadas por vírgula (Ex.: matemática, português):");

            string disciplinasInput = Console.ReadLine();
            string[] disciplinasArray = disciplinasInput.Split(',');

            return new List<string>(disciplinasArray);
        }

        private void ExibirDadosAluno(Dictionary<string, object> aluno)
        {
            Console.WriteLine("Dados do aluno(a):");

            foreach (var dado in aluno)
            {
                Console.Write($"{dado.Key}: ");

                if (dado.Value is List<string> disciplinas)
                {
                    Console.WriteLine(string.Join(',', disciplinas));
                }
                else
                {
                    Console.WriteLine(dado.Value);
                }
            }
        }

        private void VerificarAprovacao(float media)
        {
            bool aprovado = media >= 7.0;

            Console.WriteLine($"Aprovação: {aprovado}");
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja continuar? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }
    }
}