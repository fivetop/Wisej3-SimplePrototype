using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace gClass
{
    /*
    [Serializable]
    public class EventList
    {
        public List<EventVm> child { get; set; }
        public EventList()
        {
            child = new List<EventVm>();
        }
    }
    */
    [Serializable]
    public class PlayList
    {
        public List<PlayItem> child { get; set; }
        public PlayList()
        {
            child = new List<PlayItem>(); 
        }
    }


    // 시스템에서 사용할 글로벌 클래스들 
    #region // 사용자 관리, User, UserTree
    public class User
    {
        public List<User> child { get; set; }
    }


    #endregion

    #region // 안내 방송 리스트 관리 , InfoTreeList, InfoTree , 개별 방송 리스트 관리 , BS1TreeList, BS1Tree
    // 안내 방송 리스트 관리 XML 
    public class InfoTreeList
    {
        public List<InfoTree> child { get; set; }
        public InfoTreeList()
        {
            child = new List<InfoTree>();
        }
    }



    #endregion


    #region // 그룹 리스트 관리  , GroupAssetTreeList, GroupAssetTree
    // 그룹 리스트 관리 XML 
    [Serializable]
    public class GroupAssetTreeList
    {
        public List<GroupAssetTree> child { get; set; }
        public GroupAssetTreeList()
        {
            child = new List<GroupAssetTree>();
        }
    }

    // 단일 그룹 / 그룹 명
    [Serializable]
    public class GroupAssetTree
    {
        public string Name { get; set; }
        public List<AssetTree> child { get; set; }
    }
    #endregion

    #region // 건물/층 관리  , SimpleMap, FloorMap 

    [Serializable]
    public class SimpleMap
    {
        public List<FloorMap> Child { get; set; }

        public SimpleMap()
        {
            Child = new List<FloorMap>();
        }
    }

    #endregion

    #region // data , BaseLine, AssetTree, GroupTree, ZoneTree

    [Serializable]
    public class BaseLine : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string path { get; set; }
        public int depth { get; set; }
        public int id { get; set; } //  다중방송 1~8 
        private bool _chk;


        //virtual List<Object> Child { get; set; }

        public BaseLine()
        {
            this.Name = "";
            this.id = 0;
        }

        public bool chk
        {
            get
            {
                return _chk;
            }
            set
            {
                _chk = value;
                OnPropertyChanged("chk");
            }
        }

        public override string ToString()
        {
            return (Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }

    }

    [Serializable]
    public class AssetTree : BaseLine, INotifyPropertyChanged
    {
        public List<GroupTree> child { get; set; }
        public AssetTree()
        {
            depth = 1;
            child = new List<GroupTree>();
        }
    }

    [Serializable]
    public class GroupTree : BaseLine, INotifyPropertyChanged
    {
        public List<ZoneTree> child { get; set; }
        public GroupTree()
        {
            depth = 2;
            child = new List<ZoneTree>();
        }
    }

    [Serializable]
    public class ZoneTree : BaseLine, INotifyPropertyChanged
    {
        public ZoneTree()
        {
            depth = 3;
        }
    }
    #endregion

    #region //  SimplePA , SimpleSpeaker, Music, Asset, Group, Zone, Speaker, Holiday


    [Serializable]
    public class SimpleMusic
    {
        public List<Music> music { get; set; }  // 음원 기초 데이터
        public SimpleMusic()
        {
            music = new List<Music>();
        }
    }

    [Serializable]
    public class SimpleSpeaker
    {
        public List<Asset> asset { get; set; }

        public SimpleSpeaker()
        {
            asset = new List<Asset>();
        }
    }



    [Serializable]
    public class AssetGroupList
    {
        public List<AssetGroup> child { get; set; }
        public AssetGroupList()
        {
            child = new List<AssetGroup>();
        }
    }



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


    #endregion

    #region // 다원 방송 리스트 관리 , SimpleMultiList, SimpleMulti
    // 예약 방송 관리  , SimpleEvent, Event
    // 다중 방송 리스트 관리 XML 
    public class SimpleMultiList
    {
        public List<SimpleMulti> child { get; set; }
        public SimpleMultiList()
        {
            child = new List<SimpleMulti>();
        }
    }

    #endregion

}
