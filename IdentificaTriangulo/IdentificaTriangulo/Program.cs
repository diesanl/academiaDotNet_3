namespace IdentificaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os 3 lados do triângulo:");
            Console.WriteLine("Digite o lado A:");
            int ladoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B:");
            int ladoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado C:");
            int ladoC = int.Parse(Console.ReadLine());

            if ((ladoA < (ladoB + ladoC)) && (ladoB < (ladoA + ladoC)) && ladoC < (ladoA + ladoB))
            {
                Console.WriteLine("É um triângulo");

                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }

            }
            else
                Console.WriteLine("Não é um triângulo");

        }
    }
}