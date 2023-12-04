using Ap.Controle.Context;
using Ap.Controle.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Ap.Controle.Repositories
{
    public class CondominioRepository : ICondominioRepository
    {
        private readonly AppDbContext _appDbContext;

        public IEnumerable<Condominio> Condominios { get => (IEnumerable<Condominio>)_appDbContext.Condominios.Include(c => c.Id); set => throw new NotImplementedException(); }

        public CondominioRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
    }
}