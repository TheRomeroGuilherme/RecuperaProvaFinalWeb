using System.ComponentModel.DataAnnotations;

namespace RecuperacaoAPI.Models
{
    public class Usuario
    {
        [Key]
        public int ID_Usuario { get; set; }

        [Required]
        public string? Nome_Usuario { get; set; }

        [Required]
        public string? Email_Usuario { get; set; }

        [Required]
        public string? Senha_Usuario { get; set; }
        public Role role_User { get; set; } = Role.user;
        public Role role { get; set; } = Role.admin;
    }
}