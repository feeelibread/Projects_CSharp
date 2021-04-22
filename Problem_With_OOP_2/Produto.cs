using System.Globalization;

namespace Problem_With_OOP_2
{
    class Produto
    {
        private string _nome;
        private int _quantidade;
        private double _preco;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, int quantidade, double preco) : this(nome, preco)
        {
            _quantidade = quantidade;
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

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
