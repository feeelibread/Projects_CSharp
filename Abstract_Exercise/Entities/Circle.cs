using Abstract_Exercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise.Entities
{
    sealed class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
            TypeOfShape = TypeOfShape.Circle;

        }

        public sealed override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
