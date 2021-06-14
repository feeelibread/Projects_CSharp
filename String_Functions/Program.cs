using System;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "-abcde FGHIJ KLMNO pqrst UVWXYZ abc ab          ";
            string s1 = phrase.ToUpper();
            string s2 = phrase.ToLower();
            string s3 = phrase.Trim();
            
            int s4 = phrase.IndexOf("bc");
            int s5 = phrase.LastIndexOf("bc");
           
            string s6 = phrase.Substring(3);
            string s7 = phrase.Substring(3, 10);

            string s8 = phrase.Replace("ab", "bb");

            bool b1 = String.IsNullOrEmpty(phrase);
            bool b2 = String.IsNullOrWhiteSpace(phrase);

            Console.WriteLine("ToUpper: " + s1 + "-");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("ToLower: " + s2 + "-");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trim: " + s3 + "-");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("IndexOf(bc): "+ s4);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("LastIndexOf(bc): " + s5);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Substring(3): " + s6);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Substring(3, 10): " + s7);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Replace(ab, bb): " + s8);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Is null or empty: " + b1);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Is null or white space: " + b2);

            
        }
    }
}
