using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaMedic.Models
{
    public class Medicamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Medicamento")]
        public int ID { get; set; }

        [Required]
        [DisplayName("Nombre de Medicamento")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string Descrpicion { get; set; }
    }
}
