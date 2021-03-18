using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class SqlLiteDbContext : DbContext
    {

        public SqlLiteDbContext(DbContextOptions options)
            : base(options) {}

        public virtual DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Record>();
        }
    }
}

