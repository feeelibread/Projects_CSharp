using System;

namespace Extensions_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 10, 19, 6, 30, 00);
            Console.WriteLine(dt.ElapsedTime());

            string phrase = "Good morning dear students!";
            Console.WriteLine(phrase.Cut(10));
            
        }
    }
}
