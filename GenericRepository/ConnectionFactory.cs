using System;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class ConnectionFactory : IDisposable
    {
        private bool disposedValue = false;

        public SqlLiteDbContext CreateContext(bool preloadData = false)
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            
            var option = new DbContextOptionsBuilder<SqlLiteDbContext>().UseSqlite(connection).Options;

            var context = new SqlLiteDbContext(option);

            if(context != null)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            // uncomment below if you want to see the generated schema
            //var sql = context.Database.GenerateCreateScript();

            // for testing purposes
            if(preloadData)
            {
                var testData = File.ReadAllText("testData.sql");
                context.Database.ExecuteSqlRaw(testData);
            }


            return context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
