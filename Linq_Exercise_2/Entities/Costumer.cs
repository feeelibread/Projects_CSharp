using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Exercise_2.Entities
{
    internal class Costumer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Costumer(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
