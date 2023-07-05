using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DataClass
{
    public enum eSignalRMsgType
    {
        eUnknown = 0,           // Initial  
        eEM = 1,                // EM Mssage
        eEM_PRESET_SW = 2,      // EM 프리셋 스위치
        eEM_FIRE = 3,           // EM 화재
        ePlay = 4,              // 방송시작     C2S
        ePlayCheck = 5,           // 방송중       S2C  
        ePlaying = 6,           // 방송중       S2C  
        eStop = 7,              // 방송중지     C2S
        ePlayEnd = 8,           // 방송종료     S2C
        eLoginUser = 9,         // 로그인       S2C
        eLogoutUser = 10,        // 로그아웃     S2C
        eVolume = 11,           // 볼륨처리     C2S
        eOutChMove = 12,        // 스피커 이동  C2S
        eScanAll = 13,          // 전체 스캔    C2S
        eScanEM = 14,           // EM 스캔      S2C, C2S
        eFindDSP = 15,          // Find DSP     S2C
        eReturn = 16,
        eInChMove = 17,         // DSP, Sound 이동  C2S
        eFileDown = 18,         // file download   S2C 
        eScheduleDown = 19,     // Schedule change  S2C
        eReserved = 20,         // 예약방송 시작    C2S
    }

    public enum eEventCode
    {
        eAddUser = 1090003,     //    
        eDeleteUser = 1090004,  //
        eUnknown = 0,
    }

    public class PlayItem : INotifyPropertyChanged
    {
        public bool playflag_onair { get; set; } // 방송중인 상태 
        public int idno { get; set; } // 방송 idno
        public int chno { get; set; } // 채널번호
        public string kind { get; set; } // 방송종류
        public string Name { get; set; } // 방송명
        public DateTime Start { get; set; } // 방송시간
        public DateTime End { get; set; } // 방송시간
        public string state { get; set; } // 방송 상태  대기, 방송중, 종료, 취소
        public int playcnt { get; set; } // 방송한 곡 카운트 
        public TimeSpan current { get; set; } // 현재 위치
        public TimeSpan duration { get; set; } // 총 뮤직 플레이 시간 
        public bool p_run { get; set; } // 프로세스 러닝인가? 
        public List<AssetBase> Play { get; set; }
        //public ICollection<Asset> playGroup { get; set; }

        public PlayItem()
        {
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
            Play = new List<AssetBase>();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    public class SignalRMsg
    {

        public Guid Guid { get; set; }
        public string message { get; set; }             // 메시지
        public eSignalRMsgType Msgtype { get; set; }    // 메시지 타입
        public eEventCode event_code { get; set; }      // 이벤트 코드.....
        public int seqno { get; set; }                  // 순번, bstreeid    
        public int chno { get; set; }                   // ch no    
        public int state { get; set; }                  // 상태 코드
        public List<int> assetsRows { get; set; }      // 선택된 스피커 ID
        public List<int> musicsRows { get; set; }      // 선택된 음원 ID
        public string user { get; set;}                 // 유저명 
        public string EMNAME { get; set;}                // EM 명 
        public string user_data1 { get; set; }           // data1  eOutChMove-dspname,  
        public string user_data2 { get; set; }           // data2  
        public string user_data3 { get; set; }           // data3  
        public int user_data4 { get; set; }              // data4 device_chno  
        public string reason { get; set; }               // 실패이유  

        public SignalRMsg()
        {
            //Guid = new Guid();
            message = "";
            Msgtype = eSignalRMsgType.eEM;
            event_code = eEventCode.eAddUser;
            seqno = 0;
            state = 0;
            assetsRows = new List<int>();
            musicsRows = new List<int>();
        }
    }

    // 예약 방송 중복 점검을 위한 
    public class timerevent
    {
        public TimeSpan t1 { get; set; } // 남은시간
        public PlayItem item1 { get; set; } // 남은시간
        public PlayItem item2 { get; set; } // 남은시간
        public timerevent()
        {
            t1 = new TimeSpan(0, 0, 0);
            item1 = new PlayItem();
            item2 = new PlayItem();
        }
    }
}