using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods.Enums;

namespace DesignPatterns.FactoryMethods
{
    public class Cliente
    {
        public void Executar()
        {
            var cliente = new SelecionaServico();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecione o tipo de serviço desejado:");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");

                int tipoServico = Convert.ToInt32(Console.ReadLine());
                var servicoEscolhido = cliente.FabricandoProduto((ETipoServico)tipoServico);

                Console.WriteLine("Deseja continuar?\n1 - sim\n2 - não");
                int resposta = Convert.ToInt32(Console.ReadLine());

                continuar = resposta == 1;
            }
        }

    }
}