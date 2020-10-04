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
                var Students = db.Etudiants.ToList();

                foreach (var item in Students)
                {
                    Console.WriteLine(item.Name);
                }

                Students = db.Etudiants.ToList();

                foreach (var item in Students)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();
            }
        }
    }
}
