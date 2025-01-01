using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }

        public string NomeUsuario { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
