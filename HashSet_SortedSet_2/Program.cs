using HashSet_SortedSet_2.Entities;
using System;
using System.Collections.Generic;

namespace HashSet_SortedSet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> p = new HashSet<Product>();
            p.Add(new Product("Notebook", 1200.00));
            p.Add(new Product("Tablet", 900.00));

            HashSet<Point> point = new HashSet<Point>();
            point.Add(new Point(1, 2));
            point.Add(new Point(3, 4));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(p.Contains(prod));

            Point points = new Point(3, 4);
            Console.WriteLine(point.Contains(points));


        }
    }
}
