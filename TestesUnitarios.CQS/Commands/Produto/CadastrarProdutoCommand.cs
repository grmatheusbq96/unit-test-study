using MediatR;
using TestesUnitarios.CQS.Dtos.Produto;
using TestesUnitarios.CQS.ViewModels;
using TestesUnitarios.CQS.ViewModels.Result;

namespace TestesUnitarios.CQS.Commands.Produto
{
    public class CadastrarProdutoCommand : IRequest<ResultViewModel<ProdutoViewModel>>
    {
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public string Modelo { get; private set; }

        public CadastrarProdutoCommand(CadastrarProdutoDto dto)
        {
            Nome = dto.Nome;
            Categoria = dto.Categoria;
            Modelo = dto.Modelo;
        }
    }
}