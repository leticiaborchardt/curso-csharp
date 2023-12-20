using DesignPatterns.Facade;
using DesignPatterns.FactoryMethods;

// Console.WriteLine("Factory method:");

// Cliente cliente = new Cliente();
// cliente.Executar();


Console.WriteLine("Facade method:\n");

FacadeManager facadeManager = new FacadeManager();

facadeManager.ExecutarComplexidade();