
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
                Nombre = "Martha",
                Direccion = "TipiTapa",
                Edad = 21,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Carlos",
                Direccion = "Managua Linda vista",
                Edad = 40,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Manuel",
                Direccion = "Ciudad Sandino",
                Edad = 44,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Enoc",
                Direccion = "Caracas",
                Edad = 39,
                Telefono = "84489888"
            });









            List<Productos> Productos = new List<Productos>();
           
            pacientes.Add(new Pacientes()
            {
                Nombre = "Carlos",
                Direccion = "Managua Linda vista",
                Edad = 40,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Manuel",
                Direccion = "Ciudad Sandino",
                Edad = 44,
                Telefono = "84489888"
            });

            pacientes.Add(new Pacientes()
            {
                Nombre = "Enoc",
                Direccion = "Caracas",
                Edad = 39,
                Telefono = "84489888"
            });

            return View(pacientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult prueba()
        {
            return View();
        }

        public IActionResult Productos()
        {
            return View();
        }


    }
}
