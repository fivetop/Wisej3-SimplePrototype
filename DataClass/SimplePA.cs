using System;
using System.Collections.Generic;

namespace DataClass
{
    [Serializable]
    public class SimplePA
    {
        public int TileWidth { get; set; }  // 안내방송 타일 폭 지정 
        public int MapX { get; set; }       // 도면 폭 
        public int MapY { get; set; }       // 도면 높이 
        public double Zoom { get; set; }    // 도면 줌     
        public int debug { get; set; }      // 디버깅 0이면 로그인 안함 
        public int SpeakerIconSize { get; set; }      // 65 -> 120 
        public string UserName { get; set; } // 사용자 이름 
        public string ServerIP { get; set; }
        public string ServerPort { get; set; }
        public string Reserved1 { get; set; } // 개별방송 , 방송명 저장용 
        public string Reserved2 { get; set; } // 스피커 Off 처리 0 : 처리없음 1: 처리하기 
        public string Reserved3 { get; set; } // 장비위치 셀렉트인덱스 downbutton 
        public string Reserved4 { get; set; } // 로그저장
        public string Reserved5 { get; set; } // 마이크 사용 처리 0 없음 1: 사용 
        public string Reserved6 { get; set; } // 수신기종류 : P형수신기, R형수신기 
        public string Reserved7 { get; set; } // sbs
        public string Reserved8 { get; set; } // ytn
        public string Reserved9 { get; set; } // ebs
        public string Reserved10 { get; set; } // 스피커인지 타이머 
        public string Reserved11 { get; set; } // 모니터링 허용 여부 (PC 스피커 허용 1)
        public string GPIOPort { get; set; } // COM3
        public string Rport { get; set; } // COM4 R형 포트 
        public string Reserved14 { get; set; } // 비상방송 음악
        public string Reserved15 { get; set; } // 사운드 드라이버
        public string Reserved16 { get; set; } // R형 수신기 회사명 
        public int Jigsangbalhwa { get; set; } // 5층 이상건물 // 5층 이상 연면적 3.000m 일때 2, 아니면 1 // 콤보 처리를 위함 
        public int SpeakerTimer { get; set; } // 스피커인지 타이머  기본 10초 
        public double inputvolume { get; set; } // 입력볼륨
        public double outputvolume { get; set; } // 출력볼륨
        public int disp { get; set; } // 1:일반화면 2:앵커화면
        public int Multi_Ch { get; set; } // 다중 방송 채널수 기본 3
        public int SoundDeviceNum { get; set; } // 사운드 드라이버 선택
        public string SoundDeviceName { get; set; } // 사운드 드라이버 이름
        public int Reserved17 { get; set; } // 미리듣기 드라이버 번호 

        public int dsp_vol { get; set; }  // 전체 스피커에 할당된 일반 볼륨 
        public int dsp_vol_em { get; set; } // 전체 스피커에 할당된 비상 방송 볼륨 

        public string sms_server { get; set; } // R형 수신기 회사명 
        public string sms_id { get; set; } // R형 수신기 회사명 
        public string sms_pw { get; set; } // R형 수신기 회사명 
        public string sms_rcvno { get; set; } // R형 수신기 회사명 
        public int Pport { get; set; } // P형 수신기 포트 수 

        public SimplePA()
        {
            SpeakerIconSize = 120;
            debug = 0;
            MapX = 4000;
            MapY = 4000;
            Zoom = 0.2;
            TileWidth = 180;
            Reserved1 = "0";
            Reserved2 = "0";
            Reserved3 = "0";
            Reserved4 = "0";
            Reserved5 = "1";
            Reserved6 = "P형수신기";
            Reserved7 = "http://www.radio-korea.com/embed/sbs-radio-love-fm-428824";
            Reserved8 = "http://www.radio-korea.com/embed/ytn-radio-401695";
            Reserved9 = "http://www.radio-korea.com/embed/ebs-fm-428830";
            Reserved10 = "";
            Reserved11 = "0";
            GPIOPort = "COM3";
            Rport = "COM4";
            Reserved14 = "재난위험경보(3분).mp3";
            Reserved15 = "";
            Reserved16 = "";
            Reserved17 = 0;
            Jigsangbalhwa = 1;
            inputvolume = 0.5f;
            outputvolume = 0.5f;
            disp = 1;
            SpeakerTimer = 10;
            Multi_Ch = 3;
            SoundDeviceNum = 0;

            dsp_vol = 0;        // 초기 값
            dsp_vol_em = 0;     // 초기 값 
            sms_server = "https://sms.nicesms.co.kr/cpsms_utf8/cpsms.html";
            sms_id = "lscnssms";
            sms_pw = "3ef5afb7e743196d9e0726dba16b02d9";
            sms_rcvno = "";
            Pport = 0;
        }
    }

}