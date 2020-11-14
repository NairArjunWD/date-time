using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            TimeZoneInfo easternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo centralTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            TimeZoneInfo mountainTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Mountain Time");

            var easternTime = TimeZoneInfo.ConvertTime(now, easternTimeZone);
            var centralTime = TimeZoneInfo.ConvertTime(now, centralTimeZone);
            var mountainTime = TimeZoneInfo.ConvertTime(now, mountainTimeZone);
            
            // Output current time, EST, CST, and MNT
            Console.WriteLine("Local: " + now);
            Console.WriteLine("EST: " + easternTime);
            Console.WriteLine("CST: " + centralTime);
            Console.WriteLine("MNT: " + mountainTime);
        }
    }
}
