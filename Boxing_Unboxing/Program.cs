using System;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x;
            Console.WriteLine(obj);

            int y = (int)obj;
            Console.WriteLine(y);
        }
    }
}
