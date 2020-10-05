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
                var xx = db.Etudiants.OrderBy(x=>x.Name).Skip(3).ToList();

                foreach (var item in xx)
                {
                    Console.WriteLine(item.Name);
                }

                var xxx = db.Etudiants.OrderBy(x => x.Name).Take(3).ToList();

                foreach (var item in xxx)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();
            }
        }
    }
}
