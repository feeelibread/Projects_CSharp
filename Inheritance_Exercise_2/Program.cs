using Inheritance_Exercise_2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Product #{i}:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (answer == 'u')
                {
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacturedDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}
