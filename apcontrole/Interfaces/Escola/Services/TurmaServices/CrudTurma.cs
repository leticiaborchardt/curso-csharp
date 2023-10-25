using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.TurmaServices
{
    public class CrudTurma : ICrudTurma
    {
        public void Create(Turma turma)
        {
            Console.WriteLine("Turma criada!");
        }

        public List<Turma> Read()
        {
            Console.WriteLine("Visualizar turma");
        }

        public void Update(Turma turma)
        {
            Console.WriteLine("Turma editada!");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Turma removida!");
        }
    }
}