using Interfaces_And_Abstracts.Model.Entities;
using Interfaces_And_Abstracts.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Interfaces_And_Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractShape> list = new List<AbstractShape>
            {
                new Circle(Color.Black, 3.2),
                new Retangle(2.0, 3.0, Color.White)
            };

            foreach (AbstractShape item in list)
            {
                Console.WriteLine($"Color: {item.Color}, Type Of Shape: {item.TypeOfShape}" +
                    $", Area: {item.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            
        }
    }
}
