using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.ProfessorServices
{
    public interface ICrudProfessor
    {
        Professor Create();
        void Read();
        void Update(int id);
        void Delete(int id);
    }
}