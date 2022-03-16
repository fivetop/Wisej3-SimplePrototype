using System;
using System.ComponentModel.DataAnnotations;

namespace gClass
{
    public class UserTree
    {
        [Key]
        public int UserTreeId { get; set; }
        public string user_group { get; set; }
        public string user_name { get; set; }
        public string login_id { get; set; }
        public string login_password { get; set; }
        public string login_password2 { get; set; }
        public string mobile { get; set; }
    }
}