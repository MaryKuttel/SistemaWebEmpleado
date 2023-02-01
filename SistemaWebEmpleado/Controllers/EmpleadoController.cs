using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBWebEmpleadoContext context;

        public EmpleadoController(DBWebEmpleadoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var empleados = context.Empleados.ToList();
            return View(empleados);
        }

        [HttpGet]
        public ActionResult Create()
        {

            Empleado empleado = new Empleado();

            return View("Create", empleado);

        }


        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

		[HttpGet("{titulo}")]
		public ActionResult<IEnumerable<Empleado>> PorTitulo(string titulo)
		{
			var empleado = (from a in context.Empleados
							where a.Titulo == titulo
							select a).ToList();
			return View("PorTitulo", empleado);

		}
	}
}
