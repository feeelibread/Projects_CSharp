using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the LINQ, it has many options for consulting.
            //To work with it, this process usually involves 3 steps.


            //Data source = where the data comes from
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            //Query expression
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10).ToList();

            //Executing the query
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
