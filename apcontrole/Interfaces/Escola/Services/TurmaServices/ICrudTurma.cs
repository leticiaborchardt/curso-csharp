using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.TurmaServices
{
    public interface ICrudTurma
    {
        Turma Create();
        void Read();
        void Update(int id);
        void Delete(int id);
    }
}