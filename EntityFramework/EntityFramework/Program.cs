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
               await db.Database.EnsureCreatedAsync();

                var listOfBlog = await db.Blogs.Include(x=>x.Posts).ToListAsync();
                                
               Console.WriteLine("done");

            }
        }
    }
}
