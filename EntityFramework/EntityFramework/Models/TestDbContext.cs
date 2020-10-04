using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class TestDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
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
