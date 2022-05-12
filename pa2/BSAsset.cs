using DataClass;
using System;
using System.Collections.Generic;
using static Wisej.CodeProject.DataSet1;

namespace pa
{

    [Serializable]
    public class BSAsset
    {
        public int chno { get; set; }       // 채널번호
        public int onoff { get; set; }          // 스피커 
        public BS_DSP_STATE bS_DSP_STATE { get; set; }  // id 1=preset switch 1-4, 2=preset switch all

        public List<AssetBase> child { get; set; } // 스피커 리스트
        public List<DeviceRow> device { get; set; } // 스피커 리스트
        public BSAsset()
        {
            child = new List<AssetBase>();
            device = new List<DeviceRow>();
            bS_DSP_STATE = BS_DSP_STATE.NONE;
        }
    }
}
