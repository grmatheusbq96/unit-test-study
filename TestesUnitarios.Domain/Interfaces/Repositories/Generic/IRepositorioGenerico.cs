namespace TestesUnitarios.Domain.Interfaces.Repositories.Generic
{
    public interface IRepositorioGenerico<TEntity, Tid>
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        void Commit();
    }
}