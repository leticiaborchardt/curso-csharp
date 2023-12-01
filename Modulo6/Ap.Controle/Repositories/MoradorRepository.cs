using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap.Controle.Context;
using Ap.Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap.Controle.Repositories
{
    public class MoradorRepository : IMoradorRepository
    {
        private readonly AppDbContext _AppDbContext;    

        public IEnumerable<Morador> Moradores { get => _AppDbContext.Moradores.Include(m => m.Id); set;}

        public MoradorRepository(AppDbContext appDbContext)
        {
            this._AppDbContext = appDbContext;
        }
    }
}