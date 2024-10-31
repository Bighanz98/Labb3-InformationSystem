using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Labb3_InformationSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Namn på medarbetare är obligatoriskt.")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email är obligatoriskt.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Roll är obligatoriskt.")]
        public string Role { get; set; }

        // Koppla varje Employee till en IdentityUser
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
