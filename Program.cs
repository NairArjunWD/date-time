using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            TimeZoneInfo pacificTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            var pacificTime = TimeZoneInfo.ConvertTime(now, pacificTimeZone);

            Console.WriteLine(now);
            Console.WriteLine(pacificTime);
        }
    }
}
