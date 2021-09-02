using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Generics_2.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new Exception("Compare error: argument is not an Employee.");
            }
            Product p = obj as Product;
            return Price.CompareTo(p.Price);
        }
    }
}
