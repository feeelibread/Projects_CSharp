using System;

namespace Equals_HasCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "maria";
            string b = "roberto";

            Console.WriteLine(a.Equals(b));

            //If the code of objects is different, probably they are different. It has a chance do "collide"
            //and generate the same hash code for different objects, but hardly ever happens
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
