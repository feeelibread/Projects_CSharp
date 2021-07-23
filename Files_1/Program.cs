using System;
using System.IO;

namespace Files_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Public\file1.txt";
            string targetPath = @"C:\Users\Public\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(targetPath);
                foreach (string item in lines)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
