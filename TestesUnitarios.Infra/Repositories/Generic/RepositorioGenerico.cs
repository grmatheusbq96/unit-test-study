using Microsoft.EntityFrameworkCore;
using TestesUnitarios.Domain.Interfaces.Repositories.Generic;
using TestesUnitarios.Domain.Models.Entity;

namespace TestesUnitarios.Infra.Repositories.Generic
{
    public class RepositorioGenerico<TEntity, Tid> : IRepositorioGenerico<TEntity, Tid>
        where TEntity : Entity<TEntity, Tid>
        where Tid : IEquatable<Tid>
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositorioGenerico(DbContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public void Commit()
        {
            Db.SaveChanges();
        }

        public TEntity Create(TEntity entity)
        {
            Db.Add(entity);

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            Db.Update(entity);
        }
    }
}