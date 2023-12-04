using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ap.Controle.Models;
using Ap.Controle.Repositories;

namespace Ap.Controle.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //private readonly ICondominioRepository _condominio;
    private readonly IMoradorRepository _morador;

    public HomeController(ILogger<HomeController> logger, IMoradorRepository morador)
    {
        _logger = logger;
        //_condominio = condominio;
        _morador = morador;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult List()
    {
        var moradores = _morador.Moradores;
        
        return View(moradores);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
