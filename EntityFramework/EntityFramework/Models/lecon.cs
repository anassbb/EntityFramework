using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Models
{
    class lecon
    {
        [Key]
        public int Code { get; set; }

        public int ProfesseurFK { get; set; }

        [ForeignKey(nameof(ProfesseurFK))]
        public Prof1esseur professeur { get; set; }
    }
}
