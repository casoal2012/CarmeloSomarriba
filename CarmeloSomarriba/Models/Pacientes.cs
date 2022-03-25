using System.ComponentModel.DataAnnotations;

namespace WEB_Core_Conv2.Models
{

    public class Pacientes
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo nombre es necesario")]
        public string Nombre { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "El campo Direccion es necesario")]
        public string Direccion { get; set; }

        [StringLength(12)]
        [Required(ErrorMessage = "El campo Telefono es necesario")]
        public string Telefono { get; set; }


        public int Edad { get; set; }


    }
}