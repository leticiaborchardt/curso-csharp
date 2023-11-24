using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.SalaService.Interface
{
    internal interface ISala
    {
        public void Create(Sala model);
        public List<Sala> Read();
        public void Update(Sala model);
        public void Delete(int id);
    }
}
