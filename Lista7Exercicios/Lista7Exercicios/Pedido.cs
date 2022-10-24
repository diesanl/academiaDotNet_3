namespace Lista7Exercicios
{
    internal class Pedido
    {
        public List<Item> items;
        public string meioPagamento;

        public Pedido()
        {
        }

        public Pedido(List<Item> items, string meioPagamento)
        {
            this.items = items;
            this.meioPagamento = meioPagamento;
        }
    }
}