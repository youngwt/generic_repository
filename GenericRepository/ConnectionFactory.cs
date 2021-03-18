﻿using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class ConnectionFactory : IDisposable
    {
        private bool disposedValue = false;

        public SqlLiteDbContext CreateContext()
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
