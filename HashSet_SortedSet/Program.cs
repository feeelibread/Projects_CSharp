using System;
using System.Collections.Generic;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Notebook");
            set.Add("TV");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
