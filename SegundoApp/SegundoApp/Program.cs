internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Digite um número!");

        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Positivo!!!");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negativo!!!");
        }
        else
        {
            Console.WriteLine("Zero!!!!");
        }
    }
}