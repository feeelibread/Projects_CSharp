using System;

namespace While_Structure_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = int.Parse(Console.ReadLine());

            while (password != 2002) 
            {
                Console.WriteLine("Senha inválida!");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");

        }

    }
}
