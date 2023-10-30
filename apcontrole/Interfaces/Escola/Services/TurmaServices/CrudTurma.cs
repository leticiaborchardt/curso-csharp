using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;
using apcontrole.Interfaces.Escola.Services.ProfessorServices;
using apcontrole.Interfaces.Escola.Services.AlunoServices;
using apcontrole.Interfaces.Escola.Services.MateriaServices;

namespace apcontrole.Interfaces.Escola.Services.TurmaServices
{
    public class CrudTurma : ICrudTurma
    {
        private static List<Turma> turmas = new List<Turma>();
        public Turma Create()
        {
            Turma turma = new Turma();

            turma.Professor = VincularProfessor();
            //turma.Alunos = VincularAlunos();
            //turma.Materias = VincularMaterias();

            turmas.Add(turma);

            Console.WriteLine("Turma criada!");

            return turma;
        }

        public void Read()
        {
            Console.WriteLine("Visualizar turma");
        }

        public void Update(int id)
        {
            Console.WriteLine("Turma editada!");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Turma removida!");
        }


        private Professor VincularProfessor()
        {
            CrudProfessor crudProfessor = new CrudProfessor();

            List<Professor> professores = crudProfessor.Read();
            Console.WriteLine("Insira o ID do professor da turma:");

            int idProfessor = int.Parse(Console.ReadLine());

            if (professores.Count > 0)
            {
                for (int i = 0; i < professores.Count; i++)
                {
                    if (professores[i].Id == idProfessor)
                    {
                        return professores[i];
                    }
                }
            }

            Console.WriteLine("Cadastrar professor:");
            return crudProfessor.Create();
        }
    }
}