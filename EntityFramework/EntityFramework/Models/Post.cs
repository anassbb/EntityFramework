using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Models
{
    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        
        [ForeignKey(nameof(BlogId))]
        public Blog blog { get; set; }
    }
}
