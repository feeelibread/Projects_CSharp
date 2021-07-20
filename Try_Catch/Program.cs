using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter numbers for division: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int divide = a / b;
                Console.WriteLine(divide);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error! Not allowed divide by zero.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong format! Input string was in a wrong format.");
            }
            
            

        }
    }
}
