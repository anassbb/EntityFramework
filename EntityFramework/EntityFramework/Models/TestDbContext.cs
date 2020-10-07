using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class TestDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().Property(x => x.URL).HasField("_url");
            base.OnModelCreating(modelBuilder); 
        }

    }
}
