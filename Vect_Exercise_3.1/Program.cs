using System;

namespace Vect_Exercise_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[10];
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                students[room] = new Students(name, email);
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if(students[i] != null)
                    Console.WriteLine($"{i}: {students[i]}");
            }

        }
    }
}
