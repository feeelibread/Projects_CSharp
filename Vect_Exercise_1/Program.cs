using System;
using System.Globalization;

namespace Vect_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }
            sum = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
