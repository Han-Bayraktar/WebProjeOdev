using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

       
        public string Role { get; set; } 
        
    }
}