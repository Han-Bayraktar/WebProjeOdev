using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Specialty { get; set; } // Örneğin: "Saç Kesimi", "Sakal Tıraşı"

        public string WorkingHours { get; set; } // Örneğin: "09:00-18:00"

        
    }
}