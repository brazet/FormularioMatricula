using Microsoft.AspNetCore.Mvc;
using matricula.Models;
using matricula.Data;

namespace matricula.Controllers
{
    public class AlumnoController:Controller
    {
        private readonly AplicationDbContext _context;

        public AlumnoController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Alumno objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno se encuentra registrado";
            return View("Index");
        }

    }
}