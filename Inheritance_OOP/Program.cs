using Inheritance_OOP.Entities;
using System;
using System.Collections.Generic;

namespace Inheritance_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //An abstract class cannot be instantianted, it works like a mold for the classes
            //SavingsAccount and BusinessAccount
            //Account acc1 = new Account(1001, "Berto", 1500.00);
            List<Account> acc = new List<Account>();
            acc.Add(new SavingsAccount(1002, "Robert", 1350.50, 0.50));
            acc.Add(new BusinessAccount(1003, "Robert", 1350.50, 200.00));
            acc.Add(new SavingsAccount(1004, "Pale", 1350.50, 0.50));
            acc.Add(new BusinessAccount(1005, "L", 1350, 10.0));

            double sum = 0.0;
            foreach (Account item in acc)
            {
                sum += item.Balance;
            }
            Console.WriteLine($"Total balance: {sum}");

            foreach (Account item in acc)
            {
                item.Withdraw(100);
                Console.WriteLine($"\nUpated balance {item.Number}: {item.Balance.ToString("C2")}");
            }


        }


    }
}

