using System;
using System.Globalization;

namespace Vect_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select one number of the exercises below:");
            Console.WriteLine("1 - To read and print the vector");
            Console.WriteLine("2 - Show the even numbers and how many it has");
            Console.WriteLine("3 - Arithmetic mean of the elements and show the numbers there are below of the mean");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                default:
                    Console.WriteLine("Invalid exercise");
                    break;
            }
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
            string[] s = Console.ReadLine().Split(' ');
            double avg = 0;

            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                avg += vect[i] / n;
            }

            Console.WriteLine(avg.ToString("F3", CultureInfo.InvariantCulture));
           
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] < avg)
                {
                    Console.WriteLine(vect[i].ToString(CultureInfo.InvariantCulture));
                }
            }

        }

    }
}
