using Microsoft.AspNetCore.Mvc;
using practica01.Models;
using practica01.Service;

namespace practica01.Controllers
{
    public class StudentsController : Controller
    {

        private IEstudiante Estudiante;

        public StudentsController(IEstudiante estudiante)
        {
            Estudiante = estudiante;
        }
        public IActionResult Index()
        {
            //Estudiantes es = new Estudiantes();
            //es.Name = "Fredy";
            //es.LastName = "Benitez";
            //Estudiante.AddStudent(es);
            return View();
        }
        [HttpPost]

        public IActionResult Insertdata(Estudiantes es)
        {
            return RedirectToAction("Index");
        }
    }
}
