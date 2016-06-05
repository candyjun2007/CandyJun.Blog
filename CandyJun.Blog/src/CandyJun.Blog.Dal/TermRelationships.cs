using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class TermRelationships
    {
        public long object_id { get; set; }
        public long term_taxonomy_id { get; set; }
        public int term_order { get; set; }
    }
    public class wp_term_relationships : TermRelationships
    {

    }
}
