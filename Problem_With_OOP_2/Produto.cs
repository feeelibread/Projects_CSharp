using System.Globalization;

namespace Problem_With_OOP_2
{
    class Produto
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, int quantidade, double preco) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
