﻿using Linq_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_2
{
    internal class Program
    {
        static void PrintMessage<T>(string message, IEnumerable<T> ts)
        {
            Console.WriteLine(message);
            foreach (var item in ts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.00
                     select p;
            PrintMessage("TIER 1 AND PRICE < 900.00:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name.ToUpper());
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name.ToUpper();
            PrintMessage("NAMES OF PRODUCTS FROM TOOLS:", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new { p.Name, p.Price, CategoryName = p.Category.Name };
            PrintMessage("PRODUCTS THAT BEGINS WITH LETTER 'C' AND ANONYMOUS OBJECTS:", r3);


            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Name).ThenBy(p => p.Price).Select(p => $"{p.Name}, {p.Price.ToString("C2")}");
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            PrintMessage("PRODUCTS TIER 1 ORDERED BY NAME THEN BY PRICE:", r4);

            var r5 = r4.Skip(2).Take(4);
            PrintMessage("PRODUCTS TIER 1 ORDERED BY NAME THEN BY PRICE, SKIP (2), TAKE (4):", r5);

            var r6 = products.First();
            Console.WriteLine("First or Default test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("First or Default test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default test2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum prices: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 average prices: " + r13);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Category 5 average prices " + r14);
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            //var r16 = products.GroupBy(p => p.Category);
            var r16 = from p in products
                      group p by p.Category;
            foreach (IGrouping<Category, Product> item in r16)
            {
                Console.WriteLine($"Category {item.Key.Name}:");
                foreach (Product p in item)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
