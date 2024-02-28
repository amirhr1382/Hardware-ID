using Hardware_ID.Models;
using Hardware_ID.Utilities.DateTimeUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.ViewModels
{
    public class HardwareIdItemViewModel
    {
        public int Id { get; set; }
        public string PersonelCode { get; set; }
        public string RegionCode { get; set; }
        public string PartNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsTransferred { get; set; }

        public static HardwareIdItemViewModel ItemView(HardwareId hd)
        {
            return new HardwareIdItemViewModel()
            {
                Id = hd.Id,
                EndDate = DateConvert.GregorianToPersian(hd.EndDate),
                IsTransferred = hd.IsTransferred,
                PartNumber = hd.Part.Number,
                PersonelCode = hd.Member.PersonelCode,
                RegionCode = hd.Region.Code,
                StartDate = DateConvert.GregorianToPersian(hd.StartDate)
            };
        }

        public static List<HardwareIdItemViewModel> ListView(List<HardwareId> hds)
        {
            return hds.Select(s => ItemView(s)).ToList();
        }
    }
}
