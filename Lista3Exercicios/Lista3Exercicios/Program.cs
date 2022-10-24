using System.IO.IsolatedStorage;
using System.Text.RegularExpressions;

namespace Lista3Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
                (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
                Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

                Exemplo:
                Digite um número inteiro positivo: -8
                Valor incorreto!
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
             */

            //int end, count, beginning = 1;
            //String stringResp = "";


            //Console.WriteLine("Digite um número inteiro positivo");
            //end = int.Parse(Console.ReadLine());

            //while (end <= 0)
            //{
            //    Console.WriteLine("Valor Incorreto!");
            //    end = int.Parse(Console.ReadLine());
            //}

            //for (int i = beginning; i < end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        //Console.Write(" {0}", i);
            //        if (String.IsNullOrEmpty(stringResp))
            //        {
            //            stringResp += i;
            //        }
            //        else
            //        {
            //            stringResp += ", " + i;
            //        }
            //    }
            //}

            //if (stringResp.EndsWith(','))
            //{
            //    stringResp = stringResp.Remove(stringResp.Length - 2, 1);
            //}

            //Console.WriteLine("Número digitado {0}: ", end);
            //Console.WriteLine("Números inteiros pares entre {0} e {1}: {2}", beginning, end, stringResp);

            /*2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
                informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
                Exemplo:
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
 
                Deseja informar outro número (s/n)? S
 
                Digite um número inteiro positivo: 12
                Numero digitado: 20
                Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
                Deseja informar outro número (s/n)? N 
             */

            //int end, count, beginning = 1;
            //String stringResp = "", resp = "";

            //do
            //{

            //    Console.WriteLine("Digite um número inteiro positivo:");
            //    end = int.Parse(Console.ReadLine());


            //    while (end <= 0)
            //    {
            //        Console.WriteLine("Valor Incorreto!");
            //        end = int.Parse(Console.ReadLine());
            //    }

            //    for (int i = beginning; i < end; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            //Console.Write(" {0}", i);
            //            if (String.IsNullOrEmpty(stringResp))
            //            {
            //                stringResp += i;
            //            }
            //            else if (end - i != 2)
            //            {
            //                stringResp += ", " + i;
            //            }
            //            else
            //            {
            //                stringResp += ", " + i + ".";
            //            }
            //        }
            //    }

            //    if (stringResp.EndsWith(','))
            //    {
            //        stringResp = stringResp.Remove(stringResp.Length - 2, 1);
            //    }

            //    Console.WriteLine("Número digitado {0}: ", end);
            //    Console.WriteLine("Números inteiros pares entre {0} e {1}: {2}", beginning, end, stringResp);
            //    Console.WriteLine("\nDeseja informar outro número (s/n)? \n");
            //    resp =  Console.ReadLine().ToLower();
            //} while (!resp.ToLower().Equals("n"));


            /*3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
                Se o usuário digitar 0 o programa em VS deve parar. 
                Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
             */

            //int num, count = 0, beginning = 1;
            //String msg = "", resp = "";

            //do
            //{
            //    Console.WriteLine("Digite um número: ");
            //    num = int.Parse(Console.ReadLine());

            //    if (num % 2 == 0)
            //    {
            //        msg += "Número par ";
            //    }
            //    else
            //    {
            //        msg += "Número ímpar ";
            //    }


            //    for (int i = num; i > 0; i--)
            //    {
            //        if (num % i == 0)
            //        {
            //            count++;
            //        }
            //    }

            //    if (count == 2)
            //    {
            //        msg += "e primo";
            //    }
            //    else
            //    {
            //        msg += "e não é primo";
            //    }
            //    Console.WriteLine(msg);

            //    msg = "";
            //    count = 0;
            //} while (!num.Equals(0));

            /*4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
                Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
                Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
                Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
                escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
                de votos em branco. 
             */
            //String resp = "";
            //int countJoao = 0, countZeca = 0, countBranco = 0, countNull = 0;
            //do
            //{
            //    Console.WriteLine("Digite seu voto: ");
            //    resp = Console.ReadLine();

            //    if (resp.ToUpper().Equals("JOAO"))
            //    {
            //        countJoao++;
            //    }
            //    else if (resp.ToUpper().Equals("ZECA"))
            //    {
            //        countZeca++;
            //    }
            //    else if (resp.ToUpper().Equals("BRANCO"))
            //    {
            //        countBranco++;
            //    }
            //    else if (!resp.ToUpper().Equals("FIM"))
            //    {
            //        countNull++;
            //    }

            //} while (!resp.ToUpper().Equals("FIM"));

            //Console.WriteLine("Número de votos para João: {0}", countJoao);
            //Console.WriteLine("Número de votos para Zeca: {0}", countZeca);
            //Console.WriteLine("Número de votos em Branco: {0}", countBranco);
            //Console.WriteLine("Número de votos Nulos: {0}", countNull);


            /*
             */
            //String resp = "";
            //int countJoao = 0, countZeca = 0, countBranco = 0, countNull = 0, countVotos = 0;
            //do
            //{
            //    Console.WriteLine("Digite seu voto: ");
            //    resp = Console.ReadLine();

            //    if (resp.ToUpper().Equals("JOAO"))
            //    {
            //        countJoao++;
            //        countVotos++;
            //    }
            //    else if (resp.ToUpper().Equals("ZECA"))
            //    {
            //        countZeca++;
            //        countVotos++;
            //    }
            //    else if (resp.ToUpper().Equals("BRANCO"))
            //    {
            //        countBranco++;
            //        countVotos++;
            //    }
            //    else if (!resp.ToUpper().Equals("FIM"))
            //    {
            //        countNull++;
            //        countVotos++;
            //    }

            //} while (!resp.ToUpper().Equals("FIM"));

            //Console.WriteLine("Número de votos para João: {0}", countJoao);
            //Console.WriteLine("Número de votos para Zeca: {0}", countZeca);
            //Console.WriteLine("Número de votos em Branco: {0}", countBranco);
            //Console.WriteLine("Número de votos Nulos: {0}", countNull);
            //Console.WriteLine("Número TOTAL de votos : {0}", countVotos);

            /*6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
                ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
                Ao final, mostre a idade digitada.
             */

            //String resp = "";
            //int idade;
            //do
            //{
            //    Console.WriteLine("Digite sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (idade <= 0)
            //    {
            //        Console.WriteLine("Idade inválida");
            //    }
            //} while (idade <= 0);

            //Console.WriteLine("A idade digitada foi {0}", idade);

            /*7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. A cada solicitação, teste se o usuário informou um valor válido. 
                Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), informe que ele está incorreto e saia do programa em VS. 
                Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), informe que está errada e saia. Se estiver 
                correta, solicite o salário. Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. Se estiver correto, mostre todos os valores lidos.
             */

            //String nome = "";
            //int idade = 0;
            //double salario = 0;
            //bool valido = true;


            //do
            //{
            //    Console.WriteLine("Digite seu nome: ");
            //    nome = Console.ReadLine();

            //    char[] letters = nome.ToCharArray();
            //    bool isNumeric = Regex.IsMatch(nome, "[0-9]");

            //    //nome.Any(char.IsDigit) == true
            //    if ((nome.Trim() == "") || isNumeric)
            //    {
            //        Console.WriteLine("Valor de nome inválido!!!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Digite a idade:");
            //        idade = int.Parse(Console.ReadLine());

            //        if (idade <= 0)
            //        {
            //            Console.WriteLine("Valor da idade inválido");
            //            break;
            //        }
            //    }
            //} while (true);

            /*8. Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
                Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
             */

            //String nome = "", resp = "";
            //int num = 0;
            //double salario = 0;

            //do
            //{
            //    Console.WriteLine("Digite um número inteiro: ");
            //    resp = Console.ReadLine();

            //    if (!resp.Contains("."))
            //    {
            //        if (int.Parse(resp) % 2 == 0)
            //        {
            //            Console.WriteLine("Par");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ímpar");
            //        }
            //    }


            //} while (resp.Contains("."));


            /*
             * 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
                o zoológico num determinado dia, imprimindo:
                Quantas pessoas tem entre 1 e 3 filhos.
                Quantas pessoas tem entre 4 e 7 filhos.
                Quantas pessoas tem mais de 8 filhos.
                Quantas pessoas não tem filhos.
             */

            //String nome = "", resp = "";
            //int[] numFilhos = new int[3];
            //int num = 0, count = numFilhos.Length - 1;
            //double salario = 0;

            //do
            //{
            //    Console.WriteLine("Digite qtde de filhos de cada uma das pessoas: ");
            //    numFilhos[count] = int.Parse(Console.ReadLine());
            //    count--;

            //} while (count >= 0);

            //Console.WriteLine("Qtde de filhos de cada casal: ");

            //count = 0;
            //foreach (var qtde in numFilhos)
            //{
            //    Console.Write("Pos " + count + " -> " + qtde + ", ");
            //    count++;
            //}

            /*10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            Número de pessoas do sexo masculino.
            Número de pessoas do sexo feminino.
            Número de pessoas com idade inferior a 30 anos.
            Número de pessoas com idade superior a 60 anos.
            Média de idade das mulheres.
             */

            //String nome = "", resp = "";
            //int num = 0, countMasc = 0, countFem = 0, countMenorTrinta = 0, countMaiorSessenta = 0, mediaIdadeFem = 0, tamArray = 5;
            //String[] nomes = new String[tamArray];
            //String[] generos = new String[tamArray];
            //int[] idades = new int[tamArray];
            //double salario = 0;

            //Console.WriteLine("Digite nome, gênero e idade de {0} pessoas: ", tamArray);
            //do
            //{
            //    for (int i = 0; i < tamArray; i++)
            //    {
            //        Console.WriteLine("Digite o nome da posição {0}", i);
            //        nomes[i] = Console.ReadLine();

            //        Console.WriteLine("Digite gênero da(o) {0}: ", nomes[i]);
            //        generos[i] = Console.ReadLine().ToUpper();

            //        Console.WriteLine("Digite idade da(o) {0}: ", nomes[i]);
            //        idades[i] = int.Parse(Console.ReadLine());

            //    }

            //    for (int i = 0; i < tamArray; i++)
            //    {
            //        Console.WriteLine("{0} é do sexo {1} e tem {2} anos de idade!!! \n", nomes[i], generos[i], idades[i]);

            //        if (generos[i].Substring(0, 1).Equals("M"))
            //        {
            //            countMasc++;
            //        }
            //        else
            //        {
            //            countFem++;
            //            mediaIdadeFem += (int)idades[i];
            //        }

            //        if (idades[i] < 30)
            //        {
            //            countMenorTrinta++;
            //        }
            //        else if (idades[i] > 60)
            //        {
            //            countMaiorSessenta++;
            //        }
            //    }

            //    mediaIdadeFem /= countFem;

            //    Console.WriteLine("Número de pessoas do sexo masculino: {0}", countMasc);
            //    Console.WriteLine("Número de pessoas do sexo feminino: {0}", countFem);
            //    Console.WriteLine("Número de pessoas com idade inferior a 30 anos: {0}", countMenorTrinta);
            //    Console.WriteLine("Número de pessoas com idade superior a 60 anos: {0}", countMaiorSessenta);
            //    Console.WriteLine("A média de idade das mulheres é de: {0} anos", mediaIdadeFem);

            //    Console.WriteLine("Deseja sair? (S/N)");
            //    resp = Console.ReadLine();

            //    countMasc = 0; countFem = 0; mediaIdadeFem = 0; countMenorTrinta = 0; countMaiorSessenta = 0;

            //} while (!resp.ToLower().Equals("s"));


            /*11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
                a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
             */


            //int tamArray = 100, count = 0;

            //double[] notas = new double[tamArray];
            //double biggest = 0, smallest = 10, avrge = 0, resp = 0;

            //Console.WriteLine("Digite as notas dos X alunos: ");

            //while (!resp.Equals(-1))
            //{
            //    resp = double.Parse(Console.ReadLine());
            //    if (resp == -1) { continue; }
            //    notas[count] = resp;
            //    count++;
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    if (notas[i] > biggest)
            //    {
            //        biggest = notas[i];
            //    }
            //    else if (notas[i] < smallest)
            //    {
            //        smallest = notas[i];
            //    }
            //}
            //avrge = notas.Sum() / count;

            //Console.WriteLine("nota mais alta............{0}", biggest);
            //Console.WriteLine("nota mais baixa...........{0}", smallest);
            //Console.WriteLine("média aritmética..........{0}", Math.Round(avrge, 2));
            //Console.WriteLine("quantidade de alunos......{0}", count);

            /*
             * 12. Apresentar o total da soma dos cem primeiros números inteiros.
             */

            //int tamArray = 100, count = 0, sum = 0;

            //double[] notas = new double[tamArray];
            //double biggest = 0, smallest = 10, avrge = 0, resp = 0;

            //Console.WriteLine("Imprime o total da soma dos cem primeiros números inteiros.: ");

            //while (count <=100)
            //{
            //    sum += count;
            //    count++;
            //}

            //Console.WriteLine(sum);

            /*13. Elaborar um programa que apresente o somatório dos valores pares existentes 
                entre 1 e 500.
             */

            //int sum = 0;

            //Console.WriteLine("Soma dos valores pares entre 1 e 500");

            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine(sum);

            /*14. Mostrar as potências de 2 variando de 0 a 10.
             */
            //int tamArray = 100, count = 0, sum = 0;

            //double[] notas = new double[tamArray];
            //double biggest = 0, smallest = 10, avrge = 0, resp = 0;

            //Console.WriteLine("Imprime o total da soma dos cem primeiros números inteiros.: ");

            //while (count <=100)
            //{
            //    sum += count;
            //    count++;
            //}

            //Console.WriteLine(sum);

            /* 14. Mostrar as potências de 2 variando de 0 a 10.
             */

            //int sum = 0;

            //Console.WriteLine("Mostrar as potências de 2 variando de 0 a 10");

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(Math.Pow(2, i));
            //}

            /*15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
                ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
                Considerar nota 7,0 como mínima para aprovação.
             */

            //int tamArray = 4, count = 0;

            //double[] notas = new double[tamArray];
            //double[] weights = { 2, 1, 2, 4 };
            //double[] prodNotas = new double[tamArray];
            //double mediaPonderada = 0, avrge = 0, resp = 0;

            //Console.WriteLine("Digite as {0} notas: ", tamArray);
            //Console.WriteLine("Digite -1 para SAIR.....");

            //while (!resp.Equals(-1))
            //{
            //    resp = double.Parse(Console.ReadLine());
            //    if ((resp == -1) || (count == (tamArray))) { break; ; }
            //    notas[count] = resp;
            //    count++;
            //}

            //for (int i = 0; i < tamArray; i++)
            //{
            //    prodNotas[i] = notas[i] * weights[i];
            //}

            //mediaPonderada = prodNotas.Sum() / weights.Sum();

            //if (mediaPonderada >= 7)
            //{
            //    Console.WriteLine("Aprovado!!! Nota...{0}", mediaPonderada);
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado!!! Nota...{0}", mediaPonderada);
            //}

            /*16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
                multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
                (N*3; N*3*3; N*3*3*3; etc).
             */
            //TODO

            //double result = 0, avrge = 0;
            //int resp = 0;

            //Console.WriteLine("Digite um número entre 1 e 50: ");
            //resp = int.Parse(Console.ReadLine());
            //int aux = 0;

            //while (resp < 250)
            //{
            //    aux = resp;
            //    resp *= 3;

            //    Console.WriteLine(aux);
            //}


            /*17. Apresentar os quadrados dos números inteiros de 15 a 200.
             */

            //int sum = 0;

            //Console.WriteLine("17. Apresentar os quadrados dos números inteiros de 15 a 200.");

            //for (int i = 15; i <= 200; i++)
            //{
            //    Console.WriteLine(Math.Pow(i, 2));
            //}

            /*18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
                elevada a um expoente qualquer, ou seja, NM.
            */

            //double result = 0, baseExp = 0, exp = 0, resp = 0;

            //do
            //{
            //    Console.WriteLine("Calcula potência de uma base qualquer elevada a um expoente......");
            //    Console.WriteLine("Digite a base desejada: ");
            //    baseExp = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o expoente desejado: ");
            //    exp = double.Parse(Console.ReadLine());

            //    result = Math.Pow(baseExp, exp);

            //    Console.WriteLine("O número {0} elevado a {1} potência é igual a: {2}", baseExp, exp, result);

            //    Console.WriteLine("digite -1 para sair ou qq outro número para continuar.....");
            //    resp = double.Parse(Console.ReadLine());

            //} while (!resp.Equals(-1));


            /* 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário 
             * e número de filhos. A prefeitura deseja saber: 
 
                a) média do salário da população;
                b) média do número de filhos;
                c) maior salário;
                d) percentual de pessoas com salário até R$ 100,00.
                O final da leitura de dados se dará com a entrada de um salário negativo.
             */

            //int tamArray = 0, countSalarioAteCem = 0;
            //double maior = 0, menor = 0, salarioAvrge = 0, qtdeFilhosAvrge = 0, percSalarios = 0;
            //double[] salarios;
            //double[] qtdeFilhos;
            //bool leave;

            //do
            //{
            //    Console.WriteLine("Deseja informar acerca de qtas pessoas? ");
            //    tamArray = int.Parse(Console.ReadLine());

            //    salarios = new double[tamArray];
            //    qtdeFilhos = new double[tamArray];
            //    leave = false;

            //    for (int i = 0; i < tamArray; i++)
            //    {
            //        Console.WriteLine("Digite o valor do salário da {0}ª pessoa: ", i + 1);
            //        salarios[i] = double.Parse(Console.ReadLine());

            //        if (salarios[i] < 0)
            //        {
            //            leave = true;
            //            break;
            //        }
            //        Console.WriteLine("Digite a qtde de filhos da {0}ª pessoa: ", i + 1);
            //        qtdeFilhos[i] = double.Parse(Console.ReadLine());

            //    }
            //    foreach (double salario in salarios)
            //    {
            //        if (salario <= 100)
            //        {
            //            countSalarioAteCem++;
            //        }
            //        if (salario > maior)
            //        {
            //            maior = salario;
            //        }
            //    }
            //    salarioAvrge = salarios.Sum() / tamArray;
            //    qtdeFilhosAvrge = qtdeFilhos.Sum() / tamArray;
            //    percSalarios = (countSalarioAteCem * 100) / tamArray;
            //    //                percSalarios = Math.Round(percSalarios, 2);

            //    Console.WriteLine("Média salarial: {0}", Math.Round(salarioAvrge, 2));
            //    Console.WriteLine("Média de filhos: {0}", Math.Round(qtdeFilhosAvrge, 2));
            //    Console.WriteLine("Maior salário: {0}", maior);
            //    Console.WriteLine("Percentual de pessoas c salário até R$ 100,00: {0}%", Math.Round(percSalarios, 2));

            //    countSalarioAteCem = 0;
            //    maior = 0; menor = 0; salarioAvrge = 0; qtdeFilhosAvrge = 0; percSalarios = 0;

            //} while (!leave);

            //TODO
            /*20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
                certa região, a qual coletou os seguintes dados referentes a cada habitante para 
                serem analisados:
                - sexo (masculino e feminino)
                - cor dos olhos (azuis, verdes ou castanhos)
                - cor dos cabelos ( louros, castanhos, pretos)
                - idade 
 
                Faça um algoritmo que determine e escreva: 
 
                - a maior idade dos habitantes
                - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
                e que tenham olhos verdes e cabelos louros.
                O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
             */



        }
    }
}