using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;

namespace Modulo4.Escola.Services
{
    public class CrudAluno : ICrud<Aluno>
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public Aluno Create()
        {
            Aluno aluno = new Aluno();

            try
            {
                aluno.Nome = RequisitarAtributo("nome");
                aluno.Sobrenome = RequisitarAtributo("sobrenome");
                aluno.Matricula = RequisitarAtributo("código de matrícula");

                alunos.Add(aluno);

                StreamWriter sw = new StreamWriter("Escola/Services/Aluno.txt", true);
                sw.WriteLine(aluno);
                sw.Close();

                Console.WriteLine("Aluno criado!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return aluno;
        }

        public List<Aluno> Read()
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

            return alunos;
        }

        public void Update(int id)
        {
            Aluno? aluno = alunos.Find(x => x.Id == id);

            if (aluno != null)
            {
                aluno.Nome = RequisitarAtributo("novo nome");
                aluno.Sobrenome = RequisitarAtributo("novo sobrenome");
                aluno.Matricula = RequisitarAtributo("novo código de matrícula");

                Console.WriteLine("Aluno atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public void Delete(int id)
        {
            Aluno? aluno = alunos.Find(x => x.Id == id);

            if (aluno != null)
            {
                alunos.Remove(aluno);
                Console.WriteLine("Aluno removido!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }
    }
}