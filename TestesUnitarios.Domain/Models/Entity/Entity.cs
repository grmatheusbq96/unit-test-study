namespace TestesUnitarios.Domain.Models.Entity
{
    public abstract class Entity<TEntity, Tid>
    {
        public Tid Id { get; set; }
    }
}