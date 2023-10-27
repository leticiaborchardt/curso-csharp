using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.MateriaServices
{
    public class CrudMateria : ICrudMateria
    {
        public void Create(Materia materia)
        {
            Console.WriteLine("Matéria criada!");
        }

        public void Read()
        {
            Console.WriteLine("Visualizar matéria");
        }

        public void Update(Materia materia)
        {
            Console.WriteLine("Matéria editada!");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Materia removida!");
        }
    }
}