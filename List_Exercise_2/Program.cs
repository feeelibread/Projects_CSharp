using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace List_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Original();
            Novo();

        }

        private static void Novo()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(1, "Maria das Dores", 1000));
            employees.Add(new Employee(2, "Maria Joaquina", 1000));
            employees.Add(new Employee(3, "Ana Joaquina", 1000));
            employees.Add(new Employee(4, "Ana Maria", 1000));
            employees.Add(new Employee(5, "Tiao do Trambuco", 1000));

            Console.WriteLine("Informe o nome a ser filtrado:");
            string filtroNome = Console.ReadLine().ToUpper();
            var result = employees.Where(e => e.Name.ToUpper().Contains(filtroNome)).Select(e => $"Nome: {e.Name} - Salary: {e.Salary.ToString("C")}").ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].ToString());
            }
        }

        private static void Original()
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
                Console.WriteLine("\nThis id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Salary: {item.Salary.ToString("C2")}");
            }
        }
    }
}
