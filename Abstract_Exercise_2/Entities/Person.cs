using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise_2.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TotalTax();
    }
}
