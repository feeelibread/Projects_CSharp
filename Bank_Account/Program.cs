using System;
using System.Globalization;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Account account;
            Console.Write("Entre com o numero da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da contar: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char answer = char.Parse(Console.ReadLine());
            if(answer == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Bank_Account(name, accountNumber, initialDeposit);
            }
            else
            {
                account = new Bank_Account(name, accountNumber);
            }
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(account);

            Console.Write("\nEntre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.InitialDeposit(deposit);

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(account);

            Console.Write("\nEntre com um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdraw);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(account);
        }
    }
}
