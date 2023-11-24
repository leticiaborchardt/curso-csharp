using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.SalaService.Implements;

namespace IsakNewton.WEB.Views
{
    public class SalaView
    {
        private readonly CrudSala _crudSala = new CrudSala();
        private readonly Sala _sala = new Sala();

        public void ViewSala()
        {
            Console.WriteLine("Opção selecionada: Sala\nO que deseja fazer?");
            OpcoesSala();
            string inputSala = Console.ReadLine();

            switch (inputSala)
            {
                case "1":
                    CadastrarSala();
                    break;
                case "2":
                    VisualizarSalas();
                    break;
                case "3":
                    AtualizarSala();
                    break;
                case "4":
                    ExcluirSala();
                    break;
            }
        }

        private string[] OpcoesSala()
        {
            string[] opcoes =
            {
                "Cadastrar Sala", "Visualizar Salas", "Atualizar Salas", "Excluir Salas"
            };

            for (var i = 1; i <= opcoes.Length; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i - 1]}");
            }

            return opcoes;
        }

        private void CadastrarSala()
        {
            Console.WriteLine("Opção selecionada: Cadastro");
            Console.WriteLine("Insira o nº da Sala que deseja cadastrar:");
            _sala.Numero = Console.ReadLine();

            _crudSala.Create(_sala);
        }

        private void VisualizarSalas()
        {
            List<Sala> salas = _crudSala.Read();

            foreach (var sala in salas)
            {
                Console.WriteLine(sala.ToString());
            }
        }

        private void AtualizarSala()
        {
            Console.WriteLine("Opção Selecionada: Atualizar");

            Console.WriteLine("Insira o Id da sala que deseja atualizar:");
            VisualizarSalas();
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o novo número da sala selecionada:");
            _sala.Numero = Console.ReadLine();

            _crudSala.Update(_sala);
        }

        private void ExcluirSala()
        {
            Console.WriteLine("Opção selecionada: Excluir");
            
            Console.WriteLine("Insira o Id da sala que deseja excluir:");
            VisualizarSalas();
            int id = int.Parse(Console.ReadLine());

            _crudSala.Delete(id);
        }
    }
}