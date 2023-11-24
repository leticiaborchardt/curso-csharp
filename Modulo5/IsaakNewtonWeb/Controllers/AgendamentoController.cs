using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.AgendamentoService.Implements;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IsaakNewtonWeb.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly ILogger<AgendamentoController> _logger;

        public AgendamentoController(ILogger<AgendamentoController> logger)
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

            List<Agendamento> agendamentos = crudAgendamento.Read();
            Agendamento agendamentoCadastrado = agendamentos.Find(x => x.Id == model.Id);

            if (agendamentoCadastrado != null)
            {
                Console.WriteLine("Agendamento cadastrado:");
                Console.WriteLine(agendamentoCadastrado.DataAgendamento);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}