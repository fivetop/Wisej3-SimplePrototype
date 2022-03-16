using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
    [Serializable]
    public class AssetGroup
    {
        [Key]
        public int AssetGroupId { get; set; }
        public string Name { get; set; }
        //public List<Asset> child { get; set; }
        public ICollection<AssetBase> child { get; set; }

        public AssetGroup()
        {
            child = new List<AssetBase>();
        }

        public void add(List<Asset> ab1)
        {
            foreach (var v1 in ab1)
            {
                AssetBase v2 = new AssetBase();
                v2.chk = v1.chk;
                v2.DeviceName = v1.DeviceName;
                v2.floor = v1.floor;
                v2.GroupName = v1.GroupName;
                v2.ip = v1.ip;
                v2.path = v1.path;
                v2.seq = v1.seq;
                v2.SpeakerName = v1.SpeakerName;
                v2.state = v1.state;
                v2.state_old = v1.state;
                v2.ZoneName = v1.ZoneName;
                v2.AssetGroupId = AssetGroupId;
                v2.assetGroup = this;
                child.Add(v2);
            }
        }
    }
}
