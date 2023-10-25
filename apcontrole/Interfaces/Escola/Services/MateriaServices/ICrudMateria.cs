using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.MateriaServices
{
    public interface ICrudMateria
    {
        void Create(Materia model);
        List<Materia> Read();
        void Update(Materia model);
        void Delete(int id);
    }
}