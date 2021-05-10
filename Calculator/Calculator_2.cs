using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator_2
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int x in numbers)
            {
                sum += x;
            }
            return sum;
        }

    }
}
