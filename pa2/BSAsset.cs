using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace pa
{

    [Serializable]
    public class BSAsset
    {
        public int chno { get; set; }       // 채널번호
        public int onoff { get; set; }          // 스피커 
        public BS_DSP_STATE id { get; set; }  // id 1=preset switch 1-4, 2=preset switch all

        public List<AssetBase> child { get; set; } // 스피커 리스트
        public List<Device> device { get; set; } // 스피커 리스트
        public BSAsset()
        {
            child = new List<AssetBase>();
            device = new List<Device>();
            id = BS_DSP_STATE.NONE;
        }
    }
}
