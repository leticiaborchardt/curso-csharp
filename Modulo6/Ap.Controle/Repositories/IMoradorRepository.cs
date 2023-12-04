using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap.Controle.Models;

namespace Ap.Controle.Repositories
{
    public interface IMoradorRepository
    {
        IEnumerable<Morador> Moradores { get; set; }

        Morador? GetMorador(int id);
    }
}