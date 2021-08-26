using Interfaces_And_Abstracts.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_And_Abstracts.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public TypeOfShape TypeOfShape { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
