using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;
using Modulo4.Escola.Services;

namespace Modulo4.Escola.Views
{
    public class View
    {
        public void Main()
        {
            do
            {
                Console.WriteLine("O que você deseja? (aluno / professor / materia / turma)");
                string tipoCadastro = Console.ReadLine().ToLower();

                switch (tipoCadastro)
                {
                    case "aluno":
                        OperacaoAluno();
                        break;
                    case "professor":
                        OperacaoProfessor();
                        break;
                    case "materia":
                        OperacaoMateria();
                        break;
                    case "turma":
                        OperacaoTurma();
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

        private void OperacaoMateria()
        {
            CrudMateria crudMateria = new CrudMateria();

            Console.WriteLine("O que você deseja fazer?\n1 - Criar\n2 - Visualizar\n3 - Editar\n4 - Excluir");
            string operacao = Console.ReadLine().ToLower();

            switch (operacao)
            {
                case "1":
                    Materia materia = crudMateria.Create();
                    Console.WriteLine("\n" + materia.ToString());
                    break;
                case "2":
                    crudMateria.Read();
                    break;
                case "3":
                    crudMateria.Read();
                    Console.WriteLine("Insira o ID da matéria que você deseja editar:");
                    int idMateriaUpdate = int.Parse(Console.ReadLine());

                    crudMateria.Update(idMateriaUpdate);
                    break;
                case "4":
                    crudMateria.Read();
                    Console.WriteLine("Insira o ID da matéria que você deseja excluir:");
                    int idMateriaDelete = int.Parse(Console.ReadLine());

                    crudMateria.Delete(idMateriaDelete);
                    crudMateria.Read();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void OperacaoTurma()
        {
            CrudTurma crudTurma = new CrudTurma();

            Console.WriteLine("O que você deseja fazer?\n1 - Criar\n2 - Visualizar\n3 - Editar\n4 - Excluir");
            string operacao = Console.ReadLine().ToLower();

            switch (operacao)
            {
                case "1":
                    Turma turma = crudTurma.Create();
                    Console.WriteLine("\n" + turma.ToString());
                    break;
                case "2":
                    crudTurma.Read();
                    break;
                case "3":
                    crudTurma.Read();
                    Console.WriteLine("Insira o ID da turma que você deseja editar:");
                    int idTurmaUpdate = int.Parse(Console.ReadLine());

                    crudTurma.Update(idTurmaUpdate);
                    break;
                case "4":
                    crudTurma.Read();
                    Console.WriteLine("Insira o ID da turma que você deseja excluir:");
                    int idTurmaDelete = int.Parse(Console.ReadLine());

                    crudTurma.Delete(idTurmaDelete);
                    crudTurma.Read();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}