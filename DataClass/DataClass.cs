﻿using System;
using System.Collections.Generic;
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
        ePlay = 4,              // 방송시작  C2S
        ePlaying = 5,           // 방송중    S2C  
        eStop = 6,              // 방송중지  C2S
        ePlayEnd = 7,           // 방송종료  S2C
    }

    public enum eEventCode
    {
        eLoginUser = 1090001,   // 
        eLogoutUser = 1090002,  //
        eAddUser = 1090003,     //    
        eDeleteUser = 1090004,  //
        eUnknown = 0,
    }

    public class PlayItem
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
        public Guid Guid { get; set; }

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
    }

    public class SignalRMsg
    {
        public string message { get; set; }             // 메시지
        public eSignalRMsgType Msgtype { get; set; }    // 메시지 타입
        public eEventCode event_code { get; set; }      // 이벤트 코드.....
        public int seqno { get; set; }                  // 순번    
        public int state { get; set; }                  // 상태 코드
        public List<long> assetsRows { get; set; }      // 선택된 스피커 ID
        public List<long> musicsRows { get; set; }      // 선택된 음원 ID
        public List<PlayItem> play8sig { get; set; } // 8채널의 현재 상태 
        public string user { get; set; }                // 유저명 

        public Guid Guid { get; set; }

        public SignalRMsg()
        {
            //Guid = new Guid();
            message = "";
            Msgtype = eSignalRMsgType.eEM;
            event_code = eEventCode.eAddUser;
            seqno = 0;
            state = 0;
            assetsRows = new List<long>();
            musicsRows = new List<long>();
            play8sig = new List<PlayItem>();
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