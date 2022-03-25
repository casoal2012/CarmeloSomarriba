using System;
using System.ComponentModel.DataAnnotations;
using WEB_Core_Conv2.Models;

namespace CarmeloSomarriba.Models
{

    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string NombreProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public int Precio { get; set; }

        public DateTime FechaIngreso { get; set; }

        public string ImagenProducto { get; set; }

        public int CategoriaId { get; set; }
        [Foreignkey("CategoriaId")]
        public Categoria categoria { get; set; }
    }
}
