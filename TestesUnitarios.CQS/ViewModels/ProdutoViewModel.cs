using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.CQS.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Modelo { get; set; }

        public ProdutoViewModel(ProdutoModel model)
        {
            Id = model.Id;
            Nome = model.Nome;
            Categoria = model.Categoria;
            Modelo = model.Modelo;
        }
    }
}