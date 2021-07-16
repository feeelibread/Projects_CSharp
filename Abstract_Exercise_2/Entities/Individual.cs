using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise_2.Entities
{
    class Individual : Person
    {
        public double HealthExpenses { get; set; }

        public Individual(double healthExpenses, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TotalTax()
        {
            if (AnnualIncome < 20000)
            {
                if (HealthExpenses > 0)
                {
                    return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
                }
                else
                {
                    return AnnualIncome * 0.15;
                }
            }
            else
            {
                if (HealthExpenses > 0)
                {
                    return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
                }
                else
                {
                    return AnnualIncome * 0.25;
                }
            }

        }
    }
}
