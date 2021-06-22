using System;

namespace DateTimeKind_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2021, 6, 22, 11, 35, 40, DateTimeKind.Local);
            DateTime dateTime1 = new DateTime(2021, 6, 22, 11, 35, 40, DateTimeKind.Utc);
            DateTime dateTime2 = new DateTime(2021, 6, 22, 11, 35, 40, DateTimeKind.Unspecified);

            Console.WriteLine("Date Time Local: " + dateTime);
            Console.WriteLine("Date Time UTC: " + dateTime1);
            Console.WriteLine("Date Time Unspecified: " + dateTime2);

            Console.WriteLine("\ndateTime: " + dateTime);
            Console.WriteLine("dateTime Kind: " + dateTime.Kind);
            Console.WriteLine("dateTme to Local: " + dateTime.ToLocalTime());
            Console.WriteLine("dateTime to UTC: " + dateTime.ToUniversalTime());
            
        }
    }
}
