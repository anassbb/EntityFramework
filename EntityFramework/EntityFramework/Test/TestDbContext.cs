using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Test
{
    class TestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder ConnectionString = new SqlConnectionStringBuilder()
            {
                DataSource = @".",
                InitialCatalog = "Test",
                IntegratedSecurity = true
            };

            optionsBuilder.UseSqlServer(ConnectionString.ToString());
        }

    }
}
