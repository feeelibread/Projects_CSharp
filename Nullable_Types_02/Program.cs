using System;

namespace Nullable_Types_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            double a = y ?? 5.0;
            double b = x ?? 5.0;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
