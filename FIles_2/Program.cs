using System;
using System.IO;

namespace FIles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
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
                if (fs != null) fs.Close();
            }
        }
    }
}
