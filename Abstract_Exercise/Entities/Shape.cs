using Abstract_Exercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Exercise.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public TypeOfShape TypeOfShape { get; set; }

        protected Shape(Color color)
        {
            Color = color;
            
        }

        public abstract double Area();
    }
}
