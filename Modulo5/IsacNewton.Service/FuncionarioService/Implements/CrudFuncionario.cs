using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.FuncionarioService.Implements
{
    public class CrudFuncionario
    {
        private static int ProximoId;
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public void Create(Funcionario model)
        {
            model.Id = ProximoId++;
            funcionarios.Add(model);
        }

        public List<Funcionario> Read()
        {
            Console.WriteLine("---------Lista de Funcionários---------");
            return funcionarios;
        }

        public void Update(Funcionario model)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.Id == model.Id);
            if (funcionario != null)
            {
                funcionario.Nome = model.Nome;
                funcionario.SobreNome = model.SobreNome;
                funcionario.DataNacimento = model.DataNacimento;
                funcionario.Documento = model.Documento;
                funcionario.Responsavel = model.Responsavel;
                funcionario.genero = model.genero;
                funcionario.Cargo = model.Cargo;
                funcionario.Turno = model.Turno;
                funcionario.Salario = model.Salario;
            }
            else
            {
                throw new ArgumentException("Funcionário não encontrado");
            }
        }

        public void Delete(int id)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.Id == id);

            if (funcionario != null)
            {
                funcionarios.Remove(funcionario);
            }
        }
    }
}
