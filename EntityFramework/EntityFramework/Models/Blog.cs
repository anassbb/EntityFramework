using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private string _url;

        public string URL
        {
            get { return _url.ToUpper(); }
            set 
            {
                if (value.StartsWith("https")) _url = value;
                else throw new Exception("utl dosent start with http");
            }
        }      

        public virtual ICollection<Post> Posts { get; set; }
    }
}
