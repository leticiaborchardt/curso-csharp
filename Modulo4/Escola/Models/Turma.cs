using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo4.Escola.Models
{
    public class Turma : BaseModel
    {
        public Professor Professor;
        public List<Aluno> Alunos;
        public List<Materia> Materias;

        public override string ToString()
        {
            string nomesAlunos = "";
            string nomesMaterias = "";

            foreach (var aluno in Alunos)
            {
                nomesAlunos += "\n" + aluno.Nome;
            }

            foreach (var materia in Materias)
            {
                nomesMaterias += "\n" + materia.Nome;
            }

            return $"ID: {this.Id}\nProfessor: {this.Professor.Nome}\nAlunos: {nomesAlunos}\nMatérias {nomesMaterias}";
        }
    }
}