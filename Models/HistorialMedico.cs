using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AgendaMedic.Models
{
    public class HistorialMedico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID HistorialMedico")]
        public int ID { get; set; }

        [Required]
        [DisplayName("FechaElaboración")]
        public DateTime FechaElaboracion { get; set; }

        [Required]
        [DisplayName("Motivo de la Consulta")]
        public string MotivoConsulta { get; set; }

        
        [DisplayName("Enfermedad Actual")]
        public string? EnfermedadActual { get; set; }

 
        [DisplayName("Antecedentes")]
        public List<string>? Antecedente { get; set; }

        [ForeignKey("Paciente")]
        public int PacienteID { get; set; }

        [ForeignKey("Medico")]
        public int MedicoID { get; set; }

        [ForeignKey("Tratamiento")]
        public int TratamientoID { get; set; }

        [ForeignKey("Alergia")]
        public int AlergiaID { get; set; }

        [ForeignKey("Medicamento")]
        public int MedicamentoID { get; set; }










    }
}
