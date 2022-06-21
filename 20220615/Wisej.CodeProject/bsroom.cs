using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.CodeProject
{
    public class bsroom
    {
        string[] img = { @"Images\headphones.jpg", @"Images\laptop.jpg", @"Images\monitor.png" };
        string[] astate_str = { "입장하기", "방송준비", "방송중" };

        public string bsroomid { get; set; }
        public bool state { get; set; }

        long _state_int;
        internal DataSet1.BSroomRow bsroomrow;

        public long state_int 
        {
            get 
            { 
                return _state_int;
            }
            set 
            {
                _state_int = value;
                state = state_int == 0 ? true : false;
                state_str = astate_str[state_int];
                Image = img[state_int];
                bsroomrow.state = state_int;
            }
        }
        public string state_str { get; set; }

        string _username;
        public string username 
        {
            get 
            {
                return _username;
            }
            set 
            {
                _username = value;
                bsroomrow.user_name = _username;
            }
        }
        
        public string Image { get; set; }
    }
}