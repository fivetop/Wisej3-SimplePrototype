using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
    // 단일 개별 방송 / 방송 명
    // 
    [Serializable]
    public class InfoTree
    {
        [Key]
        public int InfoTreeId {  get; set; }
        public Guid Id { get; set; }
        public string Subject { get; set; } // 제목
        public string Name { get; set; } // 방송명
        public AssetGroup gstree { get; set; } //그룹
        public List<Music> music { get; set; } // 선택된 음약

        public InfoTree()
        {
            Id = Guid.NewGuid();
            gstree = new AssetGroup();
            music = new List<Music>();
        }
    }
}
