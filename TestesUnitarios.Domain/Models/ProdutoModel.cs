using TestesUnitarios.Domain.Models.Entity;

namespace TestesUnitarios.Domain.Models
{
    public class ProdutoModel : Entity<ProdutoModel, int>
    {
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public string Modelo { get; private set; }

        public ProdutoModel(string nome, string categoria, string modelo)
        {
            Nome = nome;
            Categoria = categoria;
            Modelo = modelo;
        }
    }
}