using System;
using System.ComponentModel.DataAnnotations;

namespace CarmeloSomarriba.Models
{
    public class Categoria
    {

        [Key]
        public string Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo Nombre es necesario")]
        public string NombreCategoria { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo Descripcion es necesario")]
        public string Descripcion { get; set; }


        public DateTime FechaCreacion { get; set; }
    }
}
