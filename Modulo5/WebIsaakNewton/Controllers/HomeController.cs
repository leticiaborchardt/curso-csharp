using System.Diagnostics;
using IsackNewton.Data;
using IsacNewton.Service.AgendamentoService.Implements;
using Microsoft.AspNetCore.Mvc;
using WebIsaakNewton.Models;

namespace WebIsaakNewton.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Agendamento model)
    {
        CrudAgendamento crudAgendamento = new CrudAgendamento();    

        crudAgendamento.Create(model);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
