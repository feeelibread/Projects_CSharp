using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_2.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return $"{Name}, {TotalPrice().ToString("C2")} (Customs fee: {CustomsFee.ToString("C2")})";
        }
    }
}
