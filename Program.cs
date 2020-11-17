using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not include PST since that is the now 
            var now = DateTime.Now;

            // Display all American Time Zones in Contintental US
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

            var date = "11/17/2020 10:00:00 PM";

            var parsedDate = DateTime ParseExact(date, 
                "M/d/yyyy h:mm:ss tt",
                CultureInfo.InvariantCulture);
        }
    }
}
