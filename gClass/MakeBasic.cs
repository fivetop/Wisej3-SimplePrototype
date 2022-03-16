using gClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace gClass
{
    public class MakeBasic
    {
        //스피커 폴더에서 가져와 디비 생성 
        public void ReadAssetList(SimpleSpeaker _SpeakerList)
        {
            // 업데이트된 폴더를 무조건 읽고 
            // 기존 디비와 비교후 업데이트 내용을 적용 처리  

            List<Asset> al = new List<Asset>();
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리 
            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Speaker");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.");

                foreach (var fileInfo in files)
                {
                    var aa = fileInfo.Name.Split(' ');

                    var m3 = al.Find(p => p.GroupName == aa[1] && p.ZoneName == aa[2] && p.SpeakerName == aa[3]);
                    if (m3 == null)
                    {
                        Asset m2 = new Asset();
                        m2.seq = int.Parse(aa[0]);
                        m2.GroupName = aa[1];
                        m2.ZoneName = aa[2];
                        m2.SpeakerName = aa[3];
                        m2.path = aa[1] + " " + aa[2] + " " + aa[3];
                        //m2.path = fileInfo.Name;
                        if (aa.Count() > 4)
                            m2.DeviceName = aa[4];
                        al.Add(m2);
                    }
                }
            }

            // 업데이트 내용 처리하기 
            // 아이피와 층 할당 정보, 온라인 상태 저장 
            // 새로만들기 포함 처리 - 디비 변경시 변경 처리 요망 
            foreach (Asset t1 in _SpeakerList.asset)
            {
                var t2 = al.Find(p => p.path == t1.path);
                if (t2 != null)
                {
                    t2.floor = t1.floor;
                    t2.ip = t1.ip;
                    t2.state = t1.state;
                }
            }
            // 원본 데이터를 항상 새로 읽어오기 2020.06.24
            _SpeakerList.asset.Clear();
            // 최종 업데이트 저장 
            _SpeakerList.asset = al;
        }

        // 음원 폴더에서 가져와 디비 생성 
        // 듀레이션은 시간이 걸리므로 타이머 쓰레드 처리 
        public void ReadMusic(SimpleMusic _MusicList)
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리
            //_BaseData.music.Clear();
            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Music");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.mp3");

                foreach (var fileInfo in files)
                {
                    var mu1 = TagLib.File.Create(fileInfo.FullName);
                    var m3 = _MusicList.music.Find(p => p.FileName == fileInfo.Name);
                    if (m3 != null)
                    {
                    }
                    else
                    {
                        string str1 = "00:00:00";
                        var r1 = mu1.Properties.Duration;
                        Music m2 = new Music();
                        m2.FileName = fileInfo.Name;
                        m2.FileContent = "";
                        m2.FilePlay = 1;
                        m2.deletable = "N";
                        Thread.Sleep(50);
                        str1 = r1.ToString(@"hh\:mm\:ss");
                        if (str1 == "00:00:00")
                            str1 = "00:00:01";
                        m2.duration = str1;
                        _MusicList.music.Add(m2);
                    }
                }
            }
        }


        //이미지 폴더에서 가져와 층 디비 생성 
        public void ReadFloor(SimpleMap _FloorBase)
        {
            // 폴더에서 자동으로 파일 확인후 디비에 등록 처리 
            //_FloorBase.Child.Clear();
            var directoryInfo = new DirectoryInfo(gl.appPathServer + "Image");
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles("*.png").Concat(directoryInfo.GetFiles("*.svg"));

                foreach (var fileInfo in files)
                {
                    var aa = fileInfo.Name.Split(' ');
                    if (aa.Count() < 2)
                        continue;
                    var aa2 = aa[2].Split('.');
                    int aai = int.Parse(aa[0]);
                    var m3 = _FloorBase.Child.Find(p => p.buildingname == aa[1] && p.floor == aa2[0]);

                    if (m3 == null)
                    {
                        FloorMap m2 = new FloorMap();
                        m2.buildingname = aa[1];
                        m2.floor = aa2[0];
                        m2.floororder = aai;
                        m2.filename = fileInfo.Name;
                        _FloorBase.Child.Add(m2);
                    }
                    else
                    {
                        m3.floororder = aai;
                        m3.filename = fileInfo.Name;
                    }
                }
            }
        }

    }
}
