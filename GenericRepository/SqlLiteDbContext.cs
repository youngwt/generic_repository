using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class SqlLiteDbContext : DbContext
    {

        public DbSet<Record> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=sqlitedemo.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Record>();
        }
    }
}

