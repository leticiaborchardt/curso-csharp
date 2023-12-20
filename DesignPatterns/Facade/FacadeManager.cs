using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Facade.Entidades;

namespace DesignPatterns.Facade;

public class FacadeManager
{
    public void ExecutarComplexidade()
    {
        ZonaNorte zonaNorte = new ZonaNorte();
        ZonaSul zonaSul = new ZonaSul();
        CloudComputing cloudComputing = new CloudComputing();

        zonaSul.ExecutarRotinaVendasPerdidas(DateTime.Now);
        zonaNorte.ExecutarRotinaVendasPerdidas(DateTime.Now);

        cloudComputing.GerarRelatorioPerdasGanhos(zonaSul.VendasPerdidas, zonaNorte.VendasPerdidas);
    }
}
