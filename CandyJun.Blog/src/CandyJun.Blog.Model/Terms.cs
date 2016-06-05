using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class Terms
    {
        public long term_id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public long term_group { get; set; }
    }
    public class wp_terms : Terms
    {

    }
}
