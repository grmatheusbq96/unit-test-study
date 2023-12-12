using TestesUnitarios.Domain.Interfaces.Repositories.Generic;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositorioGenerico<ProdutoModel, int>
    {
    }
}