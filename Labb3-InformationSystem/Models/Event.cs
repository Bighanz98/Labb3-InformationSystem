using System.ComponentModel.DataAnnotations;

namespace Labb3_InformationSystem.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required(ErrorMessage = "Event date is required.")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Event description is required.")]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public int DriverID { get; set; }

        public Driver Driver { get; set; }
    }
}
