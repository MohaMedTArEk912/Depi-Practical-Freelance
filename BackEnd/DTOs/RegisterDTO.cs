using System.ComponentModel.DataAnnotations;

public class RegisterDTO
{
    [Required]
    [StringLength(50)]
    public required string Username { get; set; }

    [Required]
    [StringLength(255)]
    public required string Password { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public required string Email { get; set; }

    public string Role { get; set; } = "User";
}
