using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise_2.Entities
{
    class Company : Person
    {
        public int TotalEmployees { get; set; }

        public Company(int totalEmployees, string name, double annualIncome) : base(name, annualIncome)
        {
            TotalEmployees = totalEmployees;
        }

        public override double TotalTax()
        {
            if (TotalEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
