using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.MateriaServices
{
    public class CrudMateria : ICrudMateria
    {
        private static List<Materia> materias = new List<Materia>();

        public Materia Create()
        {
            Materia materia = new Materia();
            materia.Nome = RequisitarAtributo("nome");
            materia.Descricao = RequisitarAtributo("descrição");

            materias.Add(materia);

            Console.WriteLine("Matéria criada!");

            return materia;
        }

        public void Read()
        {
            Console.WriteLine("Lista de matérias:\n");

            if (materias.Count == 0)
            {
                Console.WriteLine("Nenhuma matéria registrado.");
            }
            else
            {
                foreach (Materia materia in materias)
                {
                    Console.WriteLine(materia.ToString() + "\n");
                }
            }
        }

        public void Update(int id)
        {
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].Id == id)
                {
                    Console.WriteLine("Nome:");
                    materias[i].Nome = Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Matéria não encontrada.");
        }

        public void Delete(int id)
        {
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].Id == id)
                {
                    materias.RemoveAt(i);
                    Console.WriteLine("Matéria removida!");
                    return;
                }
            }

            Console.WriteLine("Matéria não encontrada.");
        }

        public string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }
    }
}