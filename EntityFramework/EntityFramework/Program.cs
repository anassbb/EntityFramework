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
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Professeurs.Add(new Prof1esseur { Name = "helloYoyo", Email = "helloyoyo@gmail.com", GPA = 2.1f });
                        db.SaveChanges();
                        throw new Exception("yes");
                        Prof1esseur p = db.Professeurs.SingleOrDefault(x => x.PK == 1);
                        db.Professeurs.Remove(p);
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                    }
                    finally
                    {
                        trans.Dispose();
                    }
                }
            }
        }
    }
}
