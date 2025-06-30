using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecuperacaoAPI.Models;
using RecuperacaoAPI.Repositories;

namespace RecuperacaoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController : ControllerBase
    {
        private readonly ILancamentoRepositorio _Lancamento
        ;

        public LancamentoController(ILancamentoRepositorio lancamento)
        {
            _Lancamento = lancamento;

        }
        [HttpGet("Listar-Lancamentos")]
        public IActionResult Listar()
        {
            var lancamento = _Lancamento.ListarTodos();
            return Ok(lancamento);
        }
        [HttpGet("buscar/{id}")]
        public IActionResult Buscar(int id)
        {
            var produto = _Lancamento.BuscarUsuarioId(id);
            if (produto == null)
                return NotFound(new { mensagem = "lancamento não encontrado." });

            return Ok(produto);
        }

        [HttpPost("Lancamento")]
        public IActionResult Cadastrar([FromBody] Lancamento lancamento)
        {
            _Lancamento.CadastrarLancamento(lancamento);
            _Lancamento.SalvarLancamento();
            return Created("", lancamento);
        }

        [HttpPut("atualizar/{id}")]
        public IActionResult Atualizar(int id, [FromBody] Lancamento LancamentoAtualizado)
        {
            var lancamento = _Lancamento.BuscarLancamentoId(id);
            if (lancamento == null)
                return NotFound(new { mensagem = "lancamento não encontrado para atualização." });

            lancamento.Tipo_Categoria = LancamentoAtualizado.Tipo_Categoria;
            lancamento.Text_Lancamento = LancamentoAtualizado.Text_Lancamento;

            _Lancamento.AtualizarLancamento(lancamento);
            _Lancamento.SalvarLancamento();
            return Ok(lancamento);
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            var lancamento = _Lancamento.BuscarLancamentoId(id);
            if (lancamento == null)
                return NotFound(new { mensagem = "lancamento não encontrado para exclusão." });

            _Lancamento.DeletarLancamento(lancamento);
            _Lancamento.SalvarLancamento();
            return NoContent();
        }
    }
}