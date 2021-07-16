using Abstract_Exercise_2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i}:");
                Console.Write("Individual or company (i/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, annualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, name, annualIncome));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double sum = 0.0;
            foreach (Person p in list)
            {
                Console.WriteLine($"{p.Name}: {p.TotalTax().ToString("C2")} ");
                sum += p.TotalTax();
            }

            Console.Write($"\nTOTAL TAXES: {sum.ToString("C2")}");
            
        }
    }
}
