using MediatR;
using TestesUnitarios.CQS.Commands.Produto;
using TestesUnitarios.CQS.ViewModels;
using TestesUnitarios.CQS.ViewModels.Result;
using TestesUnitarios.Domain.Interfaces.Repositories;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Application.Handlers.Produto
{
    public class CadastrarProdutoHandler : IRequestHandler<CadastrarProdutoCommand, ResultViewModel<ProdutoViewModel>>
    {
        private readonly IProdutoRepository _repo;

        public CadastrarProdutoHandler(IProdutoRepository repo)
        {
            _repo = repo;
        }

        public Task<ResultViewModel<ProdutoViewModel>> Handle(CadastrarProdutoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var produto = new ProdutoModel(
                    request.Nome,
                    request.Categoria,
                    request.Modelo
                    );

                var modeloDeProdutoJaCadastrado = _repo.BuscarPorNomeEModelo(request.Nome, request.Modelo).FirstOrDefault();

                if (modeloDeProdutoJaCadastrado != null
                    && modeloDeProdutoJaCadastrado.Nome == produto.Nome
                    && modeloDeProdutoJaCadastrado.Modelo == produto.Modelo)
                    return Task.FromResult(
                        new ResultViewModel<ProdutoViewModel>()
                        .AddMessage("Produto já cadastrado!"));

                _repo.Create(produto);
                _repo.Commit();

                return Task.FromResult(new ResultViewModel<ProdutoViewModel>(new ProdutoViewModel(produto)));
            }
            catch (Exception)
            {
                return Task.FromResult(new ResultViewModel<ProdutoViewModel>().AddMessage("Ocorreu um erro interno!"));
            }
        }
    }
}