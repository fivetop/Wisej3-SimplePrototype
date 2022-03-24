using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    [Serializable]
    public class PlayItem
    {
        [Key]
        public int PlayItemId { get; set; }
        public bool playflag_onair { get; set; } // 방송중인 상태 
        public Guid Id { get; set; } // id
        public Guid bsId { get; set; } // 방송 id
        public int idno { get; set; } // 방송 idno
        public int chno { get; set; } // 채널번호
        public string kind { get; set; }
        public string Name { get; set; } // 방송명
        public DateTime Start { get; set; } // 방송시간
        public DateTime End { get; set; } // 방송시간
        public string state { get; set; } // 방송 상태  대기, 방송중, 종료, 취소
        public int playcnt { get; set; } // 방송한 곡 카운트 
        public TimeSpan current { get; set; } // 현재 위치
        public TimeSpan duration { get; set; } // 총 뮤직 플레이 시간 
        public bool p_run { get; set; } // 프로세스 러닝인가? 

        public List<AssetBase> playGroup { get; set; }
        //public ICollection<Asset> playGroup { get; set; }


        public PlayItem()
        {
            //Id = Guid.NewGuid();
            //bsId = Guid.NewGuid();
            playflag_onair = false;
            chno = 0;
            idno = 0;
            Start = DateTime.Now;
            End = DateTime.Now;
            kind = "";
            Name = "방송이름";
            state = "대기";
            playcnt = 0;
            current = new TimeSpan();
            p_run = false;
            playGroup = new List<AssetBase>();
        }
    }
}
