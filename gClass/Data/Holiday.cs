using System;
using System.ComponentModel.DataAnnotations;

namespace gClass
{
    [Serializable]
    public class Holiday
    {
        [Key]
        public int HolidayId { get; set; }
        public Guid id { get; set; }
        public DateTime hDate { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }

        public Holiday()
        {
            id = Guid.NewGuid();
        }
    }
}