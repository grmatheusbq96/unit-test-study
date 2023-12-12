using MediatR;
using TestesUnitarios.CQS.Commands.Produto;
using TestesUnitarios.CQS.ViewModels;
using TestesUnitarios.Domain.Interfaces.Repositories;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Application.Handlers.Produto
{
    public class CadastrarProdutoHandler : IRequestHandler<CadastrarProdutoCommand, ProdutoViewModel>
    {
        private readonly IProdutoRepository _repo;

        public CadastrarProdutoHandler(IProdutoRepository repo)
        {
            _repo = repo;
        }

        public Task<ProdutoViewModel> Handle(CadastrarProdutoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var produto = _repo.Create(new ProdutoModel(
                    request.Nome,
                    request.Categoria,
                    request.Modelo
                    ));

                _repo.Commit();

                return Task.FromResult(new ProdutoViewModel(produto));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}