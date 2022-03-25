
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
        {return View();}
        //.......................................................       
        //crear nuevo producto...................................
        //.......................................................
        public IActionResult Producto() { return View(); }

        public IActionResult CrearProducto(Producto producto)
        {
            // aqui no pude hacer que la Descripcion como Categoria no fuera null. creo que poreso no me dio. igual me gustaria que me dijera porque fue que no me cargo
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("ListaProductos");
        }

        public IActionResult ListaProductos()
        {
            List<Producto> productos = _context.Productos.ToList();
            return View(productos);
        }


        public IActionResult EditarProducto(int id)
        {
            Producto modelo = _context.Productos.Where(c => c.Id == id).FirstOrDefault();
            return View(modelo);
        }

        public IActionResult EditarValorProducto(Producto producto)
        {
            //REcupero valor en la base de datos
            Producto productoActual = _context.Productos
                 .Where(uni => uni.Id == producto.Id).FirstOrDefault();

            //actualizo el nombre de la categoria con el nuevo valor
            productoActual.NombreProducto = producto.NombreProducto;

            //persisto los datos en la base de datos.
            _context.SaveChanges();

            List<Producto> productos = _context.Productos.ToList();
            return View("ListaProductos", productos);
        }

        public IActionResult EliminarProducto(int id)
        {

            Producto producto = _context.Productos.Where(a => a.Id == id).FirstOrDefault();

            _context.Remove(producto);
            _context.SaveChanges();

            List<Producto> productos = _context.Productos.ToList();
            return View("ListaProductos", productos);
        }

        public IActionResult verdescripcionProducto(int id)
        {

            // string descripcion  = _context.Categorias.Where(a => a.Id == id).FirstOrDefault().Descripcion;

            string descripcion = "El producto no contiene descripcion";
            Producto producto = _context.Productos.Where(a => a.Id == id).FirstOrDefault();

            if (producto != null && !string.IsNullOrEmpty(producto.DescripcionProducto))
            {
                descripcion = producto.DescripcionProducto;
            }

            return Json(new { descripcion });
        }







        //.......................................................
        //crear nueva categoria..................................
        //.......................................................


        public IActionResult Categoria() { return View(); }

        public IActionResult CrearCategoria(Categoria categoria)
        {
            categoria.FechaCreacion = DateTime.Now;
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return RedirectToAction("ListaCategorias");
        }

        public IActionResult ListaCategorias()
        {
            List<Categoria> categorias = _context.Categorias.ToList();
            return View(categorias);
        }


        public IActionResult EditarCategoria(int id)
        {
            Categoria modelo = _context.Categorias.Where(c => c.Id == id).FirstOrDefault();
            return View(modelo);
        }

        public IActionResult EditarValorCategoria(Categoria categoria)
        {
            //REcupero valor en la base de datos
            Categoria categoriaActual = _context.Categorias
                 .Where(uni => uni.Id == categoria.Id).FirstOrDefault();

            //actualizo el nombre de la categoria con el nuevo valor
            categoriaActual.NombreCategoria = categoria.NombreCategoria;

            //persisto los datos en la base de datos.
            _context.SaveChanges();

            List<Categoria> categorias = _context.Categorias.ToList();
            return View("ListaCategorias", categorias);
        }

        public IActionResult EliminarCategoria(int id)
        {
            List<Producto> productos = _context.Productos.Where(a => a.CategoriaId == id).ToList();

            Categoria categoria = _context.Categorias.Where(a => a.Id == id).FirstOrDefault();

            _context.Remove(categoria);
            _context.SaveChanges();

            List<Categoria> categorias = _context.Categorias.ToList();
            return View("ListaCategorias", categorias);
        }

        public IActionResult ObtenerDescripcion(int id)
        {

            // string descripcion  = _context.Categorias.Where(a => a.Id == id).FirstOrDefault().Descripcion;

            string descripcion = "la categoria no contiene descripcion";
            Categoria categoria = _context.Categorias.Where(a => a.Id == id).FirstOrDefault();

            if (categoria != null && !string.IsNullOrEmpty(categoria.Descripcion))
            {
                descripcion = categoria.Descripcion;
            }

            return Json(new { descripcion });
        }




        //.......................................................
        //crear nuevo Modulo.....................................
        //.......................................................
    }
}
