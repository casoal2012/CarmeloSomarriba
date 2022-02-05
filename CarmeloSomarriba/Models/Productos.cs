using System.ComponentModel.DataAnnotations;

namespace WEB_Core_Conv2.Models
{

    public class Productos
    {
        [Key]
        [StringLength(100)]
        [Required(ErrorMessage = "El campo Id es necesario")]
        public string IdDelProducto { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo Nombre es necesario")]
        public string NombreDelProducto { get; set; }

        [StringLength(12)]
        [Required(ErrorMessage = "El campo Descripcion es necesario")]
        public string Descripcion { get; set; }

    }
}