using System;
using System.Collections.Generic;
using System.IO;
using HashSet_Exercise.Entities;

namespace HashSet_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> logs = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {


                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(' ');
                    string username = lines[0];
                    DateTime instant = DateTime.Parse(lines[1]);
                    logs.Add(new LogRecord(username, instant));
                }

                Console.WriteLine($"Total users: {logs.Count}");
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
