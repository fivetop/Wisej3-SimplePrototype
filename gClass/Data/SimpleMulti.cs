using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace gClass
{
    // 다중 방송 / 방송 명
    [Serializable]
    public class SimpleMulti
    {
        [Key]
        public int SimpleMultiId { get; set; }

        public Guid Id { get; set; }
        public int idno { get; set; }
        public int chno { get; set; }
        public string Subject { get; set; } // 제목
        public string Name { get; set; } // 방송명
        public List<Music> music { get; set; } // 선택된 음약 
        public AssetGroup gstree { get; set; } // 그룹 

        public DateTime stm { get; set; } // 시작일시
        public DateTime etm { get; set; } // 종료일시 
        public string duration { get; set; } // 총 뮤직 플레이 시간 
        public bool week { get; set; } // 주간반복 true 반복 
        public bool day1 { get; set; }
        public bool day2 { get; set; }
        public bool day3 { get; set; }
        public bool day4 { get; set; }
        public bool day5 { get; set; }
        public bool day6 { get; set; }
        public bool day7 { get; set; }

        public TimeSpan tss { get; set; } // 시작시간
        public TimeSpan tse { get; set; } // 종료시간 

        public string Color16 { get; set; }

        public bool overlap { get; set; } //정규방송과 겹칠시 우선 처리 
        public DayOfWeek weekday { get; set; } // 요일

        public SimpleMulti()
        {
            SimpleMultiId = 0;
            Id = Guid.NewGuid();
            chno = 0;
            idno = 0;
            music = new List<Music>();
            gstree = new AssetGroup();
            stm = DateTime.Now;
            etm = DateTime.Now;
            tss = new TimeSpan();
            tse = new TimeSpan();
            week = false;

            day1 = false;
            day2 = false;
            day3 = false;
            day4 = false;
            day5 = false;
            day6 = false;
            day7 = false;

            var t1 = new SolidColorBrush(Colors.LightGreen);
            Color16 = t1.ToString();

            overlap = true;
            weekday = DayOfWeek.Monday;
        }

        public void UpdateData(SimpleMulti e)
        {
            this.stm = e.stm;
            this.etm = e.etm;
            this.tss = e.tss;
            this.tse = e.tse;

            this.music = e.music;
            this.gstree.child = e.gstree.child;

            this.day1 = e.day1;
            this.day2 = e.day2;
            this.day3 = e.day3;
            this.day4 = e.day4;
            this.day5 = e.day5;
            this.day6 = e.day6;
            this.day7 = e.day7;

            this.Color16 = e.Color16;

            this.overlap = e.overlap;
            this.weekday = e.weekday;

            this.chno = e.chno;
            this.duration = e.duration;

            /*
            idno = 0;
            week = false;
            */
        }
    }
}
