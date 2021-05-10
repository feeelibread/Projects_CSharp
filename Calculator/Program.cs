using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Calculator.Sum(5, 2);
            Console.WriteLine(n1);
            int n2 = Calculator.Sum(5, 2, 3);
            Console.WriteLine(n2);
            int n3 = Calculator.Sum(5, 2, 3, 4);
            Console.WriteLine(n3);

            int result = Calculator_2.Sum( 10, 20, 30, 40 );
            int result2 = Calculator_2.Sum(1, 2, 3, 4);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
