using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
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
                var xx = db.Professeurs.ToList();

                Prof1esseur Anas = db.Professeurs.Find(1);

                db.Entry(Anas).Collection(x => x.lecons).Load();

            }
        }
    }
}
