using System.ComponentModel.DataAnnotations;

namespace BlogDoEltinho.Dtos.RegisterUserDto
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Nome de usuario necessario")]
        [MinLength(5, ErrorMessage = "É necessario ao mesmo 5 caracteres")]
        [MaxLength(25, ErrorMessage = "No maximo 25 caracteres")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email necessario")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha necessaria")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessario confirmar a senha")]
        [Compare("Password", ErrorMessage = "Senha não igual")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
