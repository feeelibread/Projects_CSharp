using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "991263548";
            cookies["phone"] = "991542135";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("The given key 'email' was not present in the dictionary.");
            }

            Console.WriteLine($"Size: {cookies.Count}");
            Console.WriteLine("All cookies:");
            
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

        }
    }
}
