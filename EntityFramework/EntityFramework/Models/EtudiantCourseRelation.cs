using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Models
{
    public class EtudiantCourseRelation
    {
        [Key]
        public int NewId { get; set; }
        public int EtudiantIdFK { get; set; }
        public int CoursesIdFk { get; set; }

        public float GPA { get; set; }

        [ForeignKey(nameof(EtudiantIdFK))]
        public Student etudiant { get; set; }

        [ForeignKey(nameof(CoursesIdFk))]
        public Courses course { get; set; }
    }
}
