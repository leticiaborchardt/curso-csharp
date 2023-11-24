using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.PacienteService.Interface
{
    public interface IPaciente
    {
        void Create(Paciente model);
        List<Paciente> Read();
        void Update(Paciente model);
        void Delete(int id);
    }
}
