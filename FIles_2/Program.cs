using System;
using System.IO;

namespace FIles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                string line = sr.ReadToEnd();
                Console.WriteLine(line);

            }
            catch (Exception e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
