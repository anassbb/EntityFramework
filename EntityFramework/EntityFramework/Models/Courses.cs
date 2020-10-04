using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class Courses
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<EtudiantCourseRelation> EtudiantRelation { get; set; }
    }
}
