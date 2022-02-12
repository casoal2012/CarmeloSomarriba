
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEB_Core_Conv2.Models;
using CarmeloSomarriba.Data;
using CarmeloSomarriba.Models;

namespace CarmeloSomarriba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyDbcontext _context;

        public DateTime FechaActual { get; private set; }

        public HomeController(ILogger<HomeController> logger, MyDbcontext context)
        {
            _logger = logger;
            _context = context;
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

        public IActionResult Categoria()
        {
            return View();
        }

        public IActionResult CrearCategoria(Categoria categoria)
        {

            categoria.FechaCreacion = DateTime.Now;

            _context.Categorias.Add(categoria);

            _context.SaveChanges();

            return RedirectToAction("Categoria");
        }


        public IActionResult ListaCategorias()
        {
            List<Categoria> categorias = _context.Categorias.ToList();
           

            return View(categorias);
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
