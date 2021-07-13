using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_2.Entities
{
    sealed class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used), {Price.ToString("C2")} (Manufactured date: {ManufacturedDate.ToShortDateString()})";
        }
    }
}
