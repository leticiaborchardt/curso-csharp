using IsackNewton.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.FuncionarioService.Interface
{
    public interface IFuncionario
    {
        void Create(Funcionario model);
        List<Funcionario> Read();
        void Update(Funcionario model);
        void Delete(int id);
    }
}
