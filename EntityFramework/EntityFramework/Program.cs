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
                foreach(Prof1esseur p in db.Professeurs.ToList())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
