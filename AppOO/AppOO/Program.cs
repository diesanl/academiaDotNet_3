namespace AppOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes, objetos métodos e OO básica!");

            //Lampada l1 = new Lampada();

            //l1.ligar();

            //Console.WriteLine("Status da lâmpada: {0}", l1.estaDesligada());

            //l1.desligar();
            //Console.WriteLine("Status da lâmpada: {0}", l1.estaDesligada());

            //TransacaoBancaria tb = new TransacaoBancaria();

            //tb.ExibirDados();

            Pessoa pessoa = new Pessoa("Masculino", "Diego", 37, "Campeão Brasileiro de 2022", 1.77, 74);

            Console.WriteLine(pessoa.ToString());

            Livro livro = new Livro("978-85-60031-64-1", "A linguagem de Programação Java", "Bookman", 800, 399.99);

            Console.WriteLine(livro);
        }
    }
}