using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;
using apcontrole.Interfaces.Escola.Services.MateriaServices;

namespace apcontrole.Interfaces.Escola.Services.ProfessorServices
{
    public class CrudProfessor : ICrudProfessor
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
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Id == Id)
                {
                    Console.WriteLine("Nome:");
                    professores[i].Nome = Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Professor não encontrado.");
        }

        public void Delete(int Id)
        {
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Id == Id)
                {
                    professores.RemoveAt(i);
                    Console.WriteLine("Professor removido!");
                    return;
                }
            }

            Console.WriteLine("Professor não encontrado.");
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