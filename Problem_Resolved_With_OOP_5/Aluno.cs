using System;
using System.Globalization;

namespace Problem_Resolved_With_OOP_5
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60)
            {
                return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO!";
            }
            else
            {
                double restante = 60 - NotaFinal();
                return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"\nREPROVADO!" +
                    $"\nRESTARAM {restante} PONTOS!";
            }
         }
    }
}
