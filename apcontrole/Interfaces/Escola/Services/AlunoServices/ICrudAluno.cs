using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.AlunoServices
{
    public interface ICrudAluno
    {
        void Create(Aluno model);
        List<Aluno> Read();
        void Update(Aluno model);
        void Delete(int id);
    }
}