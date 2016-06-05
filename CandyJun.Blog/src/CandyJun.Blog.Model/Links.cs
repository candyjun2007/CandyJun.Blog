using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class Links
    {
        public long link_id { get; set; }
        public string link_url { get; set; }
        public string link_name { get; set; }
        public string link_image { get; set; }
        public string link_target { get; set; }
        public string link_description { get; set; }
        public string link_visible { get; set; }
        public long link_owner { get; set; }
        public int link_rating { get; set; }
        public DateTime link_updated { get; set; }
        public string link_rel { get; set; }
        public string link_notes { get; set; }
        public string link_rss { get; set; }
    }
    public class wp_links : Links
    {

    }
}
