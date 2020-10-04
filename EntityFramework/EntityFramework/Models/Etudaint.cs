
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class Etudaint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EtudiantCourseRelation> CourseRelation { get; set; }
    }
}
