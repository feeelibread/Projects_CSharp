using Interface_IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\source\test.txt";

            try
            {
                using StreamReader sr = File.OpenText(path);
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee item in list)
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
