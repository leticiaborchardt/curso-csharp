using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Entidades;

public class ZonaNorte
{
    public readonly List<object> VendasPerdidas = new List<object>() {};

    public void ExecutarRotinaVendasPerdidas(DateTime periodo)
    {
        Console.WriteLine($"Rotina de vendas perdidas na região norte: {periodo}");

        VendasPerdidas.Add(new {Cliente = "Letícia", ValorPerdido = 150});
        VendasPerdidas.Add(new {Cliente = "João", ValorPerdido = 250});
    }
}
