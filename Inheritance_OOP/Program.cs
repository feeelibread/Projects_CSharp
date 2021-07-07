using Inheritance_OOP.Entities;
using System;

namespace Inheritance_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Casting();
            OverrideAndVirtual();

        }

        private static void OverrideAndVirtual()
        {
            Account acc = new Account(1002, "Allan", 500.00);
            Account acc2 = new SavingsAccount(1003, "Robert", 500.00, 0.0);
            acc.Withdraw(100);
            acc2.Withdraw(100);
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc2.Balance);
        }

        private static void Casting()
        {
            Account acc = new Account(1001, "James", 1200.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 3000.00, 200.0);

            //UPCASTING - Converting a subclass to a superclass. This process is called Upcast
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Hodor", 1500.0, 150.0);
            Account acc3 = new SavingsAccount(1004, "Alana", 1300.0, 250.0);

            //DOWNCASTING - Conerting a superclass to a subclass. This process is called Downcast
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(10);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(150.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
