using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models {
    public class Blogs {
        public int Id { get; set; }
        public string Url { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}
