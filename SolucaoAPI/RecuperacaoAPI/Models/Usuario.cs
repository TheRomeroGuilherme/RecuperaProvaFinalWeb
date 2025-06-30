using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RecuperacaoAPI.Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string? Nome_Usuario { get; set; }
        public string? Email_Usuario{ get; set; }
        public string? Senha_Usuario { get; set; }
        public Role Role { get; set; } = Role.user;
    }
}