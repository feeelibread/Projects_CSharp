using System;
using System.Globalization;

namespace Problem_Resolved_With_OOP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(aluno);

        }
    }
}
