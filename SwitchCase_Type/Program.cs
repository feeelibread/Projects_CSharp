using System;

namespace SwitchCase_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Convert.ToInt32(Console.ReadLine());
            int a = 10;
            int b = 5;
            switch (x)
            {
                case 1:
                    a = Add(a, b);
                    break;
                case 2:
                    a = Sub(a, b);
                    break;
            }

            Console.WriteLine(a);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

    }
}
