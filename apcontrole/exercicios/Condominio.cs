using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.exemploFinal
{
    public class Condominio
    {
        readonly string[] condominios = new string[5] {
            "Residencial Moradas do Sul",
            "Residencial Moradas do Oeste",
            "Residencial Moradas do Norte",
            "Residencial Moradas do Leste",
            "Residencial Moradas do Sudoeste"
        };

        readonly List<int>[] unidades = new List<int>[5] {
            new List<int> {101, 102, 103},
            new List<int> {202, 203},
            new List<int> {405, 105, 208},
            new List<int> {1001, 1002, 1003},
            new List<int> {301, 302, 304, 305}
        };
        public void Main()
        {
            Console.WriteLine("Seja bem-vindo(a) ao seu formulário de cadastro! Por favor, preencha os dados abaixo:");

            do
            {
                string nome = ObterDado("nome completo");
                string documento = ObterDado("CPF/CNPJ");
                int condominio = ObterCondominio();
                int apartamento = ObterApto(condominio);
                string tipoCadastro = ObterTipoCadastro();

                Dictionary<string, object> pessoa = new Dictionary<string, object> {
                    {"Nome Completo", nome},
                    {"CPF/CNPJ", documento},
                    {"Endereço", ObterEnderecoCompleto(condominio, apartamento)}
                };

                ExibirDados(tipoCadastro, pessoa);
            } while (Continuar());

            Console.WriteLine("Seu programa foi finalizado.");
        }

        private string ObterDado(String dado)
        {
            Console.WriteLine($"Digite o seu {dado}:");
            return Console.ReadLine();
        }

        private int ObterApto(int condominio)
        {
            Console.WriteLine("Qual desses é o seu apartamento? (Digite somente o número)");

            List<int> apartamentos = unidades[condominio];

            foreach (int numero in apartamentos)
            {
                Console.WriteLine($"Apto {numero}");
            }

            return int.Parse(Console.ReadLine());
        }

        private string ObterTipoCadastro()
        {
            Console.WriteLine("Você é morador ou funcionário do condomínio? (m/f)");

            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 'f')
            {
                Console.WriteLine("Qual a sua função dentro do condomínio?");

                string funcaoFuncionario = Console.ReadLine();

                return $"Funcionário - {funcaoFuncionario}";
                
            }

            return $"Morador";
        }

        private int ObterCondominio()
        {
            Console.WriteLine("Digite o número correspondente ao seu condomínio:");

            for (int i = 0; i < condominios.Length; i++)
            {
                Console.WriteLine($"{i} = {condominios[i]}");
            }

            return int.Parse(Console.ReadLine().ToLower());
        }

        private string ObterEnderecoCompleto(int condominio, int apartamento)
        {
            return $"{condominios[condominio]} - Apto {apartamento}";
        }

        private void ExibirDados(string tipoCadastro, Dictionary<string, object> pessoa)
        {
            Console.WriteLine($"\nDados do {tipoCadastro}:\n");

            foreach (var dado in pessoa)
            {
                Console.WriteLine($"{dado.Key}: {dado.Value}");
            }
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja fazer um novo registro? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }
    }
}