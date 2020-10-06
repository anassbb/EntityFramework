using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (var db = new Models.TestDbContext())
            {
                db.Professeurs.Add(new Prof1esseur { Name = "a1", Email="a3@a3com", GPA = 2.3f });                
                db.Professeurs.Add(new Prof1esseur { Name = "a2", Email = "a4@a4.com", GPA = 2.2f });
                db.SaveChanges();
            }
        }
    }
}
