using System.Globalization;

namespace Static_Members
{
    class ConversorDeMoedas
    {
        public static double IOF = 0.06;
        public double CotacaoDolar;
        public double ValorEmDolar;

        public double ValorEmReais()
        {
            double result = ValorEmDolar * CotacaoDolar;
            return  result + (result * IOF);
        }

        public override string ToString()
        {
            return $"Valor a ser pago em reais = {ValorEmReais().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
