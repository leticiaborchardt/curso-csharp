using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

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

            Console.WriteLine("Professor criado!");

            return new Professor();
        }

        public void Read()
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
        }

        public void Update(int Id)
        {
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Id == Id)
                {
                    Console.WriteLine("Nome:");
                    professores[i].Nome = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Professor não encontrado.");
                }
            }
        }

        public void Delete(int Id)
        {
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Id == Id)
                {
                    professores.RemoveAt(i);
                    Console.WriteLine("Professor removido!");
                    break;
                }
                else
                {
                    Console.WriteLine("Professor não encontrado.");
                }
            }
        }

        private string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }
    }
}