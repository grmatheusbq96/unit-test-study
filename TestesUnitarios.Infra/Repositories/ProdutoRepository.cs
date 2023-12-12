using TestesUnitarios.Domain.Interfaces.Repositories;
using TestesUnitarios.Domain.Models;
using TestesUnitarios.Infra.Context;
using TestesUnitarios.Infra.Repositories.Generic;

namespace TestesUnitarios.Infra.Repositories
{
    public class ProdutoRepository : RepositorioGenerico<ProdutoModel, int>, IProdutoRepository
    {
        public ProdutoRepository(UnitTestContext db) : base(db)
        {
        }
    }
}