using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            TimeZoneInfo easternTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            var easternTime = TimeZoneInfo.ConvertTime(now, easternTime);

            Console.WriteLine(now);
            Console.WriteLine(easternTime);
        }
    }
}
