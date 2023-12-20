using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Entidades;

public class CloudComputing
{
    public void GerarRelatorioPerdasGanhos(List<object> vendasPerdidasSul, List<object> vendasPerdidasNorte)
    {
        Console.WriteLine("Gerando e apresentando relatório de perdas e ganhos:");

        Console.WriteLine("Região Sul:");
        ApresentarDados(vendasPerdidasSul);

        Console.WriteLine("Região Norte:");
        ApresentarDados(vendasPerdidasNorte);
    }

    private void ApresentarDados(List<object> dados)
    {
        foreach (var item in dados)
        {
            Console.WriteLine($"Cliente: {((dynamic)item).Cliente}, Valor Perdido: {((dynamic)item).ValorPerdido}");
        }
    }
}
