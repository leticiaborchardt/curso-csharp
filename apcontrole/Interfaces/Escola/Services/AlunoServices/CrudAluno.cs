using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;

namespace apcontrole.Interfaces.Escola.Services.AlunoServices
{
    public class CrudAluno : ICrudAluno
    {
        public void Create(Aluno aluno)
        {
            Console.WriteLine("Aluno criado!");
        }

        public List<Aluno> Read()
        {
            Console.WriteLine("Visualizar aluno");
        }

        public void Update(Aluno aluno)
        {
            Console.WriteLine("Aluno editado!");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Aluno removido!");
        }
    }
}