using System;

namespace Var_Type
{
    class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var churros = IsShibata();
            var churrosComposto = IsShibataComposta();
            var x = 10;
            var y = 1.0;

        }

        static bool IsShibata()
        {
            return true;
        }

        static Pessoa IsShibataComposta()
        {
            return new Pessoa();
        }
    }
}
