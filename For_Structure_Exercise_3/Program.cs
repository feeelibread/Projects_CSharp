using System;
using System.Globalization;

namespace For_Structure_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int p1 = 2, p2 = 3, p3 = 5;
            double media = 0.0;
           
            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(values[2], CultureInfo.InvariantCulture);
                
                media = (double)(n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);
                
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
