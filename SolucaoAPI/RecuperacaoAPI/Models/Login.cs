using System.ComponentModel.DataAnnotations;

namespace RecuperacaoAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        public string? Nome_Usuario { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string? Senha_Usuario { get; set; }
    }
}