using System;
using System.Linq;

namespace GenericRepository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);

        TEntity GetById(Guid id);
        IQueryable<TEntity> Filter();

        void SaveChanges();

    }
}
