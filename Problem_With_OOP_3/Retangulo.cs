using System;
using System.Globalization;

namespace Problem_With_OOP_3
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"PERMIETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
