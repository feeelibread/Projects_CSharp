using Abstract_Exercise.Entities;
using Abstract_Exercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i}:");
                Console.Write("Retangle or Circle (r/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (answer == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Retangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape item in shapes)
            {
                Console.WriteLine($"{item.Color}, {item.TypeOfShape} = {item.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
