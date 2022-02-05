
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEB_Core_Conv2.Models;

namespace CarmeloSomarriba.Controllers
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

            //

            List<Pacientes> pacientes = new List<Pacientes>();
            pacientes.Add(new Pacientes()
            {
                Nombre = "Otro nombre",
                Direccion = "Managua los robles",
                Edad = 24,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Carlos",
                Direccion = "Caracas",
                Edad = 24,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Otro nombre",
                Direccion = "Managua los robles",
                Edad = 24,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Carlos",
                Direccion = "Caracas",
                Edad = 24,
                Telefono = "84489888"
            });


            return View(pacientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult prueba()
        {
            return View();
        }
        


    }
}
