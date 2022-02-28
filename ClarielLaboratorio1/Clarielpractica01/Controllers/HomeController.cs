using Clarielpractica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Clarielpractica01.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Importante sin una accion no tenemos vistas
        public IActionResult Ejercicio(double DatoN1, double DatoN2, double DatoN3, double DatoN4, double DatoN5, double DatoN6, String nombre) {

            Double p1 = ((DatoN4 * 0.6) + (DatoN1 * 0.4)) * 0.33;
            Double p2 = ((DatoN5 * 0.6) + (DatoN2 * 0.4)) * 0.33;
            Double p3 = ((DatoN6 * 0.6) + (DatoN3 * 0.4)) * 0.34;

            Double resultado = p1 + p2 + p3;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.DatoN3V = DatoN3;
            ViewBag.DatoN3V = DatoN4;
            ViewBag.DatoN3V = DatoN5;
            ViewBag.DatoN3V = DatoN6;


            ViewBag.VariableAEnviar = resultado;
            ViewBag.VariableNombre = nombre;
            return View();
        } 
        
    }
}