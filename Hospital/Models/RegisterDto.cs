using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "User Name is required.")]
        public String? UserName { get; init; }

        [Required(ErrorMessage = "Email is required.")]
        public String? Email { get; init; }

        [Required(ErrorMessage = "Password is required.")]
        public String? Password { get; init; }
    }
}
