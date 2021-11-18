using Delegates_2.Entities;
using System;
using System.Collections.Generic;

namespace Delegates_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Action delegate

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Table", 349.99));
            list.Add(new Product("HD Case", 80.00));

            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
