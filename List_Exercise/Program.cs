using System;
using System.Collections.Generic;

namespace List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(id: 1, name: "Roberto", salary: 1000.0));
            employees.Add(new Employee(id: 2, name: "John", salary: 1050.0));
            employees.Add(new Employee(id: 3, name: "Aquele cara lá", salary: 998.0));

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"ID: {employees[i].Id}, Name: {employees[i].Name}, Salary: {employees[i].Salary.ToString("C2")}");
            }
        }
    }
}
