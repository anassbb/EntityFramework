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
                var xxx = db.Etudiants.Any(x => x.Name.Contains("A"));
                var xx = db.Etudiants.Any(x => x.Name.EndsWith("k"));

                var xxxx = db.Etudiants.All(x => x.Name.Contains("A"));

                Console.ReadLine();
            }
        }
    }
}
