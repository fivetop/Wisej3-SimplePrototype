using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{
    [Serializable]
    public class Music
    {
        [Key]
        public int MusicId { get; set; }
        public Guid id { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
        public int FilePlay { get; set; }
        public string deletable { get; set; }
        public string duration { get; set; }

        public Music()
        {
            id = Guid.NewGuid();
            duration = "";
        }
    }
}
