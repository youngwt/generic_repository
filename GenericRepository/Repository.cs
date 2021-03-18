using System;
using System.Linq;

namespace GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {

        private readonly SqlLiteDbContext _context;

        public Repository(SqlLiteDbContext simpleContext)
        {
            _context = simpleContext;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Filter()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> Filter(Func<bool, TEntity> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().First(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
