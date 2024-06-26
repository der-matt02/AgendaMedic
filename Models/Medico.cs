using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaMedic.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Medico")]
        public int ID { get; set; }


        [Required]
        [DisplayName("Codigo")]
        public int Codigo { get; set; }


        [Required]
        [DisplayName("Disponibilidad")]
        public string Disponibilidad { get; set; }


        [Required]
        [DisplayName("Especialidad")]
        public string Especialidad { get; set; }
    }
}
