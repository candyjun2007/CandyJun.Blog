using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    public class Options
    {
        public long option_id { get; set; }
        public string option_name { get; set; }
        public string option_value { get; set; }
        public string autoload { get; set; }
    }
    public class wp_options : Options
    {

    }
}
