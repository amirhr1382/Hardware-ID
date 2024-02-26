using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.Models
{
    public class HardwareId
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTransferred { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; } = null!;

        public int RegionId { get; set; }
        public virtual Region Region { get; set; } = null!;

        public int PartId { get; set; }
        public virtual Part Part { get; set; } = null!;
    }
}
