namespace TestesUnitarios.Domain.Models
{
    public class ProdutoModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public string Modelo { get; private set; }

        public ProdutoModel(int id, string nome, string categoria, string modelo)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Modelo = modelo;
        }
    }
}