using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Entidades;

public class ZonaSul
{
    public readonly List<object> VendasPerdidas = new List<object>() {};

    public void ExecutarRotinaVendasPerdidas(DateTime periodo)
    {
        Console.WriteLine($"Rotina de vendas perdidas na região sul: {periodo}");

        VendasPerdidas.Add(new {Cliente = "Alana", ValorPerdido = 190});
        VendasPerdidas.Add(new {Cliente = "Nicolas", ValorPerdido = 540});
    }
}
