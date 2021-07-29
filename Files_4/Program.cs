using System;
using System.IO;

namespace Files_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using StreamWriter sw = File.AppendText(targetPath);
                foreach (string item in lines)
                {
                    sw.WriteLine(item.ToLower());
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
