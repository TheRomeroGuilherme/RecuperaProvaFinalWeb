using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using RecuperacaoAPI.Models;

namespace NomeDoProjeto1.Controllers;

  [ApiController]
  [Route("api/auth")]
  public class AuthController : ControllerBase
  {
      private readonly IConfiguration _configuration;

      public AuthController(IConfiguration configuration)
      {
          _configuration = configuration;
      }

      private static List<Usuario> usuarios = new()
      {
          new Usuario { ID_Usuario = 1, Email_Usuario = "admin@empresa.com", Senha_Usuario = "123456", role_User = Role.admin },
          new Usuario { ID_Usuario = 2, Email_Usuario = "user@empresa.com", Senha_Usuario = "123456", role = Role.user },
      };
      };

      [HttpPost("login")]
      public IActionResult Login([FromBody] Usuario credenciais)
      {
          var usuario = usuarios.FirstOrDefault(u =>
              u.Email_Usuario == credenciais.Email_Usuario && u.Senha_Usuario == credenciais.Senha_Usuario);

          if (usuario == null)
              return Unauthorized(new { mensagem = "Credenciais inválidas" });

          var token = GerarToken(usuario);
          return Ok(new { token });
      }

      private string GerarToken(Usuario usuari)
      {
          var claims = new[]
          {
              new Claim(ClaimTypes.Name, usuario.Email_Usuario),
              new Claim(ClaimTypes.Role, usuario.Role.ToString())
          };

          var chave = Encoding.UTF8.GetBytes(IConfiguration["JwtSettings:SecretKey"]!);
          var credenciais = new SigningCredentials(
              new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256);

          var token = new JwtSecurityToken(
              claims: claims,
              expires: DateTime.UtcNow.AddHours(1),
              signingCredentials: credenciais);

          return new JwtSecurityTokenHandler().WriteToken(token);
      }
  }