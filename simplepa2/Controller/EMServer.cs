//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace simplepa2.Controller
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMServer
    {
        public int EMServerId { get; set; }
        public string EMNAME { get; set; }
        public string state { get; set; }
        public string state_old { get; set; }
        public string com_gpio { get; set; }
        public string com_Rtype { get; set; }
        public string net_local { get; set; }
        public string net_dante { get; set; }
        public string dsp_ctrl { get; set; }
        public string dsp_dante { get; set; }
        public Nullable<int> com_gpio_state { get; set; }
        public Nullable<int> com_Rtype_state { get; set; }
        public Nullable<int> sw_all { get; set; }
        public Nullable<int> sw_1 { get; set; }
        public Nullable<int> sw_2 { get; set; }
        public Nullable<int> sw_3 { get; set; }
        public Nullable<int> sw_4 { get; set; }
        public Nullable<int> err { get; set; }
        public Nullable<int> fire { get; set; }
        public Nullable<int> emtest { get; set; }
        public string em_address { get; set; }
        public string em_description { get; set; }
        public string em_images { get; set; }
    }
}
