using System;

namespace Properties_With_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan tt = new TimeSpan(1, 30, 10);
            TimeSpan ttt = new TimeSpan(0, 10, 30);

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("\n" + t);
            Console.WriteLine("\nDays: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("\nTotal Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            Console.WriteLine("Total Seconds: " + t.TotalSeconds);
            Console.WriteLine("Total Milliseconods: " + t.TotalMilliseconds);

            TimeSpan sum = tt.Add(ttt);
            TimeSpan sub = tt.Subtract(ttt);
            TimeSpan mult = ttt.Multiply(2.0);
            TimeSpan div = ttt.Divide(2.0);
            Console.WriteLine("\nSum: " + sum);
            Console.WriteLine("Subtract: " + sub);
            Console.WriteLine("Multiply: " + mult);
            Console.WriteLine("Divide: " + div);
        }
    }
}
