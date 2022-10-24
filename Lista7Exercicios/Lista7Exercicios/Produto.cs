namespace Lista7Exercicios
{
    internal class Produto
    {
        public double preco;
        public int estoque;

        public Produto()
        {
        }

        public Produto(double preco, int estoque)
        {
            this.preco = preco;
            this.estoque = estoque;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}