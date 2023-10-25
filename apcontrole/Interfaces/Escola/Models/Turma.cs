using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.Interfaces.Escola.Models
{
    public class Turma : BaseModel
    {
        public Professor Professor;
        public List<Aluno> Alunos;
        public List<Materia> Materias;
    }
}