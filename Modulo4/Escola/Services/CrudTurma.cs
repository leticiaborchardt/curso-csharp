using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;

namespace Modulo4.Escola.Services
{
    public class CrudTurma : ICrud<Turma>
    {
        private static List<Turma> turmas = new List<Turma>();
        public Turma Create()
        {
            Turma turma = new Turma();

            turma.Professor = VincularProfessor();
            turma.Alunos = VincularAlunos();
            turma.Materias = VincularMaterias();

            turmas.Add(turma);

            Console.WriteLine("Turma criada!");

            return turma;
        }

        public List<Turma> Read()
        {
            Console.WriteLine("Visualizar turma");

            return turmas;
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

            if (professores.Count > 0)
            {
                Console.WriteLine("Insira o ID do professor da turma:");

                int idProfessor = int.Parse(Console.ReadLine());

                Professor? professor = professores.Find(x => x.Id == idProfessor);

                if (professor != null)
                {
                    return professor;
                }
            }

            Console.WriteLine("Cadastrar professor:");
            return crudProfessor.Create();
        }

        private List<Aluno> VincularAlunos()
        {
            CrudAluno crudAluno = new CrudAluno();

            List<Aluno> alunosCadastrados = crudAluno.Read();
            List<Aluno> alunosTurma = new List<Aluno>();

            if (alunosCadastrados.Count > 0)
            {
                Console.WriteLine("Insira os ID's do alunos da turma, separados por vírgula:");

                string idsAlunos = Console.ReadLine();
                string[] idsArray = idsAlunos.Split(',');

                List<string> ids = new List<string>(idsArray);

                foreach (var id in ids)
                {
                    Aluno? aluno = alunosCadastrados.Find(x => x.Id == int.Parse(id));

                    if (aluno != null)
                    {
                        alunosTurma.Add(aluno);
                    }
                }
            }
            else
            {
                Console.WriteLine("Cadastre primeiro um aluno antes de cadastrar uma turma");
            }

            return alunosTurma;
        }

        private List<Materia> VincularMaterias()
        {
            CrudMateria crudMateria = new CrudMateria();

            List<Materia> materiasCadastradas = crudMateria.Read();
            List<Materia> materiasTurma = new List<Materia>();

            if (materiasCadastradas.Count > 0)
            {
                Console.WriteLine("Insira os ID's das materias da turma, separados por vírgula:");

                string idsAlunos = Console.ReadLine();
                string[] idsArray = idsAlunos.Split(',');

                List<string> ids = new List<string>(idsArray);

                foreach (var id in ids)
                {
                    Materia? materia = materiasCadastradas.Find(x => x.Id == int.Parse(id));

                    if (materia != null)
                    {
                        materiasTurma.Add(materia);
                    }
                }
            }
            else
            {
                Console.WriteLine("Cadastre primeiro uma matéria antes de cadastrar uma turma");
            }

            return materiasTurma;
        }
    }
}