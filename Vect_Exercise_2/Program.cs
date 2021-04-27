using System;
using System.Globalization;

namespace Vect_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] p = new Product[n];

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Product { Name = name, Price = price };
                sum += p[i].Price;
            }
            sum = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + sum.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
