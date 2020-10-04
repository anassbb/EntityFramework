using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class Car
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public Human Person { get; set; }
    }
}
