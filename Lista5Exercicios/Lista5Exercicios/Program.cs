namespace Lista5Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos 
             * elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
             */

            //int[,] matriz = new int[5, 3];
            //Random random = new Random();

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    //Console.WriteLine("Digite os números da 1st coluna... ");
            //    matriz[i, 0] = random.Next(11);
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //    matriz[i, 2] = matriz[i, 0] * 2;
            //}

            ////percorrendo linhas
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*2) Solicite ao usuário, preencher uma Matriz 3x3
                Informe ao usuário:
                *A soma dos elementos de cada linha
	                -Ex: Linha 1: 30
	                     Linha 2: 17
                *A soma dos elementos de cada coluna
	                -Ex: Coluna 1: 23
	                     Coluna 2: 36
             */

            //int somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0, somaColuna1 = 0, somaColuna2 = 0, somaColuna3 = 0;
            //int[,] matriz = new int[3, 3];

            //Console.WriteLine("Preencha matriz 3x3 (um número por vez)");

            ////linha
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    //coluna
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Imprimindo matriz
            ////percorrendo linhas
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (i == 0)
            //        {
            //            somaLinha1 += matriz[i, j];
            //        }
            //        else if (i == 1)
            //        {
            //            somaLinha2 += matriz[i, j];
            //        }
            //        else if (i == 2)
            //        {
            //            somaLinha3 += matriz[i, j];
            //        }
            //        if (j == 0)
            //        {
            //            somaColuna1 += matriz[i, j];
            //        }
            //        else if (j == 1)
            //        {
            //            somaColuna2 += matriz[i, j];
            //        }
            //        else if (j == 2)
            //        {
            //            somaColuna3 += matriz[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("Soma coluna 1: {0} \n" +
            //                  "Soma coluna 2: {1} \n" +
            //                  "Soma coluna 3: {2} \n" +
            //                  "Soma linha 1: {3} \n" +
            //                  "Soma linha 2: {4} \n" +
            //                  "Soma linha 3: {5}", somaColuna1, somaColuna2, somaColuna3, somaLinha1, somaLinha2, somaLinha3);


            /*3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
             */

            //int[,] matriz = new int[4, 4];
            //Random random = new Random();

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(101);
            //    }
            //}
            //Console.WriteLine();

            //////Imprimindo matriz
            //////percorrendo linhas
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    Console.WriteLine(matriz[i, i]);
            //}

            /*
             * 4) Popule uma matriz 5x5 e informe:
                -Quantos números são pares
                -Quantos números são impares
                -Quantos números são positivos
                -Quantos números são negativos
                -Quantos zeros existem!
             */


            //int[,] matriz = new int[5, 5];
            //int even = 0, odd = 0, negative = 0, positive = 0, zeroes = 0;
            //Random random = new Random();

            ////popula matriz
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(7);
            //        if (matriz[i, j] < 0)
            //        {
            //            negative++;
            //        }
            //        else if (matriz[i, j] > 0)
            //        {
            //            positive++;
            //        }
            //        else
            //        {
            //            zeroes++;
            //        }
            //        if (matriz[i, j] % 2 == 0)
            //        {
            //            even++;
            //        }
            //        else
            //        {
            //            odd++;
            //        }
            //    }
            //}

            ////////Imprimindo matriz
            ////////percorrendo linhas
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("qtde de pares: {0} \n" +
            //                  "qtde ímpares: {1} \n" +
            //                  "qtde de positivos: {2} \n" +
            //                  "qtde de negativos: {3} \n" +
            //                  "qtde de zeros: {4} ", even, odd, positive, negative, zeroes);


            /*
             * 5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.
             */

            //double[,] matrizA = new double[2, 3];
            //double[,] matrizB = new double[2, 3];

            //Random random = new Random();

            ////populate A
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.NextDouble();
            //    }
            //}

            ////populate B
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        matrizB[i, j] = random.NextDouble();
            //    }
            //}

            //////////Imprimindo matrizes 
            //////////percorrendo linhas
            //for (int l = 0; l < matrizA.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizA.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizA[l, c].ToString("F") + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int l = 0; l < matrizB.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizB.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizB[l, c].ToString("F") + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        //soma dos valores dos vetores Ex: matrizA[0,0] + matrizB[0,0] = result
            //        double soma = matrizA[i, j] + matrizB[i, j];
            //        Console.Write(("[" + i + "," + j + "] = " + soma.ToString("F") + " "));
            //    }
            //    Console.WriteLine();
            //}


            /*
             * 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
             */

            //int[,] matriz = new int[4, 4];
            //int maior = 0;
            //Random random = new Random();

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(10);
            //        if (matriz[i, j] > maior)
            //        {
            //            maior = matriz[i, j];
            //        }
            //    }
            //}

            ////////////Imprimindo matriz 
            ////////////percorrendo linhas
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("O maior número é: {0}", maior);


            /*7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
             */

            //int[,] matrizA = new int[3, 3];
            //int[,] matrizB = new int[3, 3];
            //int[,] matrizC = new int[3, 3];

            //Random random = new Random();

            ////preenche A
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.Next(10);
            //    }
            //}

            ////preenche B
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        matrizB[i, j] = random.Next(10);
            //    }
            //}

            ////preenche C = soma (A e B)
            //for (int i = 0; i < matrizC.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizC.GetLength(1); j++)
            //    {
            //        matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
            //    }
            //}

            //////////////Imprimindo matriz A
            //////////////percorrendo linhas
            //for (int l = 0; l < matrizA.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizA.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizA[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //////////////Imprimindo matriz B
            //for (int l = 0; l < matrizB.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizB.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizB[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //////////////Imprimindo matriz C
            //for (int l = 0; l < matrizC.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizC.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizC[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //9) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            //int[,] matriz = new int[4, 4];

            //Random random = new Random();

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(10);
            //    }
            //}

            ////////////////Imprimindo matriz 
            //for (int l = 0; l < matriz.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matriz.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matriz[l, c] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("\n");

            ////Imprime matriz ao contrario
            //for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            //{
            //    for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            //    {
            //        Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*10) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
                Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
             */


            //int[,] matriz = new int[3, 3];
            //Random random = new Random();
            //int guess = 0;
            //bool found = false;

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(16);
            //    }
            //}

            //do
            //{
            //    Console.WriteLine("Digite um número a ser pesquisado na matriz (de 0 a 15)...\n" +
            //                      "Digite -1 se deseja sair.....");
            //    guess = int.Parse(Console.ReadLine());
            //    int linha = 0, coluna = 0;

            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            if (matriz[i, j] == guess)
            //            {
            //                found = true;
            //                linha = i;
            //                coluna = j;
            //                //return;
            //                break;
            //            }
            //        }
            //    }

            //    if (found)
            //    {
            //        Console.WriteLine("O número existe no vetor na posição [" + linha + "," + coluna + "]");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Número inexistente");
            //    }

            //} while (guess != -1 || !found);

            /*11) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, 
             * diga quantos dos elementos lidos estão abaixo, acima e na média.
             */

            //int avrgeA = 0, avrgeB = 0, totalAvrge = 0, countAcima = 0, countAbaixo = 0, countAvrge = 0;
            //int[,] matrizA = new int[4, 4], matrizB = new int[4, 4];
            //Random random = new Random();

            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.Next(1, 21);
            //        avrgeA += matrizA[i, j];
            //    }
            //}

            ////avrgeA /= matrizA.GetLength(0) * matrizA.GetLength(1);

            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        matrizB[i, j] = random.Next(1, 21);
            //        avrgeB += matrizB[i, j];
            //    }
            //}

            ////avrgeB /= matrizB.GetLength(0) * matrizB.GetLength(1);

            //int matrizALength = matrizA.GetLength(0) * matrizA.GetLength(1);
            //int matrizBLength = matrizB.GetLength(0) * matrizB.GetLength(1);

            //totalAvrge = (avrgeA + avrgeB) / (matrizALength + matrizALength);


            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        if (matrizA[i, j] > totalAvrge)
            //        {
            //            countAcima++;
            //        }
            //        else if (matrizA[i, j] < totalAvrge)
            //        {
            //            countAbaixo++;
            //        }
            //        else
            //        {
            //            countAvrge++;
            //        }
            //    }
            //}

            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        if (matrizB[i, j] > totalAvrge)
            //        {
            //            countAcima++;
            //        }
            //        else if (matrizB[i, j] < totalAvrge)
            //        {
            //            countAbaixo++;
            //        }
            //        else
            //        {
            //            countAvrge++;
            //        }
            //    }
            //}

            //////////////////Imprimindo matriz 
            //for (int l = 0; l < matrizA.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizA.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizA[l, c] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("\n");

            //for (int l = 0; l < matrizB.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizB.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizB[l, c] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("Média das 2 matrizes: {0}", totalAvrge);
            //Console.WriteLine("Qtde de números acima da média: {0}", countAcima);
            //Console.WriteLine("Qtde de números abaixo da média: {0}", countAbaixo);
            //Console.WriteLine("Qtde de números na média: {0}", countAvrge);

            /*
             12) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da 
                 divisão dos elementos da matriz A pela soma dos seus indices.
             */

            //double[,] matrizA = new double[3, 3], matrizB = new double[3, 3];

            //Random random = new Random();

            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.NextDouble() + 10;
            //    }
            //}

            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        if (i + j != 0)
            //        {
            //            matrizB[i, j] = matrizA[i, j] / (i + j);
            //        }
            //        else
            //        {
            //            //ask if it is right
            //            matrizB[i, j] = double.NaN;
            //        }
            //    }
            //}

            ////////////////////Imprimindo matriz A
            //for (int l = 0; l < matrizA.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizA.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizA[l, c].ToString("F") + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("\n");

            ////////////////////Imprimindo matriz B
            //for (int l = 0; l < matrizB.GetLength(0); l++)
            //{
            //    //percorrendo colunas
            //    for (int c = 0; c < matrizB.GetLength(1); c++)
            //    {
            //        Console.Write("[" + l + "," + c + "] = " + matrizB[l, c].ToString("F") + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("\n");


            /*A MEGASENA é um jogo da Caixa Econômica Federal (CEF) onde o apostador deve escolher de 6 a 15 números de um conjunto de 60 números (de 1 a 60). 
             * A CEF sorteia 6 números entre os 60. A aposta vencedora é aquela em que o apostador possui os 6 números sorteados pela CEF dentre os números 
             * escolhidos em sua aposta. João é um grande apostador da MEGASENA e um pouco preguiçoso (aposta em todos os concursos, mas tem preguiça em escolher 
             * os números da aposta). Para facilitar a vida de João, crie um programa que escolha aleatoriamente X números do volante (X deve ser informado pelo João). 
             * Gere a representação de um voltante (cédula de aposta) de loteria da MEGASENA (apresente os números do volante dispostos em 6 linhas e 10 colunas numeradas de 1 a 60), 
             * diferenciando destes os X números selecionados aleatoriamente pelo seu programa. Lembre-se de validar a entrada X (deve ser de 6 a 15 conforme descrito anteriormente). 
             * Além de validar a entrada do usuário, selecionar aleatoriamente os números e gerar a representação do volante, o programa deve calcular o valor da aposta. 
             * Cada aposta custa R$3,50 e o número de apostas é dado através do número de combinações existentes no volante. Para o caso da MEGASENA, o número de combinações de uma 
             * aposta é x!/(6!*(x-6)!), onde X é a quantidade de números existentes na aposta (X selecionado pelo apostador). Use a linguagem que quiser ou até mesmo escreva em forma 
             * de algoritmo.
             */

            //Console.WriteLine("MegaSena............");
            //int resp = 0, count = 1, tam = 6;
            //Random random = new Random();
            //int[,] volante = new int[6, 10];


            //Console.WriteLine("Digite a qtde de números q deseja sortear (entre 6 e 15)");
            //Console.WriteLine("Digite qq outro número para SAIR");
            //resp = int.Parse(Console.ReadLine());

            //while (resp <= 15 && resp >= 6)
            //{
            //    tam = resp;
            //    int[] nums = new int[tam];

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        nums[i] = random.Next(61);
            //    }



            //    for (int i = 0; i < volante.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < volante.GetLength(1); j++)
            //        {
            //            volante[i, j] = count;
            //            count++;
            //        }
            //    }

            //    //percorre nums
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        ////////////////////Imprimindo volante
            //        for (int l = 0; l < volante.GetLength(0); l++)
            //        {
            //            //percorrendo colunas
            //            for (int c = 0; c < volante.GetLength(1); c++)
            //            {

            //                if (nums[i] == volante[l, c])
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                    Console.Write(volante[l, c] + " ");
            //                    Console.ResetColor();
            //                }
            //                else
            //                {
            //                    Console.Write(volante[l, c] + " ");
            //                }
            //            }
            //            Console.WriteLine("");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //    break;
            //}

            /*13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
                diagonal secundária.
             */

            //int[,] matriz = new int[5, 5];
            //Random random = new Random();
            //int sumDiagPrin = 0, sumDiagSec = 0;

            ////preencher matriz
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(51);
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////soma diag principal e sec
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    sumDiagPrin += matriz[i, i];
            //    sumDiagSec += matriz[i, (matriz.GetLength(0)) - 1 -i];
            //}

            //Console.WriteLine("Soma da diagonal principal {0}", sumDiagPrin);
            //Console.WriteLine("Soma da diagonal secundária {0}", sumDiagSec);

            /*14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
                são os mesmos da diagonal secundária (direita pra esquerda).
             */

            //int[,] matriz = new int[5, 5];
            //Random random = new Random();
            //int count = 0;

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = random.Next(1, 11);
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////linha (n precisa percorrer do msm jeito q preenche)
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{

            //    if (matriz[i, i] == matriz[i, matriz.GetLength(0) - 1 - i])
            //    //(0,0) (0,(5-1)-0)
            //    //(1,1) (1,(5-1)-1)
            //    //(2,2) (2,(5-1)-2)
            //    //(3,3) (3,(5-1)-3)
            //    //(4,4) (4,(5-1)-4)
            //    {
            //        count++;
            //    }

            //}

            //Console.WriteLine("Qtde de números iguais nas 2 diagonais: {0}", count);


            /*15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
             */

            //int[,] matrizA = new int[4, 4];
            //int[,] matrizB = new int[4, 4];
            //int[,] matrizResult = new int[4, 4];

            //Random random = new Random();

            //Console.WriteLine("\nA");
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.Next(1, 41);
            //        Console.Write(matrizA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nB");
            //for (int i = 0; i < matrizB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizB.GetLength(1); j++)
            //    {
            //        matrizB[i, j] = random.Next(1, 41);
            //        Console.Write(matrizB[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nResult");
            //for (int i = 0; i < matrizResult.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizResult.GetLength(1); j++)
            //    {
            //        matrizResult[i, j] = matrizA[i, j] + matrizB[i, j];
            //        Console.Write(matrizResult[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
             */

            //int[,] matrizA = new int[3, 4], matrizB = new int[4, 3];

            //Random random = new Random();

            ////preenche A
            //Console.WriteLine("preenche A");
            //for (int i = 0; i < matrizA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrizA.GetLength(1); j++)
            //    {
            //        matrizA[i, j] = random.Next(1, 41);
            //        Console.Write(matrizA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            ////preenche B, com valores de A, trocando valores de coluna e linha
            ///começa o for pelo length da coluna, no caso Length(1)
            //Console.WriteLine("preenche B, com valores de A, trocando valores de coluna e linha");
            ////coluna
            //for (int l = 0; l < matrizA.GetLength(1); l++)
            //{
            //    //linha
            //    for (int c = 0; c < matrizA.GetLength(0); c++)
            //    {
            //        matrizB[l, c] = matrizA[c, l];
            //        Console.Write(matrizB[l, c] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde 
             * se encontra o maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
             */

            int[,] matrizA = new int[10, 10];
            int maior = 0, menor = 0, iLinhaMaior = 0, iColunaMaior = 0, iLinhaMenor = 0, iColunaMenor = 0;

            Random random = new Random();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(1, 41);
                    Console.Write(matrizA[i, j] + " ");

                    if (matrizA[i, j] > maior)
                    {
                        maior = matrizA[i, j];
                        iLinhaMaior = i;
                        iColunaMaior = j;
                    }
                }
                Console.WriteLine();
            }

            //menor recebe maior e compara c tds os valores da matriz
            menor = maior;
            for (int i = iLinhaMaior; i == iLinhaMaior; i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] < menor)
                    {
                        menor = matrizA[i, j];
                        iLinhaMenor = i;
                        iColunaMenor = j;
                    }
                }
            }

            Console.WriteLine("O maior número da matriz é o {0} na posição {1}, {2}", maior, iLinhaMaior, iColunaMaior);
            Console.WriteLine("O menor número da linha {0} é o {1} na posição {2}, {3}", iLinhaMaior, menor, iLinhaMenor, iColunaMenor);

        }
    }
}




