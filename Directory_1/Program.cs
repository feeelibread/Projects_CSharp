using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\folder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error has ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
