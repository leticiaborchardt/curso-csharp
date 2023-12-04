using Ap.Controle.Context;
using Ap.Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap.Controle.Repositories
{
    public class MoradorRepository : IMoradorRepository
    {
        private readonly AppDbContext _appDbContext;    

        public IEnumerable<Morador> Moradores { get => _appDbContext.Moradores.Include(c => c.Condominio); set => throw new NotImplementedException(); }

        public MoradorRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public Morador? GetMorador(int id)
        {
            return _appDbContext.Moradores.FirstOrDefault(m => m.Id == id);
        }
    }
}