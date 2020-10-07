using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var db = new Models.TestDbContext())
            {
                db.Database.EnsureCreated();

                db.Blogs.Add(new Blog
                {
                    Name = ".net",
                    Posts = new List<Post>
                      {
                          new Post{ Title="c#", Content="c# 7.0 has a new feature, which is async Main method "}
                      },
                    URL = "https://www.youtube.com/"
                });
                db.SaveChanges();
                Console.WriteLine("done");

            }
        }
    }
}
