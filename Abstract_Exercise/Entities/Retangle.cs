using Abstract_Exercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise.Entities
{
    sealed class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
            TypeOfShape = TypeOfShape.Retangle;
        }

        public sealed override double Area()
        {
            return Width * Height;
        }
    }
}
