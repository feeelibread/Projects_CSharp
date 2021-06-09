using System;
using System.Globalization;

namespace Vect_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();

        }

        static void Exercise1()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                Console.Write(vect[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
        }

        static void Exercise2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] vect = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            int count = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = int.Parse(s[i]);
                if(vect[i] % 2 == 0)
                {
                    count++;
                    Console.Write($"{vect[i]} ");
                }
            }
            Console.WriteLine($"\n{count}");
        }

        static void Exercise3()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];


        }

    }
}
