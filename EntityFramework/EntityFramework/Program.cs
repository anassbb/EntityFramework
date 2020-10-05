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
                var xx = db.Etudiants.SingleOrDefault(x => x.Name == "Anas");
                var xx1 = db.Etudiants.FirstOrDefault(x => x.Name == "Anas");

                Console.WriteLine(xx.Name);

                Console.WriteLine(xx1.Name);

                Console.ReadLine();
            }
        }
    }
}
