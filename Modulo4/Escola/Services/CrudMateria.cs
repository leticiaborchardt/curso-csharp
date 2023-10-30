using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;
using Modulo4.Escola.Services;

namespace Modulo4.Escola.Services
{
    public class CrudMateria : ICrud<Materia>
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

        public List<Materia> Read()
        {
            Console.WriteLine("Lista de matérias:\n");

            if (materias.Count == 0)
            {
                Console.WriteLine("Nenhuma matéria registrada.");
            }
            else
            {
                foreach (Materia materia in materias)
                {
                    Console.WriteLine(materia.ToString() + "\n");
                }
            }

            return materias;
        }

        public void Update(int id)
        {
            Materia? materia = materias.Find(m => m.Id == id);

            if (materia != null)
            {
                materia.Nome = RequisitarAtributo("outro nome");
                materia.Descricao = RequisitarAtributo("outra descrição");

                Console.WriteLine("Matéria atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Matéria não encontrada.");
            }
        }

        public void Delete(int id)
        {
            Materia? materia = materias.Find(m => m.Id == id);

            if (materia != null)
            {
                materias.Remove(materia);

                Console.WriteLine("Matéria removida!");
            }
            else
            {
                Console.WriteLine("Matéria não encontrada.");
            }
        }

        public string RequisitarAtributo(string atributo)
        {
            Console.WriteLine($"Digite o {atributo}:");
            return Console.ReadLine();
        }
    }
}