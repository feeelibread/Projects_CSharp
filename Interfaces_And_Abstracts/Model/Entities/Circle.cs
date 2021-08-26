using Interfaces_And_Abstracts.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_And_Abstracts.Model.Entities
{
    class Circle : AbstractShape
    {
        private const double Pi = 3.14;

        public double Radius { get; set; }
        
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
            TypeOfShape = TypeOfShape.Circle;
        }

        public override double Area()
        {
            return Radius * Pi;
        }
    }
}
