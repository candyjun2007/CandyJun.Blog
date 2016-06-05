using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyJun.Blog.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users: ModelBase
    {
        public string user_login { get; set; }
        public string user_pass { get; set; }
        public string user_nicename { get; set; }
        public string user_email { get; set; }
        public string user_url { get; set; }
        public string user_registered { get; set; }
        public string user_activation_key { get; set; }
        public string user_status { get; set; }
        public string display_name { get; set; }
    }
    public class wp_users : Users
    {

    }
}
