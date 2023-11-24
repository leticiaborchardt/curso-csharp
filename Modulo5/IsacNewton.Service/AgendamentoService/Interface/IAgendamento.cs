using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.AgendamentoService.Interface
{
    public interface IAgendamento
    {
        void Create(Agendamento model);
        List<Agendamento> Read();
        void Update(Agendamento model);
        void Delete(int id);
    }
}
