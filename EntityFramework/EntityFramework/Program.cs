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
                Prof1esseur prof = db.Professeurs.SingleOrDefault(x => x.PK == 3);              

                db.Professeurs.Remove(prof);
                db.SaveChanges();
            }
        }
    }
}
