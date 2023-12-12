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

        public IQueryable<ProdutoModel> BuscarPorNomeEModelo(string nome, string modelo)
        {
            return DbSet.Where(p => p.Modelo.Equals(modelo) && p.Nome.Equals(nome));
        }

        public IQueryable<ProdutoModel> BuscarProdutoPorModelo(string modelo)
        {
            return DbSet.Where(p => p.Modelo.Equals(modelo));
        }

        public IQueryable<ProdutoModel> BuscarProdutoPorNome(string nome)
        {
            return DbSet.Where(p => p.Nome.Equals(nome));
        }
    }
}