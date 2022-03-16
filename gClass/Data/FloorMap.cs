using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace gClass
{

    [Serializable]
    public class FloorMap
    {
        [Key]
        public int FloorMapId { get; set; }

        public Guid Id { get; set; }
        public Guid logicid { get; set; } // floormap == assetmap link 

        public string buildingname { get; set; } // 빌딩 명 

        public int floororder { get; set; } // 층 순서
        public string floor { get; set; } // 층명
        public string filename { get; set; } // 층도면

        public double left { get; set; } // x 좌표
        public double top { get; set; }  // x 좌표
        public string content { get; set; } // 패스 내용

        public string assetname { get; set; } // 자산명
                                              //        public int istate { get; set; } // 스피커 온라인 상태

        public FloorMap()
        {
            //Id = Guid.NewGuid();
            buildingname = "본관";
            floororder = 1;
            floor = "1층";
            filename = "1.png";
            left = 100;
            top = 100;
            content = "Speaker1";
            assetname = "스피커1";
            //            istate = 0;
        }

        public FloorMap(FloorMap m1)
        {
            //Id = Guid.NewGuid();
            buildingname = m1.buildingname;
            floororder = m1.floororder;
            floor = m1.floor;
            filename = m1.filename;
        }
    }
}
