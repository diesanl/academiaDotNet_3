using System.Security.Authentication;

namespace ExerciciosOOClassesNativas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
                Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
                que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
                exibir a lista ordenada.
             */

            //string resp = "";
            //List<string> listaNomes = new List<string>();

            //while (!resp.Equals("-1"))
            //{
            //    Console.WriteLine("Digite um nome válido (1 nome + 1 sobrenome) ou pressione -1 para SAIR");
            //    resp = Console.ReadLine();

            //    string[] nomes = resp.Split(" ");

            //    if ((nomes.Length >= 2) && (!listaNomes.Contains(resp.ToUpper())))
            //    {
            //        listaNomes.Add(resp.ToUpper());
            //    }
            //    else
            //    {
            //      Console.WriteLine("O nome já existe na lista!!!!");
            //    }
            //}

            //var count = 0;
            //foreach (var nome in listaNomes)
            //{
            //    Console.WriteLine(nome + " na posição {0}", count);
            //    count++;
            //}

            /*2. Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam sorteados
                randomicamente. O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
                deve exibir os números populados na lista.
             */

            //Random random = new Random();
            //List<int> listNumbers = new List<int>();

            //int resp = 0;
            //int qtde = 0;

            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Digite qtde de números q deseja sortear...");
            //        qtde = int.Parse(Console.ReadLine());
            //    } while (qtde <= 0);

            //    if (qtde > 0)
            //    {
            //        for (int i = 0; i < qtde; i++)
            //        {
            //            listNumbers.Add(random.Next(1001));
            //        }

            //        Console.WriteLine("Números sorteados!!!");
            //        foreach (var number in listNumbers)
            //        {
            //            Console.WriteLine(number);
            //        }
            //    }

            //    listNumbers.Clear();

            //    Console.WriteLine("Pressione 1 para CONTINUAR \n ou 2 para SAIR");
            //    resp = int.Parse(Console.ReadLine());


            //} while (!resp.Equals(2));


            //List<int> listNumbers = new List<int>();
            //Random random = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    listNumbers.Add(random.Next(0, 10));
            //}


            //int count = 0;
            //foreach (var number in listNumbers)
            //{
            //    //this shows the 1st occurrence of the item on a list
            //    Console.WriteLine(number + " posicao {0}", listNumbers.IndexOf(number));
            //    count++;
            //}

            /*3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
                    Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
                    o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
                    lista, o programa deve listar os domínios de emails cadastrados no programa.

                    Menu
                    1 - Cadastrar email
                    2 - Listar 
                    3 - Sair 
                    Opção:
             */

            //int resp = 0;
            //bool isEmpty = false;

            //List<string> emailList = new List<string>();
            //List<string> domainList = new List<string>();

            //do
            //{
            //    Console.WriteLine("Menu \n" +
            //                      "1 - Cadastrar email \n" +
            //                      "2 - Listar \n" +
            //                      "3 - Sair\n" +
            //                      "Opção:");
            //    resp = int.Parse(Console.ReadLine());

            //    switch (resp)
            //    {
            //        case 1:
            //            Console.WriteLine("1 - Cadastrar email \n");
            //            Console.WriteLine("Digite um email no formato user@domínio");
            //            String email = Console.ReadLine().ToLower();

            //            isEmpty = !emailList.Any();

            //            if ((isEmpty) || ((emailList.Count > 0) && (!emailList.Contains(email))))
            //            {

            //                //string[] strings = email.Split("@");
            //                if (email.Contains("@"))
            //                {
            //                    emailList.Add(email);
            //                    Console.WriteLine("Email cadastrado c sucesso!!! \n");
            //                }
            //                else // check with regex, whenever able to do so...
            //                {
            //                    Console.WriteLine("Email inválido!!!! \n");
            //                }
            //            }

            //            else if (emailList.Contains(email))
            //            {
            //                Console.WriteLine("Email jah existe na lista!!! \n");
            //            }
            //            break;

            //        case 2:
            //            Console.WriteLine("2 - Listar \n");
            //            isEmpty = !emailList.Any();

            //            if (!isEmpty)
            //            {
            //                foreach (var itemEmail in emailList)
            //                {
            //                    Console.WriteLine("Email: " + itemEmail + " -> Domínio: " + itemEmail.Substring(itemEmail.IndexOf("@")));
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Lista vazia!!!");
            //            }
            //            Console.WriteLine();
            //            break;

            //        case 3:
            //            Console.WriteLine("3 - Sair\n");

            //            break;


            //        default:
            //            Console.WriteLine("Opção inválida!!! \n");
            //            break;
            //    }

            //} while (resp != 3);


            /*4. Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
                    completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve 
                    ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
                    que a opção listar for acionada, a listagem deve ser exibida de forma ordenada. No processo de 
                    remoção, o usuário entra com o nome da criptomoeda que deseja remover. Caso o programa a encontre,
                    deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
                    ao usuário que nome não foi encontrado.

                    Menu 
                    1 - Cadastrar criptomoeda 
                    2 - Listar criptomoedas
                    3 - Remover criptomoeda
                    4 - Sair
                    Opção: 
             */

            int resp = 0;
            bool isEmpty = false;

            List<String> criptoList = new List<String>();

            do
            {
                Console.WriteLine("Menu \n" +
                                  "1 - Cadastrar Criptomoeda\n" +
                                  "2 - Listar Criptomoedas\n" +
                                  "3 - Remover Criptomoeda\n" +
                                  "4 - Atualizar Criptomoeda\n" +
                                  "5 - Sair \n" +
                                  "Opção:");
                resp = int.Parse(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        Console.WriteLine("1 - Cadastrar Criptomoeda\n");
                        Console.WriteLine("Digite a cripto que deseja cadastrar");
                        String cripto = Console.ReadLine().ToUpper();

                        isEmpty = !criptoList.Any();

                        if ((isEmpty) || ((criptoList.Count > 0) && (!criptoList.Contains(cripto))))
                        {
                            criptoList.Add(cripto);
                        }
                        else
                        {
                            Console.WriteLine("Criptomoeda já cadastrada na lista!!!\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("2 - Listar Criptomoedas\n");
                        isEmpty = !criptoList.Any();
                        if (isEmpty)
                        {
                            Console.WriteLine("Lista vazia!!! \n");
                        }
                        else
                        {
                            criptoList.Sort();
                            foreach (var itemCripto in criptoList)
                            {
                                Console.WriteLine(criptoList.IndexOf(itemCripto) + "-> " + itemCripto);
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("3 - Remover Criptomoeda\n");
                        Console.WriteLine("Digite qual cripto deseja remover....");
                        String selectedCripto = Console.ReadLine();
                        String foundCripto = "";
                        int indexToRemove = -1;

                        isEmpty = !criptoList.Any();
                        if (!isEmpty)
                        {
                            indexToRemove = criptoList.IndexOf(selectedCripto);
                        }

                        if (indexToRemove != -1)
                            break;

                    case 4:
                        Console.WriteLine("4 - Atualizar Criptomoeda\n");
                        break;

                    case 5:
                        Console.WriteLine("5 - Sair \n");
                        break;

                    default:
                        Console.WriteLine("Digite um valor válido para continuar \n!!!");
                        break;
                }

            } while (resp != 5);


        }
    }
}