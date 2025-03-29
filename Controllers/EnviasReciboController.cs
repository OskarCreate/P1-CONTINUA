using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P1_CONTINUA.Models;

namespace P1_CONTINUA.Controllers
{
    public class EnviasReciboController : Controller
    {
        private readonly ILogger<EnviasReciboController> _logger;

        public EnviasReciboController(ILogger<EnviasReciboController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cambio()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CalcularCambio(decimal envio, string origen, string destino)
        {
            decimal tasaCambio = ObtenerTasaCambio(origen, destino);
            decimal recibe = envio * tasaCambio;
            return Json(new { recibe = recibe });
        }

        private decimal ObtenerTasaCambio(string origen, string destino)
        {
            if (origen == "PEN" && destino == "BRL") return 1.578m;
            if (origen == "PEN" && destino == "DOL") return 0.27m;
            if (origen == "BRL" && destino == "PEN") return 1 / 1.578m;
            if (origen == "BRL" && destino == "DOL") return 0.17m;
            if (origen == "DOL" && destino == "PEN") return 1 / 0.27m;
            if (origen == "DOL" && destino == "BRL") return 1 / 0.17m;
            return 1;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
