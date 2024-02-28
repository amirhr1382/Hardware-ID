using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string ImagePath { get; set; }
        public bool IsEnable { get; set; }

        public virtual ObservableCollectionListSource<HardwareId> HardwareIds { get; } = new();
    }
}
