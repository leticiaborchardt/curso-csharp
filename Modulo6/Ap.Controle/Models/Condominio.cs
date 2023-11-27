using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap.Controle.Models;

public class Condominio
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public List<Morador> Moradores {get; set;}
}
