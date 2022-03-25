using CarmeloSomarriba.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace WEB_Core_Conv2.Models
{

    public class Productos
    {
        [Key]
        [StringLength(100)]
        [Required(ErrorMessage = "El campo Id es necesario")]
        public string IdProducto { get; set; }






        [StringLength(100)]
        [Required(ErrorMessage = "El campo Nombre es necesario")]
        public string NombreDelProducto { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "El campo Precio es necesario")]
        public double Precio { get; set; }

        [StringLength(12)]
        [Required(ErrorMessage = "El campo Descripcion es necesario")]
        public string Descripcion { get; set; }

        public DateTime FechaDeCreacion { get; set; }


        public int CategoriaId { get; set; }

        [Foreignkey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}