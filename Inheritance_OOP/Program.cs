using Inheritance_OOP.Entities;
using System;

namespace Inheritance_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1008, "Felipe", 1200.00, 200);
            Console.WriteLine(account.Balance);
            
        }
    }
}
