namespace Lista7Exercicios
{
    internal class Item
    {
        public Produto produto;
        public int qtde;

        public Item()
        {
        }

        public Item(Produto produto, int qtde)
        {
            this.produto = produto;
            this.qtde = qtde;
        }

        public override string? ToString()
        {
            return "Produto: " + produto + "\n" +
                   "Qtde: " + qtde + "\n";
        }
    }
}