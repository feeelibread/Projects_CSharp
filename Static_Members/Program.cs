using System;
using System.Globalization;

namespace Static_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoedas conversor = new ConversorDeMoedas();

            Console.Write("Qual é a cotação do dólar? ");
            conversor.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            conversor.ValorEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(conversor);

        }
    }
}
