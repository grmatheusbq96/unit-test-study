using MediatR;
using TestesUnitarios.CQS.Commands.Produto;
using TestesUnitarios.CQS.ViewModels;

namespace TestesUnitarios.Application.Handlers.Produto
{
    public class CadastrarProdutoHandler : IRequestHandler<CadastrarProdutoCommand, ProdutoViewModel>
    {
        public Task<ProdutoViewModel> Handle(CadastrarProdutoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}