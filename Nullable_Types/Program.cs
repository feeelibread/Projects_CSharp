using System;

namespace Nullable_Types_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //struct types cannot be null like.
            //double x = null; That's the wrong way, but we can make this happen like the example below. The easier way or... the hardest one?
            
            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            if (x.HasValue)
            {
                Console.WriteLine(x.Value); 
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine("Y is not null: " + y.Value);
            }



        }
    }
}
