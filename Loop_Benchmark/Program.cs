using System;

namespace Loop_Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin;
            DateTime end;

            int[] amount = new int[100000000];

            begin = DateTime.Now;
            foreach (var item in amount)
            {
                
            }
            end = DateTime.Now;
            Console.WriteLine($"Begin - {begin}");
            Console.WriteLine($"End - {end}");
            Console.WriteLine($"Difference - {end.Subtract(begin).Milliseconds}");
            Console.WriteLine();

            begin = DateTime.Now;
            for (int i = 0; i < amount.Length; i++)
            {

            }
            end = DateTime.Now;
            Console.WriteLine($"Begin - {begin}");
            Console.WriteLine($"End - {end}");
            Console.WriteLine($"Difference - {end.Subtract(begin).Milliseconds}");
        }
    }
}
