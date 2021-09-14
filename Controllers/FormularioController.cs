using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica2.Models;

namespace practica2.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Indexa(){
            return View();
        }

        [HttpPost]
        public IActionResult Indexa(string nombres, string apellido_paterno, string apellido_materno, string tipo_mascota, string descripcion, string telefono, string distrito, string direccion)
        {
            Console.WriteLine(nombres);
            Console.WriteLine(apellido_paterno);
            Console.WriteLine(apellido_materno);
            Console.WriteLine(tipo_mascota);
            Console.WriteLine(descripcion);
            Console.WriteLine(telefono);
            Console.WriteLine(distrito);
            Console.WriteLine(direccion);
            return RedirectToAction("IndexaConfirmacion");
        }

        public IActionResult IndexaConfirmacion()
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