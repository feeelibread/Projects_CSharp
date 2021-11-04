using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Product_Comparison.Entities
{
    class Product : IComparable<Product>
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
            return $"{Name}, {Price.ToString("C2")}";
        }

        public int CompareTo([AllowNull] Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}
