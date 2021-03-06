using Inheritance_Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> emp = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsorced (y/n)? ");
                char answer = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (answer == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee item in emp)
            {
                Console.WriteLine($"{item.Name} -  {item.Payment().ToString("C2")}");
            }

        }
    }
}
