using System;

namespace While_Structure_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenates = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenates[0]);
            int y = int.Parse(coordenates[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                
                coordenates = Console.ReadLine().Split(' ');
                x = int.Parse(coordenates[0]);
                y = int.Parse(coordenates[1]);
            }

        }
    }
}
