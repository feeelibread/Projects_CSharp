using System;

namespace Propreties_With_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2021, 06, 21, 12, 30, 59, 326);
            DateTime d1 = DateTime.Now;
            Console.WriteLine("1 - Date) " + d.Date);
            Console.WriteLine("2 - Day) " + d.Day);
            Console.WriteLine("3 - Day of Week) " + d.DayOfWeek);
            Console.WriteLine("4 - Day of Year) " + d.DayOfYear);
            Console.WriteLine("5 - Hour) " + d.Hour);
            Console.WriteLine("6 - Kind) " + d.Kind);
            Console.WriteLine("7 - Millisecond) " + d.Millisecond);
            Console.WriteLine("8 - Minute) " + d.Minute);
            Console.WriteLine("9 - Month) " + d.Month);
            Console.WriteLine("10 - Second) " + d.Second);
            Console.WriteLine("11 - Ticks) " + d.Ticks);
            Console.WriteLine("12 - Time of Day) " + d.TimeOfDay);
            Console.WriteLine("13 - Year) " + d.Year);

            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("dd/MM/yyyy HH:mm:ss.fff");

            Console.WriteLine("\nLongDate: " + s1);
            Console.WriteLine("LongTime: " + s2);
            Console.WriteLine("ShortDate: " + s3);
            Console.WriteLine("ShortTime: " + s4);
            Console.WriteLine("ToString (current): " + s5);
            Console.WriteLine("ToString (changed): " + s6);
            Console.WriteLine("ToString (changed, with milliseconds): " + s7);

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(20);
            DateTime d4 = d.AddDays(7);
            Console.WriteLine("\nCurrent date:" + d);
            Console.WriteLine("AddHours: " + d2);
            Console.WriteLine("AddMinutes: " + d3);
            Console.WriteLine("AddDays: " + d4);

            DateTime d5 = new DateTime(2021, 6, 21);
            DateTime d6 = new DateTime(2021, 6, 28);

            TimeSpan t = d6.Subtract(d5);
            Console.WriteLine("TimeSpan - difference between dates with subtract operation: " + t);

        }
    }
}
