using System.ComponentModel.DataAnnotations;

namespace Labb3_InformationSystem.Models
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        [Required(ErrorMessage = "Förarens namn är obligatoriskt.")]
        [StringLength(100)]
        public string DriverName { get; set; }
        [Required(ErrorMessage ="Registrering av bil är obligatoriskt.")]
        [StringLength(100)]
        public string CarReg { get; set; }
        [Required(ErrorMessage ="Datum är obligatoriskt.")]
        public DateTime NoteDate { get; set; }
        [Required]
        [StringLength(500)]
        public string NoteDescription { get; set; }
        [Required(ErrorMessage ="Ansvarig medarbetare är obligatoriskt.")]
        public string ResponsibleEmployee { get; set; }
        [Range(0, Double.MaxValue,ErrorMessage ="Beloppet kan inte vara negativt")]
        public decimal BeloppUt { get; set; }
        [Range(0, Double.MaxValue, ErrorMessage = "Beloppet kan inte vara negativt")]
        public decimal BeloppIn { get; set; }


        public decimal TotalBeloppUt { get; set; }
        public decimal TotalBeloppIn { get; set; }

        public List<Event> Events { get; set; } = new List<Event>();
    }
}
