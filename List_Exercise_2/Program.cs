using System;
using System.Collections.Generic;
using System.Globalization;

namespace List_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
   
            }

            Console.Write("\nEnter the employee id that will have salary increased: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("\nEnter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percent);
            }
            else
            {
                Console.WriteLine("\nThis id does not exist!\n");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Salary: {item.Salary.ToString("C2")}");
            }
            
        }
    }
}
