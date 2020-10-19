using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaCalificada1.Models;
using PracticaCalificada1.Data;


namespace PracticaCalificada1.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;

        private readonly DatabaseContext _context;


        public RegistroController(ILogger<RegistroController> logger ,  DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Registrar(Formulario objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objContacto);
        }

    }
}
