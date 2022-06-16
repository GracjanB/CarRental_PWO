using System.ComponentModel.DataAnnotations;

namespace CarRental.API.Dtos
{
    public class RegisterDto
    {
        [Required]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Username characters must be between 4 and 32")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,16}$", ErrorMessage = "Password must be complex (4 to 16 characters)")]
        public string Password { get; set; }
    }
}
