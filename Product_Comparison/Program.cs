using Product_Comparison.Entities;
using System;
using System.Collections.Generic;

namespace Product_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 1500.00));
            list.Add(new Product("Alexa", 350.00));
            list.Add(new Product("Notebook", 8900.00));

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
