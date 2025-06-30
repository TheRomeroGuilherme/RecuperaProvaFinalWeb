using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecuperacaoAPI.Models;

namespace RecuperacaoAPI.Repositories
{
    public interface ILancamentoRepositorio
    {
        List<Lancamento> ListarTodos();
        Usuario? BuscarUsuarioId(int ID_Usuario);
        Lancamento? BuscarLancamentoId(int ID_Categoria);
        void Login(Usuario usuario);
        void CadastrarLancamento(Lancamento lancamento);
        void AtualizarLancamento(Lancamento lancamento);
        void DeletarLancamento(Lancamento lancamento);
        void SalvarLancamento();

    }
}