using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaMedic.Models
{
    public class Alergia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Alergia")]
        public int ID { get; set; }

        [Required]
        [DisplayName("Nombre de Alergia")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string Descrpicion {  get; set; }
    }
}
