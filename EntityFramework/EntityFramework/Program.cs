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
                Etudaint student = db.Etudiants.Where(x => x.Id == 1).SingleOrDefault();

                Console.WriteLine(student.Name);

                Console.ReadLine();
                //var Students = db.Etudiants.ToList();

                //foreach (var item in Students)
                //{
                //    Console.WriteLine(item.Name);
                //}

                //Students = db.Etudiants.ToList();

                //foreach (var item in Students)
                //{
                //    Console.WriteLine(item.Name);
                //}

                //List<string> stds = db.Etudiants.Select(x => x.Name).ToList();

                //foreach (var item in stds)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }
    }
}
