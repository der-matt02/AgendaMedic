using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaMedic.Models
{
    public class Tratamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID Tratamiento")]
        public int ID { get; set; }
        
        [Required]
        [DisplayName("Inicio de Tratamiento")]
        public DateTime InicioTratamiento {  get; set; }

        
        [DisplayName("Fin de Tratamiento")]
        public DateTime? FinTratamiento { get; set; }

        [Required]
        [DisplayName("Condicion")]
        public string Condicion {  get; set; }

        [Required]
        [DisplayName("Farmacos")]
        public List<string> Farmaco { get; set; }

    }
}
