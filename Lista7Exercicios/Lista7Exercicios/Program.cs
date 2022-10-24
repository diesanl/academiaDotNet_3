using System.Reflection;

namespace Lista7Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exemplo/Exercicio Inicial

            //Cliente cli1 = new Cliente(1, "Diego", 37, "campeãoBR-22");
            //Cliente cli2 = new Cliente(2, "Maria", 65, "Brasil msm");
            //Cliente cli3 = new Cliente(3, "Fulano", 22, "Real Madrid");
            //Cliente cli4 = new Cliente(4, "Ciclano", 60, "Bayern");
            //Carro c1 = new Carro(123, "fusca", "amarelo", "vw", true, 60);
            //Carro c2 = new Carro(456, "gol", "cinza", "vw", true, 120);
            //Carro c3 = new Carro(789, "virtus", "vermelho", "vw", true, 180);
            //Carro c4 = new Carro(012, "renegade", "preta", "jeep", true, 300);

            //Aluguel alu1 = new Aluguel(cli1, c1);
            //Aluguel alu2 = new Aluguel(cli2, c2);
            //Aluguel alu3 = new Aluguel(cli3, c3);
            //Aluguel alu4 = new Aluguel(cli4, c4);


            //Console.WriteLine(alu4.cliente.nome);

            /*
             * 1 - Crie uma classe Livro que represente os dados básicos de um livro. 
                Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.
            */

            //List<Livro> livros = new List<Livro>();

            //Livro l1 = new Livro("isbn", "título", 90, 55.00, true);
            //Livro l2 = new Livro();

            //Console.WriteLine("insira os dados do 2nd livro");
            //Console.WriteLine("ISBN: ");
            //l2.setIsbn(Console.ReadLine());

            //Console.WriteLine("Título: ");
            //l2.setTitulo(Console.ReadLine());

            //Console.WriteLine("Número de páginas: ");
            //l2.setNumPaginas(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Preço: ");
            //l2.setPreco(double.Parse(Console.ReadLine()));

            //Console.WriteLine("Tem estoque? ");
            //l2.temEstoque(bool.Parse(Console.ReadLine()));


            //livros.Add(l1);
            //livros.Add(l2);

            //foreach (var livro in livros)
            //{
            //    Console.WriteLine("Livro: {0} \n  Número de páginas: {1} \n  Preço: {2} \n", livro.getTitulo(), livro.getNumPaginas(), livro.getPreco());
            //}

            /*
             * 2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para apresentar os dados.
                   Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.
             */

            //Pessoa p1 = new Pessoa("Diego", 37, 1.77, 75);

            //Console.WriteLine("Digite os dados de uma pessoa");
            //Console.WriteLine("Nome: ");
            //String nome = Console.ReadLine();

            //Console.WriteLine("Idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Altura: ");
            //double altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("Peso(kg): ");
            //int peso = int.Parse(Console.ReadLine());

            //Pessoa p2 = new Pessoa(nome, idade, altura, peso);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            /*
             3 - Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro, aluguel e cliente.
             */

            /*
             * 4 - Faça um programa que represente a arvore genealógica da tua familia. Para isso, uma classe Pessoa precisa 
             * ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.*/
            //Pessoa mae = new Pessoa("Julia", 62, 1.60, 70);
            //Pessoa pai = new Pessoa("Jhonny", 64, 1.70, 65);

            //Pessoa pessoa = new Pessoa("Diego", 37, 1.77, 75, pai, mae);

            //Console.WriteLine(pessoa + "\n" );
            ////+pessoa.pai + "\n" + pessoa.mae + "\n"

            /*
             * 5 - Identifique as classes e implemente um programa para a seguinte especificação: "O supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma 
             * quantidade em estoque. Um pedido	de um cliente é	composto de	itens, onde	cada item especifica o produto que o cliente deseja	e a	respectiva quantidade. Esse	pedido pode	ser	pago 
             * em dinheiro,	cheque ou cartão."
             */

            //Produto p1 = new Produto(5.99, 100);
            //Produto p2 = new Produto(100.00, 50);
            //Produto p3 = new Produto(1500, 25);
            //Produto p4 = new Produto(10.99, 100);
            //Produto p5 = new Produto(1.99, 10000);

            //Item i1 = new Item(p1, 2);
            //Item i2 = new Item(p2, 2);
            //Item i3 = new Item(p3, 1);
            //Item i4 = new Item(p4, 10);
            //Item i5 = new Item(p5, 10);

            //Item i6 = new Item(p1, 25);
            //Item i7 = new Item(p2, 6);
            //Item i8 = new Item(p3, 10);
            //Item i9 = new Item(p4, 30);
            //Item i10 = new Item(p5, 15);


            //List<Item> items1 = new List<Item>();
            //items1.Add(i1);
            //items1.Add(i2);
            //items1.Add(i3);
            //items1.Add(i4);
            //items1.Add(i5);

            //List<Item> items2 = new List<Item>();
            //items2.Add(i1);
            //items2.Add(i2);
            //items2.Add(i3);
            //items2.Add(i4);
            //items2.Add(i5);

            //Console.WriteLine(nameof(items1));

            //Pedido ped1 = new Pedido(items1, "Pepita de Ouro");
            //Pedido ped2 = new Pedido(items2, "Cheque");

            //Console.WriteLine();

            //for (int i = 0; i < ped1.items.Count; i++)
            //{
            //    Console.WriteLine(ped1.items[i].GetType().);
            //}
            //var teste = "my teste";
            //Console.WriteLine(nameof(teste));

            /*
             * 6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
                    void armazenaPessoa(String nome, int idade, float altura);
                    void removePessoa(String nome);
                    int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa
                    void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
             */

            //Agenda agenda = new Agenda();
            //Pessoa p1 = new Pessoa("Diego", 37, (float)1.77);
            //Pessoa p2 = new Pessoa("Maria", 21, (float)1.65);
            //Pessoa p3 = new Pessoa("João", 30, (float)1.81);
            //Pessoa p4 = new Pessoa("Abel", 19, (float)1.85);

            //agenda.armazenaPessoa(p1);
            //agenda.armazenaPessoa(p2);
            //agenda.armazenaPessoa(p3);
            //agenda.armazenaPessoa(p4);

            //agenda.imprimeAgenda();


            //while (true)
            //{
            //    int op = 0;
            //    Console.WriteLine("Escolha a opção desejada!!!");
            //    Console.WriteLine("1 - Cadastrar Contato \n" +
            //                      "2 - Pesquisar Contato \n" +
            //                      "3 - Deletar Contato \n" +
            //                      "4 - Listar contatos \n" +
            //                      "0 - SAIR;");
            //    op = int.Parse(Console.ReadLine());
            //    if (op == 0)
            //    {
            //        break;
            //    }

            //    String nome;
            //    int idade;
            //    float altura;
            //    Pessoa pessoa;

            //    switch (op)
            //    {
            //        case 1:
            //            Console.WriteLine("Digite o nome:");
            //            nome = Console.ReadLine();
            //            Console.WriteLine("Digite idade:");
            //            idade = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Digite altura:");
            //            altura = float.Parse(Console.ReadLine());

            //            pessoa = new Pessoa(nome, idade, altura);
            //            agenda.armazenaPessoa(pessoa);

            //            break;

            //        case 2:
            //            Console.WriteLine("Digite o nome:");
            //            nome = Console.ReadLine();

            //            pessoa = agenda.buscaPessoa(nome);

            //            Console.WriteLine(pessoa);
            //            break;

            //        case 3:
            //            Console.WriteLine("Digite o nome:");
            //            nome = Console.ReadLine();

            //            agenda.removePessoa(nome);
            //            break;

            //        case 4:
            //            Console.WriteLine();
            //            agenda.imprimeAgenda();
            //            break;

            //        default:
            //            Console.Clear();
            //            break;
            //    }
            //}

            /*Exemplo animais
             */
            //Console.WriteLine("Exemplo Animais");
            //Console.WriteLine("");
            //Animal a;

            //a = new Leao("Rei Leão", "masculino", "leãozinho");

            //a.Caminhar();
            //a.Dormir();
            //a.EmitirSom();

            //Console.WriteLine();


            //a = new Cachorro("Cheid", "masculino", "vira-latas");

            //a.Caminhar();
            //a.Dormir();
            //a.EmitirSom();

            /*7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), 
             * total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
                Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
                  Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
                  Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
                  Sobe : para subir um andar (não deve subir se já estiver no último andar);
                  Desce : para descer um andar (não deve descer se já estiver no térreo);
                  Encapsular todos os atributos da classe (criar os métodos set e get).
             */
            //Elevador elevador = new Elevador();
            //elevador.CapacElevador = 10;
            //Predio predio = new Predio();
            //Elevador e1 = new Elevador(10, 15);

            //e1.Descer();
            //e1.AdicionaPessoa();
            //e1.AdicionaPessoa();
            //e1.AdicionaPessoa();

            //e1.Subir();
            //e1.Subir();
            //e1.Subir();
            //e1.Subir();
            //e1.Subir();
            //e1.Subir();
            //e1.Subir();
            //e1.Subir();

            //Console.WriteLine(e1.TotalAndaresPredio);

            //Console.WriteLine(e1.AndarAtual);


            /*
             * 8 - Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle de volume permite:
                    - aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
                    - aumentar e diminuir o número do canal em uma unidade
                    - trocar para um canal indicado;
                    - consultar o valor do volume de som e o canal selecionado.
             */

            /*
             2nd exemplo de OO
             */

            int op = 0;
            Televisao tv = new Televisao();

            while (true)
            {
                Console.WriteLine("Boa tarde!!!!\n");
                Console.WriteLine("Digite 1 para ligar \nDigite 2 para desligar \nDigite 3 para verificar status (on/off) \nDigite 4 para sair \n" +
                                  "Digite 5 para aumentar o volume \nDigite 6 para diminuir o volume \nDigite 7 para canal(+) \nDigite 8 para canal(-)\n" +
                                  "Digite 9 para trocar para um canal indicado \nDigite 10 para consultar o valor do volume de som e o canal selecionado.\n");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    if (tv.Ligado)
                    {
                        Console.WriteLine("JÁ Está ligado!!!");
                    }
                    else
                    {
                        tv.Ligar();
                    }
                }
                else if (op == 2)
                {
                    if (!tv.Ligado)
                    {
                        Console.WriteLine("JÁ Está desligado");
                    }
                    else
                    {
                        tv.Desligar();
                    }
                }
                else if (op == 3)
                {
                    if (tv.Ligado)
                    {
                        Console.WriteLine("Aparelho está ligado");
                    }
                    else
                    {
                        Console.WriteLine("Aparelho está desligado");
                    }
                }
                else if (op == 4)
                {
                    break;
                }
                //"Digite 5 para aumentar o volume \n Digite 6 para diminuir o volume \n Digite 7 para canal(+) \n Digite 8 para canal(-)");
                else if ((tv.Ligado) && (op == 5))
                {
                    if (tv.Volume > 99)
                    {
                        Console.WriteLine("Não eh possível aumentar o som, pois já está no máximo que é de {0}", tv.Volume);
                    }
                    else
                    {
                        Console.WriteLine("Aumentou, volume corrente é de {0}", ++tv.Volume);
                    }
                }
                else if ((tv.Ligado) && (op == 6))
                {
                    if (tv.Volume == 0)
                    {
                        Console.WriteLine("Não eh possível diminuir o som, pois já está no mínimo que é de {0}", tv.Volume);
                    }
                    else
                    {
                        Console.WriteLine("Diminuiu, volume corrente é de {0}", --tv.Volume);
                    }
                }
                else if ((tv.Ligado) && (op == 7))
                {
                    if (tv.Canal == 100)
                    {
                        Console.WriteLine("Canal {0}", tv.Canal = 01);
                    }
                    else
                    {
                        Console.WriteLine("Canal {0}", ++tv.Canal);
                    }
                }
                else if ((tv.Ligado) && (op == 8))
                {
                    if (tv.Canal == 01)
                    {
                        Console.WriteLine("Canal {0}", tv.Canal = 100);
                    }
                    else
                    {
                        Console.WriteLine("Canal {0}", --tv.Canal);
                    }
                }

                /*- trocar para um canal indicado;
                 * - consultar o valor do volume de som e o canal selecionado.*/
                else if ((tv.Ligado) && (op == 9))
                {
                    Console.WriteLine("Digite o canal desejado?");
                    int canal = int.Parse(Console.ReadLine());
                    if ((canal != tv.Canal) && (canal > 0) && (canal <= 100))
                    {
                        tv.Canal = canal;
                        Console.WriteLine("Trocado para p canal {0}", canal);
                    }
                    else
                    {
                        if (canal < 1 || canal > 100)
                        {
                            Console.WriteLine("Digite um canal válido (Entre 1 e 100)");
                        }
                    }
                }
                else if ((tv.Ligado) && (op == 10))
                {
                    Console.WriteLine("Consulta status TV (canal & volume)");
                    Console.WriteLine("Canal atual: {0} \nVolume atual: {1}", tv.Canal, tv.Volume);
                }

            }





















        }

    }
}