using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap.Controle.Models;

public class Morador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Apartamento { get; set; }
    public decimal TaxaCondominio { get; set; }
    public int CondominioId { get; set; }
    public virtual Condominio Condominio { get; set; }
}
