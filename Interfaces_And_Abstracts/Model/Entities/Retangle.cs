using Interfaces_And_Abstracts.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_And_Abstracts.Model.Entities
{
    class Retangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
            TypeOfShape = TypeOfShape.Retangle;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
