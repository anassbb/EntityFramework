﻿using EntityFramework.Models;
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
                db.Database.EnsureCreated();
            }
        }
    }
}
