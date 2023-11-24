using IsackNewton.Data;
using IsacNewtonweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsacNewtonweb.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult List() 
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        //auto-bind
        [HttpPost]
        public IActionResult Create(Funcionario model)
        {
         
            return View(model);
        }
        public IActionResult Update()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}