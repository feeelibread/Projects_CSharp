using System;
using System.Globalization;
namespace DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021, 06, 16, 12, 59, 00);
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.UtcNow;
            
            DateTime d5 = DateTime.Parse("2021-06-17");
            DateTime d6 = DateTime.Parse("2021-06-17 11:02:30");
            
            DateTime d7 = DateTime.Parse("2021/06/17");
            DateTime d8= DateTime.Parse("2021/06/17 11:02:30");

            DateTime d9 = DateTime.ParseExact("2021-06-17", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("17/06/2021 11:13:02", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);     
            Console.WriteLine("\n" + d2);
            Console.WriteLine("\n" + d3);
            Console.WriteLine("\n" + d4);
            Console.WriteLine("\n" + d5);
            Console.WriteLine("\n" + d6);
            Console.WriteLine("\n" + d7);
            Console.WriteLine("\n" + d8);
            Console.WriteLine("\n" + d9);
            Console.WriteLine("\n" + d10);
        }
    }
}
