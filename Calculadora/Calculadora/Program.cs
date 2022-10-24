using System.Xml;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            int op;
            Console.WriteLine("Digite 2 números");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a operação: \n1.Soma \n2.Subtração \n3.Multiplicação \n4.Divisão \n5.Potência \n\nEscolha:");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("Soma = " + resultado);
            }
            if (op == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("Subtração = " + resultado);
            }
            if (op == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("Multiplicação = " + resultado);
            }
            if (op == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine("Divisão = " + resultado);
            }
            if (op == 5)
            {
                resultado = Math.Pow(num1, num2);
                Console.WriteLine("Potenciação = " + resultado);
            }
        }
    }
}