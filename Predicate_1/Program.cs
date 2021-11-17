using Predicate_1.Entities;
using System;
using System.Collections.Generic;

namespace Predicate_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Table", 349.99));
            list.Add(new Product("HD Case", 80.00));

            list.RemoveAll(ProductTest);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
