namespace Lista2Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2; Teste se a base ou a altura digitada não foi igual a zero.
             */
            /*
            int resp = 0;
            double baseTriangulo = 0.0, altura = 0.0, area = 0.0;
            Console.WriteLine("Calcula área do  triângulo.... ");
            do
            {

                Console.WriteLine("Digite medida da base:");
                baseTriangulo = double.Parse(Console.ReadLine());

                if (baseTriangulo <= 0)
                {
                    Console.WriteLine("Digite um valor positivo para a base!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite medida da da altura:");
                altura = double.Parse(Console.ReadLine());

                if (altura <= 0)
                {
                    Console.WriteLine("Digite um valor positivo para a altura!!!");
                    // break;
                    continue;
                }

                area = (baseTriangulo * altura) / 2;
                Console.WriteLine("Área do triângulo eh de: " + area);

                Console.WriteLine("Deseja continuar?");
                Console.WriteLine("1- SIM");
                Console.WriteLine("2- NÃO");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.
             */
            /*
            int resp = 0, numero = 0;
            Console.WriteLine("Par ou Ímpar.... ");
            do
            {

                Console.WriteLine("Digite o número desejado:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Digite um valor positivo ou negativo!!!");
                    // break;
                    continue;
                }

                if (numero % 2 == 0)
                    Console.WriteLine("o número " + numero + " é par!!!");
                else
                    Console.WriteLine("o número " + numero + " é ímpar!!!");

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.*/
            /*
            int resp = 0, firstNumber = 0, secondNumber = 0, thirdNumber = 0, fourthNumber = 0, media = 0;
            int[] numbers = new int[4];
            Console.WriteLine("Calcula Média....");
            do
            {

                Console.WriteLine("Digite o 1st número:");
                firstNumber = int.Parse(Console.ReadLine());
                if (firstNumber <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }
                else
                    numbers[0] = firstNumber;

                Console.WriteLine("Digite o 2nd número:");
                secondNumber = int.Parse(Console.ReadLine());
                if (secondNumber <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }
                else
                    numbers[1] = secondNumber;

                Console.WriteLine("Digite o 3rd número:");
                thirdNumber = int.Parse(Console.ReadLine());
                if (thirdNumber <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }
                else
                    numbers[2] = thirdNumber;

                Console.WriteLine("Digite o 4th número:");
                fourthNumber = int.Parse(Console.ReadLine());
                if (fourthNumber <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }
                else
                    numbers[3] = fourthNumber;

                media = numbers.Sum() / numbers.Length;
                foreach (var number in numbers)
                {
                    if (number > media)
                        Console.WriteLine("O número " + number + " é maior que a média, que é de " + media);
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
                  Mostrar na tela qual dos professores tem o maior salário total.*/

            /*
            int resp = 0, size = 4;
            double avrge = 0.0;
            double[] horasLecionadas = new double[size];
            double[] valoresAulas = new double[size];
            Console.WriteLine("Calcula Salário Professor....");
            do
            {

                Console.WriteLine("Digite o qtde de horas/aula do 1st professor:");
                horasLecionadas[0] = double.Parse(Console.ReadLine());
                if (horasLecionadas[0] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o valor da Hora/aula: ");
                valoresAulas[0] = double.Parse(Console.ReadLine());
                if (valoresAulas[0] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o qtde de horas/aula do 2nd professor:");
                horasLecionadas[1] = double.Parse(Console.ReadLine());
                if (horasLecionadas[1] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o valor da Hora/aula: ");
                valoresAulas[1] = double.Parse(Console.ReadLine());
                if (valoresAulas[1] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }



                double valorTotal1stProf = horasLecionadas[0] * valoresAulas[0];
                double valorTotal2ndProf = horasLecionadas[1] * valoresAulas[1];

                if (valorTotal1stProf > valorTotal2ndProf)
                    Console.WriteLine("O 1st professor tem o maior salário, que é de: " + valorTotal1stProf);
                else if (valorTotal2ndProf > valorTotal1stProf)
                    Console.WriteLine("O 2nd professor tem o maior salário, que é de: " + valorTotal2ndProf);
                else Console.WriteLine("Os 2 professores tem o msm salário!!!");



                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
                  se a média das duas notas for maior ou igual a 7,0.
            Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            é a média entre a nota do exame e a média das 2 notas. 
            Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
            escrever “Reprovado”.
             */
            /*
            int resp = 0, size = 3;
            double avrge = 0.0;
            double[] notas = new double[size];

            Console.WriteLine("Calcula média de 2 notas....");
            do
            {

                Console.WriteLine("Digite a 1st nota:");
                notas[0] = double.Parse(Console.ReadLine());
                if (notas[0] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite a 2nd nota: ");
                notas[1] = double.Parse(Console.ReadLine());
                if (notas[1] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                double media = notas.Sum() / notas.Length;


                if (media < 7.0)
                {
                    Console.WriteLine("Digite a nota do exame");
                    notas[2] = double.Parse(Console.ReadLine());

                    media = notas.Sum() / notas.Length;

                    if (media < 7.0)
                    {
                        Console.WriteLine("Reprovado!!! Nota: " + media);
                    }
                    else
                    {
                        Console.WriteLine("Aprovado!!! Nota: " + media);
                    }
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */
            /*
            int resp = 0, size = 3;
            double avrge = 0.0;
            double[] notas = new double[size];

            Console.WriteLine("Calcula média de 2 notas....");
            do
            {

                Console.WriteLine("Digite a 1st nota:");
                notas[0] = double.Parse(Console.ReadLine());
                if (notas[0] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite a 2nd nota: ");
                notas[1] = double.Parse(Console.ReadLine());
                if (notas[1] <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                double media = notas.Sum() / notas.Length;


                if (media < 7.0)
                {
                    Console.WriteLine("Digite a nota do exame");
                    notas[2] = double.Parse(Console.ReadLine());

                    media = notas.Sum() / notas.Length;

                    if (media < 7.0)
                    {
                        Console.WriteLine("Reprovado!!! Nota: " + media);
                    }
                    else
                    {
                        Console.WriteLine("Aprovado!!! Nota: " + media);
                    }
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*
             6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
                O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
                O cálculo do imc = peso / (altura * altura)
            IMC 
            menor que 18                -> baixo peso
            maior que 18 e menor que 25 -> peso normal
            maior que 25 e menor que 30 -> sobrepeso
            maior que 30 e menor que 35 -> obesidade
            maior que 35                -> obesidade grau sério */

            /*
            String nome = "";
            double altura = 0.0, peso = 0.0;
            int resp = 0;

            Console.WriteLine("Calcula IMC....");
            do
            {

                Console.WriteLine("Digite altura:");
                altura = double.Parse(Console.ReadLine());
                if (altura <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite peso: ");
                peso = double.Parse(Console.ReadLine());
                if (peso <= 0)
                {
                    Console.WriteLine("Digite um valor positivo!!!");
                    // break;
                    continue;
                }

                double imc = peso / (Math.Pow(altura, altura));
                imc = Math.Round(imc, 2);


                if (imc < 18.0)
                {
                    Console.WriteLine(imc + " -> baixo peso");
                }
                else if (imc >= 18.0 && imc < 25.0)
                {
                    Console.WriteLine(imc + " -> peso normal");
                }
                else if (imc >= 25.0 && imc < 30.0)
                {
                    Console.WriteLine(imc + " -> sobrepeso");
                }
                else if (imc >= 30.0 && imc < 35.0)
                {
                    Console.WriteLine(imc + " -> obesidade");
                }
                else
                {
                    Console.WriteLine(imc + " -> obesidade grau sério");
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
                O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
                exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
             */
            /*
            String palavra = "", frase = "";
            double altura = 0.0, peso = 0.0;
            int resp = 0;

            Console.WriteLine("Verifica palavra na frase....");
            do
            {
                Console.WriteLine("Digite a frase:");
                frase = Console.ReadLine();
                if (frase.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite a palavra:");
                palavra = Console.ReadLine();
                if (palavra.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                if (frase.Contains(palavra))
                {
                    Console.WriteLine("A palavra " + palavra + " encontra-se na frase ");
                }
                else
                {
                    Console.WriteLine("A palavra " + palavra + " não se encontra na frase.");
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
                Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
                Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
                E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
                total de vendas.
             */
            /*
            String nome = "", codigo = "";
            double salarioBase = 0.0, totalVendas = 0.0, salarioFinal = 0.0, perc = 0.0;
            int resp = 0;

            Console.WriteLine("Calcula salário funcionário....");
            do
            {
                Console.WriteLine("Digite o nome do funcionario:");
                nome = Console.ReadLine();
                if (nome.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o código do produto:");
                codigo = Console.ReadLine();
                if (codigo.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o salário base:");
                salarioBase = double.Parse(Console.ReadLine());
                if (salarioBase <= 0)
                {
                    Console.WriteLine("Digite um valor válido!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite o total de vendas:");
                totalVendas = double.Parse(Console.ReadLine());
                if (totalVendas <= 0)
                {
                    Console.WriteLine("Digite um valor válido!!!");
                    // break;
                    continue;
                }

                if (totalVendas > 5000)
                {
                    perc = 0.1;
                }

                else if (totalVendas > 1000)
                {
                    perc = 0.07;
                }
                else if (totalVendas > 500)
                {
                    perc = 0.05;
                }

                salarioFinal = salarioBase + (totalVendas * perc);
                Console.WriteLine("Nome do funcionário:.........." + nome +
                                  "\nSalário base:..............." + salarioBase +
                                  "\nSalário final:.............." + salarioFinal +
                                  "\n");

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);
            */

            /*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
                diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
                Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
                Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

                Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
                menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
                150, avisá-lo que será necessário adicionar 2 unidades de insulina.
             */

            /*
            int tam = 3;
            double[] valoresGlicemia = new double[tam];
            double avrge = 0.0;
            int resp = 0;

            Console.WriteLine("Verifica glicemia....");
            do
            {
                Console.WriteLine("Digite valor da 1st aferição:");
                valoresGlicemia[0] = double.Parse(Console.ReadLine());
                if (valoresGlicemia[0] <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }
                else if (valoresGlicemia[0] < 65)
                {
                    Console.WriteLine("Risco de Hipoglicemia!!!");
                }
                else if (valoresGlicemia[0] > 250)
                {
                    Console.WriteLine("Risco de Hipoglicemia!!!");
                }

                Console.WriteLine("Digite valor da 2nd aferição:");
                valoresGlicemia[1] = double.Parse(Console.ReadLine());
                if (valoresGlicemia[1] <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }
                else if (valoresGlicemia[1] < 65)
                {
                    Console.WriteLine("Risco de Hipoglicemia!!!");
                }
                else if (valoresGlicemia[1] > 250)
                {
                    Console.WriteLine("Risco de Hiperglicemia!!!");
                }

                Console.WriteLine("Digite valor da 3rd aferição:");
                valoresGlicemia[2] = double.Parse(Console.ReadLine());
                if (valoresGlicemia[2] <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }
                else if (valoresGlicemia[2] < 65)
                {
                    Console.WriteLine("Risco de Hipoglicemia!!!");
                }
                else if (valoresGlicemia[2] > 250)
                {
                    Console.WriteLine("Risco de Hiperglicemia!!!");
                }

                avrge = valoresGlicemia.Sum() / valoresGlicemia.Length;

                if (avrge < 80)
                {
                    Console.WriteLine("Diminua a dose de insulina em 2UI");
                }
                else if (avrge > 150)
                {
                    Console.WriteLine("Aumente a dose de insulina em 2UI");
                }

                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);*/

            /*10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
                    O programa deve mostrar os dados do atleta mais novo e mais alto.
             */

            /*Aula 27/09/22
             * int resp = 0, beginning, end;
            int count = 0, sum = 0, even = 0, odd = 0, sumEven = 0;
            do
            {

                Console.WriteLine("Informe início: ");
                beginning = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe fim: ");
                end = 0;

                while (beginning >= end)
                {
                    Console.WriteLine("Valor inicial não pode ser maior ou igual ao valor final");
                    end = int.Parse(Console.ReadLine());
                }


                for (int i = beginning + 1; i < end; i++)
                {
                    count++;
                    sum += i;

                    if (i % 2 == 0)
                    {
                        even++;
                        sumEven += i;
                    }
                    else
                    {
                        odd++;
                    }
                }
                Console.WriteLine("QTDE números no intervalo {0}", count);
                Console.WriteLine("SOMA dos Números no intervalo: {0}", sum);
                Console.WriteLine("QTDE pares {0}", even);
                Console.WriteLine("QTDE Ímpares {0}", odd);
                Console.WriteLine("SOMA pares {0}", sumEven);

            } while (resp != 2);
             */

            int resp = 1, count = 0;

            while (true)
            {
                Console.WriteLine("digite um valor");
                resp = int.Parse(Console.ReadLine());
                if (resp < 0)
                {
                    break;
                }
                else if (resp % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Valores pares digitados {0}", count);
            //__________________________________________________________________________________
            String nome1, nome2;
            int idade1, idade2;
            double altura1, altura2;


            Console.WriteLine("Compara 2 atletas....");
            do
            {
                Console.WriteLine("Digite nome do 1st atleta:");
                nome1 = Console.ReadLine();
                if (nome1.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite idade do 1st atleta:");
                idade1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite altura do 1st atleta:");
                altura1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite nome do 2nd atleta:");
                nome2 = Console.ReadLine();
                if (nome1.Length <= 0)
                {
                    Console.WriteLine("Digite algo!!!");
                    // break;
                    continue;
                }

                Console.WriteLine("Digite idade do 2nd atleta:");
                idade2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite altura do 2nd atleta:");
                altura2 = double.Parse(Console.ReadLine());

                //mostrar os dados do atleta mais novo e mais alto

                if (idade1.CompareTo(idade2) != 0)
                {
                    if (idade1.CompareTo(idade2) < 0)
                    {
                        Console.WriteLine("O atleta {0} eh o mais novo com {1} anos", nome1, idade1);
                    }
                    else
                    {
                        Console.WriteLine("O atleta mais novo eh: {0}", idade2);
                    }
                }
                else
                {
                    Console.WriteLine("Ambos tem a msm idade!!!!");
                }
                if (altura1.CompareTo(altura2) != 0)
                {
                    //Console.WriteLine("Ambos tem a msm altura!!!");
                }




                Console.WriteLine("Para sair digite 2, ou qq outro número para continuar....");
                resp = int.Parse(Console.ReadLine());
            }
            while (resp != 2);

        }
    }
}