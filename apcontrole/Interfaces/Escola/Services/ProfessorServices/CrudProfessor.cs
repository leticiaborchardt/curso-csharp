using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.ProfessorServices
{
    public class CrudProfessor : ICrudProfessor
    {
        public Professor Create()
        {
            Console.WriteLine("Professor criado!");
        }

        public List<Professor> Read()
        {
            Console.WriteLine("Visualizar professor");
        }

        public void Update(Professor professor)
        {
            Console.WriteLine("Professor editado!");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Professor removido!");
        }
    }
}