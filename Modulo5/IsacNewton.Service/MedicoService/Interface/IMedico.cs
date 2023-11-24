using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.MedicoService.Interface
{
    public interface IMedico
    {
        void Create(Medico model);

        List<Medico> Read();

        void Update(Medico model);
        
        void Delete(int id);
    }
}
