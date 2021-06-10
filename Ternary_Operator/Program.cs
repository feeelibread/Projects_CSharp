using System;
using System.Globalization;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double descount;

            //"if" operator
            if (price < 20.0)
            {
                descount = price * 0.1;
            }
            else
            {
                descount = price * 0.05;
            }

            Console.WriteLine(descount);

            //the ternary operator, in a single line we could do the same as if and else
            double ternary_descount = (price < 20.0) ? price * 0.1 : price * 0.05;
            Console.WriteLine(ternary_descount);

        }
    }
}
