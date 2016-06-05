using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class TermTaxonomy
    {
        public long term_taxonomy_id { get; set; }
        public long term_id { get; set; }
        public string taxonomy { get; set; }
        public string description { get; set; }
        public long parent { get; set; }
        public long count { get; set; }
    }
    public class wp_term_taxonomy : TermTaxonomy
    {

    }
}
