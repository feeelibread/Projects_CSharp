using Generics_1.Services;
using System;

namespace Generics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            PrintService<string> printService1 = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            intPrintService(printService, n);
            stringPrintService(printService1, n);


        }

        private static void stringPrintService(PrintService<string> printService, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                printService.AddValue(name);
            }
            printService.Print();

            Console.WriteLine("\nFirst: " + printService.First());

        }

        private static void intPrintService(PrintService<int> printService, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            int a = printService.First();
            int b = 10 + a;

            Console.WriteLine("\nresult of first + 10: " + b);
            Console.WriteLine("\nFirst: " + printService.First());
        }
    }
}
