using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.AlunoServices
{
    public class CrudAluno : ICrudAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public Aluno Create()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = RequisitarAtributo("nome");
            aluno.Sobrenome = RequisitarAtributo("sobrenome");
            aluno.Matricula = RequisitarAtributo("código de matrícula");

            alunos.Add(aluno);

            Console.WriteLine("Aluno criado!");

            return aluno;
        }

        public void Read()
        {
            Console.WriteLine("Lista de alunos:\n");

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno registrado.");
            }
            else
            {
                foreach (Aluno aluno in alunos)
                {
                    Console.WriteLine(aluno.ToString() + "\n");
                }
            }
        }

        public void Update(int id)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Id == id)
                {
                    Console.WriteLine("Nome:");
                    alunos[i].Nome = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Id == id)
                {
                    alunos.RemoveAt(i);
                    Console.WriteLine("Aluno removido!");
                    break;
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
        }

        public string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }
    }
}