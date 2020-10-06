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
            List<Prof1esseur> professeurs = new List<Prof1esseur>()
            {
                new Prof1esseur {Name="Ahmed",Email="Ahmed@gmail.com",GPA=1.1f},
                new Prof1esseur {Name="Wael",Email="Wael@gmail.com",GPA=2.1f}
            };

            using (var db = new Models.TestDbContext())
            {
                db.Professeurs.AddRange(professeurs);
                db.SaveChanges();
            }
        }
    }
}
