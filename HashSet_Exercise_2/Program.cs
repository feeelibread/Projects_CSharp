using System;
using System.Collections.Generic;

namespace HashSet_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hash = new HashSet<int>();

            Console.Write("How many studens for course A: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int students = int.Parse(Console.ReadLine());
                hash.Add(students);
            }

            Console.Write("How many studens for course B: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int students = int.Parse(Console.ReadLine());
                hash.Add(students);
            }
            
            Console.Write("How many studens for course C: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int students = int.Parse(Console.ReadLine());
                hash.Add(students);
            }

            Console.WriteLine($"Total students: {hash.Count}");
        }
    }
}
