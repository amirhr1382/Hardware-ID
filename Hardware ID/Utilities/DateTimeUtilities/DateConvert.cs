using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.Utilities.DateTimeUtilities
{
    public class DateConvert
    {
        public static DateTime PersianToGregorian(string persianDate, string seprator = "/")
        {
            int[] persinaDateSections = persianDate.Split(seprator).Select(s => Convert.ToInt32(s)).ToArray();
            PersianCalendar pc = new PersianCalendar();
            return new DateTime(persinaDateSections[0], persinaDateSections[1], persinaDateSections[2], pc);
        }

        public static string GregorianToPersian(DateTime gregorianDate, string seprator = "/")
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(gregorianDate)}/{pc.GetMonth(gregorianDate)}/{pc.GetDayOfMonth(gregorianDate)}";
        }
    }
}
