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
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entityToDelete = _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            if(entityToDelete != null)
            {
                _context.Remove(entityToDelete);
            }
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Filter()
        {
            return _context.Set<TEntity>();
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
