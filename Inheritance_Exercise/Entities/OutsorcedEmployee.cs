using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise.Entities
{
    sealed class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additonalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additonalCharge;
        }

        public sealed override double Payment()
        {
            double percentage = 1.1;
            return base.Payment() + AdditionalCharge * percentage;

        }
    }
}
