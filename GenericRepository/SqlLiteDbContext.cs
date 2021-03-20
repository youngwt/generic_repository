using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class SqlLiteDbContext : DbContext
    {

        public SqlLiteDbContext(DbContextOptions options)
            : base(options) {}

        public virtual DbSet<Release> Releases { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Release>();

            builder.Entity<Artist>();

            builder.Entity<Song>();

        }
    }
}

