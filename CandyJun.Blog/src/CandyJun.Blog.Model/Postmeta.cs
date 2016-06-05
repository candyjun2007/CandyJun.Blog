using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class Postmeta
    {
        public long meta_id { get; set; }
        public long post_id { get; set; }
        public string meta_key { get; set; }
        public string meta_value { get; set; }
    }
    public class wp_postmeta : Postmeta
    {

    }
}
