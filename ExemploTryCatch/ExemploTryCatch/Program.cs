using System.Net.Http.Headers;

namespace ExemploTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                Console.WriteLine("Informe valor p X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor de X eh {0}", x);
                Console.WriteLine("O valor de 50 dividido por {0} resulta em {1}", x, 50 / x);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("N eh possível dividir por 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Apenas números devem ser digitados");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("número mto grande digitado");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally!!!");
                Console.WriteLine("Mais utilizado p fechar conexões no BD!!!");
            }
        }
    }
}