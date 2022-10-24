using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lista1Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            /*
            Console.WriteLine("Calcula média aritmética!!!");
            Console.WriteLine("Digite 1st número: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 2nd número: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("A média dos números é: " +  (firstNumber+secondNumber) / 2);
            */

            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            /*
            Console.WriteLine("Calcula média aritmética!!!");
            Console.WriteLine("Digite 1st número: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 2nd número: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 3rd número: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 4th número: ");
            double fourthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("A média dos números é: " + (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4);
            */

            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.
            /*
            Console.WriteLine("Troca valores de variáveis A e B!!!");
            Console.WriteLine("Digite valor de var A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de var B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Troca!!");

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Valor de A = " + a + " \nValor de B = " + b);
            */

            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            /*
            Console.WriteLine("Imprime data!!!");
            Console.WriteLine("Digite a data (DDMMAAAA): ");
            String data = Console.ReadLine();
            String dia = data.Substring(0,2);
            String mes= data.Substring(2,2);
            String anoFourDigits = data.Substring(4,4);
            String anoTwoDigits = data.Substring(6,2);

            Console.WriteLine("Formato BR: " + dia + "/"+mes+"/"+anoFourDigits);
            Console.WriteLine("Formato AAAAMMDD: " + anoFourDigits + mes + dia);
            Console.WriteLine("Formato AAMMDD: " +  anoTwoDigits + mes + dia);
            */

            /*5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            consumido para percorrê-la (medido em l).
             */

            /*
            Console.WriteLine("Troca valores de variáveis A e B!!!");
            Console.WriteLine("Digite KM percorrida: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite qtde(l) de combustível gasto: ");
            int combustivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Calcula!!");

            double consumoMedio = km/combustivel;
            Console.WriteLine("o consumo médio é de: "+ consumoMedio + "km/l");
            */

            /*6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            de IPI (única) a ser acrescentada. */
            /*
            Console.WriteLine("Parafusos A e B!!!");
            Console.WriteLine("Digite código do parafuso A: ");
            String codA = Console.ReadLine();

            Console.WriteLine("Digite qtde(peças) do parafuso A: ");
            int qtdeA = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite valor(unidade) do parafuso A: ");
            double valorA = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite valor percentual do IPI (única) do parafuso A a ser acrescentada: ");
            double ipiA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite código do parafuso B: ");
            String codB = Console.ReadLine();

            Console.WriteLine("Digite qtde(peças) do parafuso B: ");
            int qtdeB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor(unidade) do parafuso B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor percentual do IPI (única) do parafuso B a ser acrescentada: ");
            double ipiB = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando....!!!");
            Console.ReadKey();
            double valorTotalA = (qtdeA * valorA);
            valorTotalA += ((ipiA/100) * valorTotalA);

            double valorTotalB = qtdeB * valorB;
            valorTotalB += ((ipiB / 100) * valorTotalB);


            Console.WriteLine("Imprimir dados !!!");
            Console.WriteLine("Parafuso A:");
            Console.WriteLine("Código:..............." + codA + "\n"+
                              "Qtde de peças:........" + qtdeA + "\n" +
                              "Valor Unitário:......." + valorA + "\n" +
                              "IPI(%):..............." + ipiA + "\n" +
                              "Valor total:.........." + valorTotalA);
            
            Console.WriteLine("Parafuso B:");
            Console.WriteLine("Código:..............." + codB + "\n"+
                              "Qtde de peças:........" + qtdeB + "\n" +
                              "Valor Unitário:......." + valorB + "\n" +
                              "IPI(%):..............." + ipiB + "\n" +
                              "Valor total:.........." + valorTotalB);
            */

            /*
             * 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
                o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
                Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.*/

            /*
            Console.WriteLine("Digite código do Vendedor: ");
            String codVendedor = Console.ReadLine();

            Console.WriteLine("Digite seu salário fixo: ");
            double salario= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu total de vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor percentual de ganho sobre vendas: ");
            double percentualSobreVenda= double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando....!!!");
            double salarioTotal = salario + (percentualSobreVenda/100 * (totalVendas));
            Console.ReadKey();

            Console.WriteLine("Imprimir dados !!!");
            Console.WriteLine("Código:......................................." + codVendedor + "\n" +
                              "Valor total de vendas:........................" + totalVendas + "\n" +
                              "ganho sobre total de vendas(%):..............." + percentualSobreVenda + "\n" +
                              "Salário Total (fixo + (%) vendas):............" + salarioTotal);
            */

            /*8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F=(9*C+160)/5.
             */
            /*
            Console.WriteLine("Conversor de temperaturas: Celsius -> Fahrenheit");
            Console.WriteLine("Digite temperatura (ºC): ");
            double tempCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando....!!!");
            double tempFahrenheit = (9 * tempCelsius +160) /5;
            Console.ReadKey();

            Console.WriteLine("Temperatura (ºF): " + tempFahrenheit);
            */

            /*9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
                do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
                Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
                se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
                Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
                da entrada e das duas prestações, de acordo com as regras acima. 
                Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
                conseqüente pagamento dos boletos das duas prestações.
             */
            /*
            Console.WriteLine("Calcula entrada e prestações...");
            Console.WriteLine("Digite valor total da mercadoria/compra (R$): ");
            String valorCompra = Console.ReadLine();

            double valorEntrada;
            double valorParcela1;

            int valor = (int)(int.Parse(valorCompra) % 3);
            Console.WriteLine(valor);
            */

            /*10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
                para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
                realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
                notas de menor valor fossem distribuídas em número mínimo possível. 
                Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
                três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
                Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
                de acordo com o critério da “distribuição ótima”.
             */
            /*
            Console.WriteLine("Distribuição Ótima...");
            Console.WriteLine("Digite valor (R$): ");
            double valor = double.Parse(Console.ReadLine());
            int[] bills = { 200, 100, 50, 20, 10, 5, 2 };
            int notaDuzentosReais= 0, notaCemReais = 0, notaCinquentaReais = 0, notaVinteReais = 0, notaDezReais = 0, notaCincoReais = 0, notaDoisReais = 0, notaUmReal = 0;

            double rest = valor;
            while (rest != 0)
            {
                if (rest >= 200)
                {
                    notaDuzentosReais = (int)rest / 200;
                    rest = rest % 200;
                }
                else if (rest >= 100)
                {
                    notaCemReais = (int)rest / 100;
                    rest = rest % 100;
                }
                else if (rest >= 50)
                {
                    notaCinquentaReais = (int)rest / 50;
                    rest = (rest % 50);
                }
                else if (rest >= 20)
                {
                    notaVinteReais = (int)rest / 20;
                    rest = rest % 20;
                }
                else if (rest >= 10)
                {
                    notaDezReais = (int)rest / 10;
                    rest %= 10;
                }
                else if (rest >= 5)
                {
                    notaCincoReais = (int)rest / 5;
                    rest %= 5;
                }
                else if (rest >= 2)
                {
                    notaDoisReais = (int)rest / 2;
                    rest %= 2;
                }
                else
                {
                    notaUmReal = (int)rest;
                }
            }

            Console.WriteLine("Imprimir dados !!!");
            Console.WriteLine("Notas de 200:..............." + notaDuzentosReais + "\n" +
                              "Notas de 100:..............." + notaCemReais + "\n" +
                              "Notas de 50:................" + notaCinquentaReais+ "\n" +
                              "Notas de 20:................" + notaVinteReais+ "\n" +
                              "Notas de 10:................" + notaDezReais+ "\n" +
                              "Notas de 5:................." + notaCincoReais+ "\n" +
                              "Notas de 2:................." + notaDoisReais+ "\n" +
                              "Notas de 1:................." + notaUmReal);
            */

            /*11) Escreva um algoritmo para ler o número de eleitores de um município, 
                o número de votos brancos, nulos e válidos. 
                Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
             */

            /*
            Console.WriteLine("Calcula % de votos...");
            Console.WriteLine("Digite o total de eleitores do município: ");
            int totalEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de votos em branco: ");
            int votosEmBranco = int.Parse(Console.ReadLine());
            double percentualVB = (double)votosEmBranco / totalEleitores;

            Console.WriteLine("Digite o total de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());
            double percentualVN = (double)votosNulos / totalEleitores;

            Console.WriteLine("Digite o total de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());
            double percentualVV = (double)votosValidos / totalEleitores;

            int naoVotaram = totalEleitores - (votosEmBranco + votosNulos + votosValidos);
            double percentualNV = (double)naoVotaram / totalEleitores;

            Console.WriteLine("Imprimir dados (%)!!!");
            Console.WriteLine("Votos em branco:.......... " + (percentualVB * 100).ToString("F") + "%" + "\n" +
                              "Votos nulos:.............. " + (percentualVN * 100).ToString("F") + "%" + "\n" +
                              "Votos válidos:............ " + (percentualVV * 100).ToString("F") + "%" + "\n" +
                              "Não votaram:.............. " + (percentualNV * 100).ToString("F") + "%");
            */

            /*12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
                marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
                dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

                Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

                Média do consumo = Total quilometragem/ quantidade de combustível gasto

                Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
             */

            /*
            Console.WriteLine("Calcular lucro do dia de um taxista");
            double odometroInicio = 0, odometroFim = 0, totalKm = 0, mediaConsumo = 0, qtdeCombustivel = 0, precoCombustivel = 6.90, valorRecebido = 0, lucroDia = 0;

            Console.WriteLine("Digite marcação inicial do odômetro:");
            odometroInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite marcação final do odômetro:");
            odometroFim = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantidade de combustível gasto (L):");
            qtdeCombustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor total (R$) recebido:");
            valorRecebido = double.Parse(Console.ReadLine());


            Console.WriteLine("Calculando.....");

            totalKm = odometroFim - odometroInicio;
            mediaConsumo = totalKm / qtdeCombustivel;
            lucroDia = valorRecebido - (qtdeCombustivel * precoCombustivel);

            Console.WriteLine("Imprimir dados (%)!!!");
            Console.WriteLine("Total quilometragem:........... " + (totalKm).ToString("F") + " KM rodados" + "\n" +
                              "Média do consumo:.............. " + (mediaConsumo).ToString("F") + " KM/L" + "\n" +
                              "Lucro do dia:.................. " + "R$ " + (lucroDia).ToString("F") + "\n");
            */

            /*13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
                preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
                vendidas pelo vendedor, calcule e mostre: o salário do empregado.
            */


            Console.WriteLine("Calcular salário total de Vendedor");
            double precoFinalBike = 0, salarioMinimo = 0, comissao = 0.15, precoCustoBike = 0, qtdeBikesVendidas = 0, salarioFinal = 0;


            Console.WriteLine("Digite valor do salário mínimo:");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite preço de custo de cada bike:");
            precoCustoBike = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas bikes foram vendidas:");
            qtdeBikesVendidas = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando.....");
            precoFinalBike = precoCustoBike + (precoCustoBike / 2);
            comissao = comissao * precoCustoBike * qtdeBikesVendidas;
            salarioFinal = 2 * salarioMinimo + comissao;

            Console.WriteLine("Imprimir dados (%)!!!");
            Console.WriteLine("salário mínimo:......................... " + "R$ " + (salarioMinimo).ToString("F") + "\n" +
                              "preço de custo (por bike):.............. " + "R$ " + (precoCustoBike).ToString("F") + "\n" +
                              "preço de venda (por bike):.............. " + "R$ " + (precoFinalBike).ToString("F") + "\n" +
                              "valor total da venda:................... " + "R$ " + (precoFinalBike * qtdeBikesVendidas).ToString("F") + "\n" +
                              "qtde bikes vendidas:.................... " + (int)qtdeBikesVendidas + "\n" +
                              "salário Total do empregado:............. " + "R$ " + (salarioFinal).ToString("F") + "\n");
























        }
    }
}