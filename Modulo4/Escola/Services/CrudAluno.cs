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
                sw.WriteLine($"{aluno.Id};{aluno.Matricula};{aluno.Nome};{aluno.Sobrenome}");
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
            List<Aluno> lista = new List<Aluno>();
            string linha;

            try
            {
                StreamReader sr = new StreamReader("Escola/Services/Aluno.txt");
                linha = sr.ReadLine();

                while (linha != null)
                {
                    var aluno = linha.Split(';');
                    Aluno model = new Aluno { Id = Convert.ToInt32(aluno[0]), Matricula = aluno[1], Nome = aluno[2], Sobrenome = aluno[3] };
                    lista.Add(model);
                    linha = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum aluno registrado.");
            }
            else
            {
                foreach (Aluno aluno in lista)
                {
                    Console.WriteLine(aluno.ToString() + "\n");
                }
            }

            return lista;
        }

        public void Update(int id)
        {
            List<Aluno> lista = this.Read();

            Aluno? aluno = lista.Find(x => x.Id == id);

            if (aluno != null)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("Escola/Services/Aluno.txt", false);

                    aluno.Nome = RequisitarAtributo("novo nome");
                    aluno.Sobrenome = RequisitarAtributo("novo sobrenome");
                    aluno.Matricula = RequisitarAtributo("novo código de matrícula");

                    foreach (var alunoLista in lista)
                    {
                        sw.WriteLine($"{alunoLista.Id};{alunoLista.Matricula};{alunoLista.Nome};{alunoLista.Sobrenome}");
                    }

                    sw.Close();
                    Console.WriteLine("Aluno atualizado com sucesso!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public void Delete(int id)
        {
            List<Aluno> lista = Read();
            Aluno? aluno = lista.Find(x => x.Id == id);

            if (aluno != null)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("Escola/Services/Aluno.txt", false);

                    lista.Remove(aluno);

                    foreach (var alunoLista in lista)
                    {
                        sw.WriteLine($"{alunoLista.Id};{alunoLista.Matricula};{alunoLista.Nome};{alunoLista.Sobrenome}");
                    }

                    sw.Close();
                    Console.WriteLine("Aluno removido!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
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