using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class TestDbContext : DbContext
    {
        public DbSet<Prof1esseur> Professeurs { get; set; }

        public DbSet<lecon> Lecons { get; set; }

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
            modelBuilder.Entity<Prof1esseur>().HasIndex(x=>x.Email).IsUnique();
            base.OnModelCreating(modelBuilder); 
        }

    }
}
