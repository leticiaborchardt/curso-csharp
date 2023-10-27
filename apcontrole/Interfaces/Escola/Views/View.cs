using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;
using apcontrole.Interfaces.Escola.Services;
using apcontrole.Interfaces.Escola.Services.ProfessorServices;
using apcontrole.Interfaces.Escola.Services.AlunoServices;

namespace apcontrole.Interfaces.Escola.Views
{
    public class View
    {
        public void Main()
        {
            // Rotina de cadastros da escola
            do
            {
                Console.WriteLine("O que você deseja? (professor / aluno / materia / turma)");
                string tipoCadastro = Console.ReadLine().ToLower();

                switch (tipoCadastro)
                {
                    case "aluno":
                        OperacaoAluno();
                        break;
                    case "professor":
                        OperacaoProfessor();
                        break;
                    default:
                        Console.WriteLine("Esta opção não existe!");
                        break;
                }


            } while (Continuar());
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja fazer outra operação? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }

        private void OperacaoAluno()
        {
            CrudAluno crudAluno = new CrudAluno();

            Console.WriteLine("O que você deseja fazer?\n1 - Criar\n2 - Visualizar\n3 - Editar\n4 - Excluir");
            string operacao = Console.ReadLine().ToLower();

            switch (operacao)
            {
                case "1":
                    Aluno aluno = crudAluno.Create();
                    Console.WriteLine("\n" + aluno.ToString());
                    break;
                case "2":
                    crudAluno.Read();
                    break;
                case "3":
                    crudAluno.Read();
                    Console.WriteLine("Insira o ID do aluno que você deseja editar:");
                    int idAlunoUpdate = int.Parse(Console.ReadLine());

                    crudAluno.Update(idAlunoUpdate);
                    break;
                case "4":
                    crudAluno.Read();
                    Console.WriteLine("Insira o ID do aluno que você deseja excluir:");
                    int idAlunoDelete = int.Parse(Console.ReadLine());

                    crudAluno.Delete(idAlunoDelete);
                    crudAluno.Read();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void OperacaoProfessor()
        {
            CrudProfessor crudProfessor = new CrudProfessor();

            Console.WriteLine("O que você deseja fazer?\n1 - Criar\n2 - Visualizar\n3 - Editar\n4 - Excluir");
            string operacao = Console.ReadLine().ToLower();

            switch (operacao)
            {
                case "1":
                    Professor professor = crudProfessor.Create();
                    Console.WriteLine("\n" + professor.ToString());
                    break;
                case "2":
                    crudProfessor.Read();
                    break;
                case "3":
                    crudProfessor.Read();
                    Console.WriteLine("Insira o ID do professor que você deseja editar:");
                    int idProfessorUpdate = int.Parse(Console.ReadLine());

                    crudProfessor.Update(idProfessorUpdate);
                    break;
                case "4":
                    crudProfessor.Read();
                    Console.WriteLine("Insira o ID do professor que você deseja excluir:");
                    int idProfessorDelete = int.Parse(Console.ReadLine());

                    crudProfessor.Delete(idProfessorDelete);
                    crudProfessor.Read();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}