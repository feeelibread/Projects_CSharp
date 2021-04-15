using System;
using System.Globalization;

namespace Problem_With_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
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
