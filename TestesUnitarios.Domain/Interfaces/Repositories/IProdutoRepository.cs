using TestesUnitarios.Domain.Interfaces.Repositories.Generic;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositorioGenerico<ProdutoModel, int>
    {
        IQueryable<ProdutoModel> BuscarProdutoPorModelo(string modelo);

        IQueryable<ProdutoModel> BuscarProdutoPorNome(string nome);

        IQueryable<ProdutoModel> BuscarPorNomeEModelo(string nome, string modelo);
    }
}