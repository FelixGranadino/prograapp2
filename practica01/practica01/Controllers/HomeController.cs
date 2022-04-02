using Microsoft.AspNetCore.Mvc;
using practica01.Bussines;
using practica01.Models;
using System.Diagnostics;

namespace practica01.Controllers
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
        //importante sin una accion no tenemos vistas

         public IActionResult Suma(Acciones Acciones)
         {
            //Objeto de negocio
           Operaciones op = new Operaciones();
           Double resultado = op.Suma(Acciones);

           ViewBag.VariableAEnviar = resultado;
           return View();
    }
        public IActionResult Resta(Acciones Acciones)
        {
            //Objeto de negocio
            Operaciones op = new Operaciones();
            Double resultado = op.Resta(Acciones);

            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Multiplicacion(Acciones Acciones)
        {
            //Objeto de negocio
            Operaciones op = new Operaciones();
            Double resultado = op.Multiplicacion(Acciones);

            ViewBag.VariableAEnviar = resultado;
            return View();
        }
        public IActionResult Division(Acciones Acciones)
        {
            //Objeto de negocio
            Operaciones op = new Operaciones();
            Double resultado = op.Division(Acciones);

            ViewBag.VariableAEnviar = resultado;
            return View();
        }
        public IActionResult NoMayores()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PeticionTypeGet()
        {
            return View();
        }
    }
}