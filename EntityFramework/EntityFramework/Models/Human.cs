using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class Human
    {
        public int HumanId { get; set; }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
