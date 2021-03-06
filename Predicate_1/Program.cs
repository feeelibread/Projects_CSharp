using Delegates_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Func delegate

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Table", 349.99));
            list.Add(new Product("HD Case", 80.00));

            List<string> result = list.Select(p => $"Name: {p.Name.ToUpper()}, Price: {p.Price:C2}").ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
