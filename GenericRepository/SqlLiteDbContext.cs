using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class SqlLiteDbContext : DbContext
    {

        public DbSet<Record> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=sqlitedemo.db");
    }
}

