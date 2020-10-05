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
                var xx = db.Etudiants.Where(x => (x.Name == "Anas" && x.Id == 2) || (x.Name == "Anas" && x.Id == 6))
                     .Where(x=> x.Id > 4).ToList();
                Console.ReadLine();
            }
        }
    }
}
