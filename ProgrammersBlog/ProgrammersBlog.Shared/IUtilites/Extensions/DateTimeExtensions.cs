using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.IUtilites.Extensions
{
    public static class DateTimeExtensions
    {
        public static string FullDateTimeStringWithUnderscore(this DateTime datetime)
        {
            return $"{datetime.Millisecond}_{datetime.Second}_{datetime.Minute}_{datetime.Hour}_{datetime.Day}_{datetime.Month}_{datetime.Year}";
        }
    }
}
