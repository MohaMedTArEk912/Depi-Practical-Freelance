using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [StringLength(255)] // Adequate length for hashed passwords
        public required string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Role { get; set; } = "User"; // Default to "User"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public required string Email { get; set; }
    }

}