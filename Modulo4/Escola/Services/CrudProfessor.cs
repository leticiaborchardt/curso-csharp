using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;

namespace Modulo4.Escola.Services
{
    public class CrudProfessor : ICrud<Professor>
    {
        private static List<Professor> professores = new List<Professor>();

        public Professor Create()
        {
            Professor professor = new Professor();
            professor.Nome = RequisitarAtributo("nome");
            professor.Sobrenome = RequisitarAtributo("sobrenome");
            professor.Matricula = RequisitarAtributo("código de matrícula");
            professor.Materias = RequisitarMaterias();

            professores.Add(professor);

            Console.WriteLine("Professor criado!");

            return professor;
        }

        public List<Professor> Read()
        {
            Console.WriteLine("Lista de professores:\n");

            if (professores.Count == 0)
            {
                Console.WriteLine("Nenhum professor registrado.");
            }
            else
            {
                foreach (Professor professor in professores)
                {
                    Console.WriteLine(professor.ToString() + "\n");
                }
            }

            return professores;
        }

        public void Update(int Id)
        {
            Professor? professor = professores.Find(x => x.Id == Id);

            if (professor != null)
            {
                professor.Nome = RequisitarAtributo("novo nome");
                professor.Sobrenome = RequisitarAtributo("novo sobrenome");
                professor.Matricula = RequisitarAtributo("novo código de matrícula");

                Console.WriteLine("Professor atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Professor não encontrado.");
            }
        }

        public void Delete(int Id)
        {
            Professor? professor = professores.Find(x => x.Id == Id);

            if (professor != null)
            {
                professores.Remove(professor);
                Console.WriteLine("Professor removido!");
            }
            else
            {
                Console.WriteLine("Professor não encontrado.");
            }
        }

        private string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }

        private List<Materia> RequisitarMaterias()
        {
            CrudMateria crudMateria = new CrudMateria();
            List<Materia> materias = new List<Materia>();

            do
            {
                Console.WriteLine("Matérias do professor:");

                Materia materia = crudMateria.Create();

                materias.Add(materia);
            } while (Continuar());

            return materias;
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja cadastrar outra materia? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }
    }
}