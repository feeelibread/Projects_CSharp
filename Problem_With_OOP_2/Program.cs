using System;
using System.Globalization;

namespace Problem_With_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto p = new Produto(nome, preco);
            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nAdicionar produtos ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nRemover produtos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("\nDados atualizados: " + p);

        }
    }
}
