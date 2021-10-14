using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {

                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string[] candidates = sr.ReadLine().Split(';');
                    string name = candidates[0];
                    int votes = int.Parse(candidates[1]);
                    
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary[name] += votes;
                    }
                    else
                    {
                        dictionary[name] = votes;
                    }
                }
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                
            }
            catch (IOException e)
            {

                Console.WriteLine("An error has ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
