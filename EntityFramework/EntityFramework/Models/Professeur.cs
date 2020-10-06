using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Models
{
    [Table("Professeur")]
    class Prof1esseur
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }
        [Required(ErrorMessage = "it is not allowd t insert null as a value"),
         MinLength(2, ErrorMessage = "should be more than one tow carracters"),
         MaxLength(25, ErrorMessage = "should be less then 25 caracters"),
         Column("Full Name", Order = 2, TypeName = "char(25)")]
        public string Name { get; set; }

        [Range(0.0d, 4.0d, ErrorMessage = "should be between 0.0 and 4.0")]
        public float GPA { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "E-Mail Addresses")]
        public string Email { get; set; }

        public IEnumerable<lecon> lecons { get; set; }
    }
}
