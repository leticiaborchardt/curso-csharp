using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo4.Escola.Models;

namespace Modulo4.Escola.Services
{
    public interface ICrud<T> where T : BaseModel
    {
        T Create();
        List<T> Read();
        void Update(int id);
        void Delete(int id);
    }
}