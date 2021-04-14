using System;

namespace For_Structure_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int _in = 0, _out = 0;

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }
            Console.WriteLine($"{_in} in");
            Console.WriteLine($"{_out} out");
        }
    }
}
