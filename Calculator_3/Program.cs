using System;

namespace Calculator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int result;
            Calculator.Triple(a, out result);
            Console.WriteLine(result);
        }
    }
}
