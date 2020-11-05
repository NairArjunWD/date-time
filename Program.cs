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

            var easternTime = TimeZoneInfo.ConvertTime(now, easternTimeZone);
            var centralTime = TimeZoneInfo.ConvertTime(now, centralTimeZone);
            

            Console.WriteLine(now);
            Console.WriteLine(easternTime);
            Console.WriteLine(centralTime);
        }
    }
}
