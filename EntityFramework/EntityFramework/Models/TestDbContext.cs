using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class TestDbContext : DbContext
    {
        public DbSet<Human> Persons { get; set; }

        public DbSet<Car> cars { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentAddress> Addresses { get; set; }

        public DbSet<Etudaint> Etudiants { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public DbSet<EtudiantCourseRelation> EtudiantCourseRelations { get; set; }

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
