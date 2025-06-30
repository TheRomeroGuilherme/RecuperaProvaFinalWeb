using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecuperacaoAPI.Data;
using RecuperacaoAPI.Models;

namespace RecuperacaoAPI.Controllers
{
    [Route("[controller]")]
    [Route("api/")]
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }
        // POST: api/produto/cadastrar
        [HttpPost("Login")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }

        




        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}