using Hardware_ID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.ViewModels
{
    public class SearchViewModel
    {
        public string MemberName { get; set; }
        public string MemberPersonelCode { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string RegionName { get; set; }

        public static SearchViewModel ItemView(HardwareId hd)
        {
            return new SearchViewModel()
            {
                MemberName = $"{hd.Member.FirstName} {hd.Member.LastName}",
                MemberPersonelCode = hd.Member.PersonelCode,
                PartName = hd.Part.Name,
                PartNumber = hd.Part.Number,
                RegionName = hd.Region.Name,
            };
        }

        public static List<SearchViewModel> ListView(List<HardwareId> hds)
        {
            return hds.Select(h => ItemView(h)).ToList();
        }
    }
}
