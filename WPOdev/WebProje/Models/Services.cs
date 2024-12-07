using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Duration { get; set; } // Süre (dakika)
    }
}