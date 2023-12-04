using Ap.Controle.Migrations;

namespace Ap.Controle.Repositories
{
    public interface ICondominioRepository
    {
        IEnumerable<Condominio> Condominios {get; set;}

    }
}