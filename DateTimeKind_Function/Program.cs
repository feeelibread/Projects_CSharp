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

            DateTime dateTime3 = DateTime.Parse("2021-06-23T09:40:35Z");
            DateTime dateTime4 = DateTime.Parse("2021-06-23 09:40:35");
            Console.WriteLine("\nDate time pattern ISO8601: " + dateTime3);
            Console.WriteLine("Date time withou the pattern: " + dateTime4);

            Console.WriteLine("\nDate Time Local: " + dateTime3.ToLocalTime());
            Console.WriteLine("Date Time kind: " + dateTime3.Kind);
            Console.WriteLine("Date Time UTC: " + dateTime3.ToUniversalTime());
            Console.WriteLine("\nDate Time mask: " + dateTime3.ToString("yyyy-MM-ddTHH:mm:ssZ")); //don't do it
            Console.WriteLine("Date Time mask (the best way): " + dateTime3.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
