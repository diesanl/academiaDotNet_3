using System.Globalization;
using System.IO.IsolatedStorage;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Lista4Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
             */
            //int tamanho = 10, even = 0, odd = 0;
            //int[] nums = new int[10];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Digite um valor: ");
            //    nums[i] = int.Parse(Console.ReadLine());

            //    if (nums[i] % 2 == 0)
            //    {
            //        even++ ;

            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //}

            //Console.WriteLine("Qtde de pares: {0}", even);
            //Console.WriteLine("Qtde de pares: {0}", odd);

            /*2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos 
             * elementos da mesma posição, armazenando o resultado em um outro vetor.
             */

            //int tamanho = 20;
            //var rand = new Random();
            //int[] vetorA = new int[tamanho];
            //int[] vetorB = new int[tamanho];
            //int[] vetorSoma = new int[tamanho];

            //for (int i = 0; i < tamanho; i++)
            //{
            //    vetorA[i] = rand.Next(2);
            //    vetorB[i] = rand.Next(2);

            //    vetorSoma[i] = vetorA[i] + vetorB[i];
            //}

            //foreach (var valorSoma in vetorSoma)
            //{
            //    Console.WriteLine(valorSoma);
            //}

            /*3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição 
             * dos valores correspondentes a números primos.
             */

            //int tamanho = 20, divisivel = 1;
            //var rand = new Random();
            //int[] nums = new int[tamanho];

            //for (int i = 0; i < tamanho; i++)
            //{
            //    nums[i] = rand.Next(11);
            //}

            //int count = 0;
            //foreach (var num in nums)
            //{
            //    divisivel = 1;

            //    Console.WriteLine(num);
            //    for (int i = num; i >= 2; i--)
            //    {
            //        if (num % i == 0)
            //        {
            //            divisivel++;
            //        }
            //    }

            //    if (divisivel == 2)
            //    {
            //        Console.WriteLine("O número {0} é primo e está na posição {1}", num, count);
            //    }
            //    count++;
            //}

            /*4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação 
             * dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
             */

            //int tam = 10;
            //int[] vetorA = new int[tam], vetorB = new int[tam], vetorC = new int[tam];
            //Random random = new Random();

            ////A
            //Console.Write("A = {");
            //for (int i = 0; i < vetorA.Length; i++)
            //{
            //    vetorA[i] = random.Next(1, 11);
            //    if (i < vetorA.Length - 1)
            //    {
            //        Console.Write(vetorA[i] + " - ");
            //    }
            //    else
            //    {
            //        Console.Write(vetorA[i]);
            //    }
            //}
            //Console.Write("}");
            //Console.WriteLine();

            ////B
            //Console.Write("B = {");
            //for (int i = 0; i < vetorB.Length; i++)
            //{
            //    vetorB[i] = random.Next(1, 11);
            //    if (i < vetorB.Length - 1)
            //    {
            //        Console.Write(vetorB[i] + " - ");
            //    }
            //    else
            //    {
            //        Console.Write(vetorB[i]);
            //    }
            //}
            //Console.Write("}");
            //Console.WriteLine();

            ////C
            //for (int i = 0; i < vetorC.Length; i++)
            //{
            //    vetorC[i] = vetorA[i] * vetorB[i];
            //    Console.WriteLine(vetorA[i] + " * " + vetorB[i] + " = " + vetorC[i]);
            //}
            //Console.WriteLine();

            /*5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
             */

            //int tam = 80, menor = 0, pos = 0;
            //int[] vetorA = new int[tam];
            //Random random = new Random();

            //menor = random.Next(10, 101);

            //for (int i = 0; i < vetorA.Length; i++)
            //{
            //    vetorA[i] = random.Next(1, 100);
            //    if (vetorA[i] > menor)
            //    {
            //        menor = vetorA[i];
            //        pos = i;
            //    }
            //}

            //Console.WriteLine("O maior número do vetorA é: {0} e, está na posição {1}", menor, pos);


            /*6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
                    a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                    b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
             */

            //int tam = 10;
            //int[] nums = new int[tam];
            //Random random = new Random();

            //Console.WriteLine("IN");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(1, 100);
            //    if (i < nums.Length - 1)
            //    {
            //        Console.Write(nums[i] + "|");
            //    }
            //    else
            //    {
            //        Console.Write(nums[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("OUT");
            //for (int i = nums.Length - 1; i >= 0; i--)
            //{
            //    if (i > 0)
            //    {
            //        Console.Write(nums[i] + "|");
            //    }
            //    else
            //    {
            //        Console.Write(nums[i]);
            //    }
            //}

            /*7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
                    a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                    b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
             */

            //int tam = 10;
            //int[] nums = new int[tam], even = new int[tam], odd = new int[tam];
            //Random random = new Random();

            ////preenche
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(0, 101);
            //}

            ////imprime
            //int count = 0;
            //foreach (var num in nums)
            //{
            //    if (count < nums.Length - 1)
            //    {
            //        Console.Write(num + "|");
            //        count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            ////ordena pares 1st
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] % 2 != 0)
            //        {
            //            int aux = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = aux;
            //        }
            //    }
            //}

            ////imprime
            //count = 0;
            //foreach (var num in nums)
            //{
            //    if (count < nums.Length - 1)
            //    {
            //        Console.Write(num + "|");
            //        count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(num + "|");
            //    }
            //}

            /*8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
                    a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
                    b.	escreve: 	|3|5|6|7|9|10|14|. . .
             */

            //int[] nums = new int[tam], even = new int[tam], odd = new int[tam];

            //int tam = 30;
            //double[] nums = new double[tam], positions = new double[tam];
            //Random random = new Random();

            ////preenche
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(-51, 100);
            //}

            ////print nums
            //foreach (var num in nums)
            //{
            //    Console.Write(num + "|");
            //}
            //Console.WriteLine();

            ////check negative numbers
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        positions[count] = i;
            //        count++;
            //    }
            //}

            ////print positions
            //foreach (var pos in positions)
            //{
            //    Console.Write(pos + "|");
            //}
            //Console.WriteLine();

            /*9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse 
             *      vetor, utilizando um vetor auxiliar.*/

            //Random random = new Random();
            //int tam = 10;
            //int[] nums = new int[tam], aux = new int[tam];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(51);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1, indexAux = 0; j < nums.Length; j++, indexAux++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            aux[indexAux] = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = aux[indexAux];

            //        }
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("NUMS[{0}]: {1}", i, nums[i]);
            //    Console.WriteLine("AUX[{0}]: {1}", i, aux[i]);
            //}

            //foreach (var num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            /*10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. 
             *      Mostre os vetores lidos e o vetor resultado.
             */

            //int tam = 20, number = 0;
            //int[] nums = new int[tam], aux = new int[tam];

            //Random random = new Random();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(-51, 51);
            //}

            Cliente cliente = new Cliente();
            cliente.nome = "Diego";
            cliente.idade = 37;

            Conta c = new Conta(cliente, 1000, "poupança");

            //Console.WriteLine(c.getSaldo());
            //c.Creditar(10000);
            //Console.WriteLine(c.getSaldo());
            //c.Debitar(100);
            //Console.WriteLine(c.getSaldo());

            while (true)
            {
                Console.WriteLine("Digite \n" +
                                  "1- sacar\n" +
                                  "2-- depositar\n" +
                                  "3- saldo\n" +
                                  "0- sair");

                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do saque: ");
                        c.Debitar(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor de deposito: ");
                        c.Creditar(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("O saldo eh de : {0}", c.getSaldo());
                        break;
                    default:
                        Console.WriteLine("O cliente {0} possui saldo de: {1}", c.cliente.nome, c.getSaldo());
                        break;
                }

            }

        }
    }
}