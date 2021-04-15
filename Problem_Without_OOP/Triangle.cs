using System;

namespace Problem_With_OOP
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p;
            p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }
    }
}
