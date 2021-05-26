using System;

namespace Matrix_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Length - " + mat.Length);
            Console.WriteLine("Rank - " + mat.Rank);
            Console.WriteLine("Get length (0) - " + mat.GetLength(0));
            Console.WriteLine("Get length (1) - " + mat.GetLength(1));
        }
    }
}
