namespace TestesUnitarios.CQS.Queries
{
    public class BuscarProdutoPorIdQuery
    {
        public int Id { get; private set; }

        public BuscarProdutoPorIdQuery(int id)
        {
            Id = id;
        }
    }
}