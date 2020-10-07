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
                var a = db.Professeurs.Include(x=>x.lecons).ToList();

            }
        }
    }
}
