using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaMedic.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Usuario")]
        public int ID { get; set; }

        [Required]
        [DisplayName("Cédula")]
        public string Cedula { get; set; }

        [Required]
        [DisplayName("Primer Nombre")]
        public string PrimerNombre { get; set; }

        [DisplayName("Segundo Nombre")]
        public string? SegundoNombre { get; set; }

        [Required]
        [DisplayName("Primer Apellido")]
        public string? PrimerApellido { get; set; }

        [Required]
        [DisplayName("Segundo Apellido")]
        public string? SegundoApellido { get; set; }

        [Required]
        [DisplayName("Numero Telefono")]
        public string? NumeroTelefono { get; set; }

        [Required]
        [DisplayName("Correo Electronico")]
        public string Correo { get; set; }
    }
}



