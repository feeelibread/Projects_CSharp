using Linq_Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Linq_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            List<Products> products = new List<Products>();
            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(';');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                products.Add(new Products(name, price));
            }
            var avg = products.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine($"Price average: {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name);
            foreach (var item in names)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
