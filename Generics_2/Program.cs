﻿using Generics_2.Entities;
using Generics_2.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(", ");
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }

            CalculationService calculation = new CalculationService();
            Product max = calculation.Max(products);

            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}
