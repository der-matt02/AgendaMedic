using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaMedic.Models
{
    [Table("Paciente")]
    public class Paciente : Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Paciente")]
        public int ID { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Genero")]
        [Required]
        public string Genero { get; set; }

        [Required]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        

        [Required]
        [DisplayName("Ciudad")]
        public string Ciudad { get; set; }

        [DisplayName("Provincia")]
        public string? Provincia { get; set; }

        [DisplayName("Pariente Responsable")]
        public string? ParentescoResp { get; set; }

        [DisplayName("Telefono de Pariente")]
        public string? TelefonoParentesco { get; set; }
    }
}
