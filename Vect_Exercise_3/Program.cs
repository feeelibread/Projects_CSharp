using System;

namespace Vect_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] students = new Estudantes[10];
            Console.Write("How many rooms will be rented? ");
            int rent = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= rent; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                students[room] = new Estudantes(name, email);
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }

            }
        }
    }
}
