using Exceptions_Exercise.Entities;
using Exceptions_Exercise.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exceptions_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance.ToString("C2")}");

            }
            catch (DomainException e)
            {

                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
