using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Linq_Exercise_2.Entities;
using System.Globalization;

namespace Linq_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double costumerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Costumer> costumers = new List<Costumer>();

            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(';');
                string name = fields[0];
                string email = fields[1];
                double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                costumers.Add(new Costumer(name, email, salary));
            }

            IEnumerable<string> result = costumers.Where(p => p.Salary > costumerSalary).Select(p => p.Email);
            Console.WriteLine($"Email of people whose salary is more than {costumerSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            double sum = costumers.Where(p => p.Name[0] == 'M').DefaultIfEmpty().Sum(p => p.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
