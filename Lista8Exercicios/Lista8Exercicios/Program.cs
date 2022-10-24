using System.Globalization;
using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lista8Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
                O programa deverá informar o nome do personagem que possuir o maior poder.

                Regras que deverão ser seguidas para a implementação do algoritmo:

                É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
                A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
                Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
                irá receber o nome e o poder de um personagem
             */

            //Dictionary<int, Personagem> dict = new Dictionary<int, Personagem>();

            //SortedList<int, Personagem> sortedList = new SortedList<int, Personagem>();

            //List<Personagem> listaPersonagens = new List<Personagem>();

            //string nome = "";
            //int poder = 0;

            //Console.WriteLine("Informe nome (string) e poder (0-10) de 3 personagens");

            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para Incluir os personagens \nDigite 2 para Listar (necessário Incluir antes) \nDigite 3 para apresentar o personagem mais forte \nDigite 0 para sair");
            //    int op = int.Parse(Console.ReadLine());
            //    if (op == 1)
            //    {
            //        for (int i = 1; i < 4; i++)
            //        {
            //            Console.WriteLine("Digite nome do {0}º personagem:", i);
            //            nome = Console.ReadLine();
            //            Console.WriteLine("Digite o poder do {0}º personagem:", i);
            //            poder = int.Parse(Console.ReadLine());
            //            listaPersonagens.Add(new Personagem(nome, poder));
            //        }
            //    }
            //    else if (op == 2)
            //    {
            //        if (listaPersonagens.Count > 0)
            //        {
            //            foreach (var item in listaPersonagens)
            //            {
            //                Console.WriteLine(item.ToString());
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não há oq imprimir. Preencha a lista antes!!!!");
            //        }
            //    }
            //    else if (op == 3)
            //    {
            //        if (listaPersonagens.Count > 1)
            //        {
            //            //listaPersonagens.Sort();
            //            listaPersonagens.Add(new Personagem("Piccolo", 5));
            //            listaPersonagens.Add(new Personagem("Vegetta", 9));
            //            listaPersonagens.Add(new Personagem("Gohan", 7));
            //            listaPersonagens.Add(new Personagem("Goku", 10));

            //            listaPersonagens = listaPersonagens.OrderBy(p => p.Poder).ToList();
            //            //listaPersonagens.Sort((p1, p2) => p2.Poder.CompareTo(p1.Poder));
            //            IOrderedEnumerable<Personagem> oerderedEnumerable = listaPersonagens.OrderByDescending(p => p.Poder);
            //            Console.WriteLine(oerderedEnumerable.ElementAt(0));
            //        }
            //    }
            //    else if (op == 0)
            //    {
            //        break;
            //    }
            //}

            /*
             * 2) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
                    O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

                    Regras que deverão ser seguidas para a implementação do programa:

                    Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
                    Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
                    É obrigatório criar uma classe para representar o Animal.
                    A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
                    A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
             */

            //List<Animal> listAnimais = new List<Animal>();

            //string nome = "";
            //string tipo = "";
            //int poder = 0;

            //Console.WriteLine("Informe nome (string) e o \n" +
            //                  "tipo (Cachorro, Gato e Peixe) de 5 animais");

            //int op = 0;

            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para Incluir os 5 animais \nDigite 2 para listar os animais inseridos \n" +
            //                      "Digite 3 para limpar lista \nDigite 0 para sair");
            //    op = int.Parse(Console.ReadLine());

            //    if (op == 1)
            //    {
            //        for (int i = 1; i <= 5; i++)
            //        {
            //            Console.WriteLine("Digite o nome do animal:");
            //            nome = Console.ReadLine();
            //            Console.WriteLine("Digite o tipo do animal");
            //            tipo = Console.ReadLine().ToLower();
            //            if ((!tipo.Equals("cachorro")) && (!tipo.Equals("gato")) && (!tipo.Equals("peixe")))
            //            {
            //                Console.WriteLine("Digite um tipo válido (Cachorro, Gato ou Peixe)");
            //                //tipo = Console.ReadLine();
            //                i--;
            //            }
            //            else
            //            {
            //                listAnimais.Add(new Animal(nome, tipo));
            //                Console.WriteLine("{0} adicionado na lista\n", nome);
            //            }
            //        }
            //    }
            //    if (op == 2)
            //    {
            //        if (listAnimais.Count > 0)
            //        {
            //            //print tds os tipos de animais da lista
            //            listAnimais.ForEach(a => Console.WriteLine("{0}", a.Tipo));
            //            //print bool se tipo == cachorro
            //            listAnimais.ForEach(a => Console.WriteLine("{0}", a.Tipo.Equals("cachorro")));

            //            //listar qtde de cada animal na lista
            //            Console.WriteLine("Cachorros: {0}", listAnimais.Count(a => a.Tipo.Equals("cachorro")));
            //            Console.WriteLine("Gatos: {0}", listAnimais.Count(a => a.Tipo.Equals("gato")));
            //            Console.WriteLine("Peixes: {0}", listAnimais.Count(a => a.Tipo.Equals("peixe")));
            //        }
            //    }
            //    if (op == 3)
            //    {
            //        listAnimais.Clear();
            //        Console.WriteLine("Lista foi limpa");
            //    }
            //    if (op == 4)
            //    {

            //    }
            //    else if (op == 0)
            //    {
            //        break;
            //    }
            //}

            /*
             * 3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
                uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
                um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os métodos de acesso
                (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
                terceiro que constrói um asteroide com posição x e posição y. 
                O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
                asteróides da lista.
             */

            //List<Asteroide> listAsteroides = new List<Asteroide>() { new Asteroide(300, 40, 10, 5, 5), new Asteroide(150, 200, 10, 3, 4), new Asteroide(52, 12, 9, 2, 2),
            //                                                        new Asteroide(5, 100, 10, 1, 2), new Asteroide(38, 200, 1, 4, 3), new Asteroide(30, 40, 10, 5, 5)};


            //Console.WriteLine("Informe qtos asteroides deseja cadastrar:");
            //int qtdeAsteroides = int.Parse(Console.ReadLine());

            //int op = 0, posX = 0, posY = 0, tamanho = 0, velocidade = 0, energia = 0;

            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para Incluir \nDigite 2 para listar os asteroides\n" +
            //                      "Digite 3 para limpar lista \nDigite 0 para sair");
            //    op = int.Parse(Console.ReadLine());

            //    if (op == 1)
            //    {
            //        for (int i = 1; i <= qtdeAsteroides; i++)
            //        {
            //            Console.WriteLine("Informe a posição x do asteroide:");
            //            posX = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Informe a posição y do asteroide:");
            //            posY = int.Parse((Console.ReadLine()));

            //            Console.WriteLine("tamanho do asteroide (1 a 10):");
            //            tamanho = int.Parse(Console.ReadLine());

            //            Console.WriteLine("velocidade do asteroide (1 a 5):");
            //            velocidade = int.Parse(Console.ReadLine());

            //            Console.WriteLine("energia (1 a 5):");
            //            energia = int.Parse(Console.ReadLine());
            //        }

            //    }
            //    else if (op == 2)
            //    {
            //        listAsteroides.ForEach(a => Console.WriteLine(a));
            //    }
            //    else if (op == 0)
            //    {
            //        break;
            //    }
            //}

            /*
             * 4) Crie uma classe para representar um item de cenário, com os atributos privados de:
                * descrição (string), data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
                * altura (float). Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
                todos dados de um item de cenário. Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa 
                em C# para testar a classe criada.
             */

            //ItemCenario itemCenario = new ItemCenario("objA", new DateTime(2022, 10, 01), 3.50f);
            //List<ItemCenario> itensCenario = new List<ItemCenario>();

            //for (int i = 0; i < 10; i++)
            //{

            //    int ano = new Random().Next(2000, 2023);
            //    int mes = new Random().Next(1, 13);
            //    int dia = new Random().Next(01, 28);
            //    float altura = new Random().Next(1, 20);
            //    DateTime data = new DateTime(ano, mes, dia);
            //    ItemCenario item = new ItemCenario("obj" + i + "", data, altura);
            //    itensCenario.Add(item);
            //}

            ////DateTime dateTime = new DateTime(2022, 10, 1);
            ////Console.WriteLine(dateTime.Month);
            ////Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month));

            ////DateTime dt1 = DateTime.Now;
            ////TimeSpan timeSpan = dt1 - dateTime;

            ////DateTime dateTime1 = DateTimeOffset.FromUnixTimeSeconds((long)timeSpan.TotalSeconds).DateTime;


            //Console.WriteLine(itemCenario.mostraIdadeItem());
            //Console.WriteLine(itemCenario);

            //itensCenario.ForEach(item => Console.WriteLine(item.mostraIdadeItem()));

            /*
             * 5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
                tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
                um método para exibir um objeto (x,y).
                Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
                os objetos da lista.
             */

            //List<ObjetoPlanoCartesiano> objs = new List<ObjetoPlanoCartesiano>();

            //for (int i = 0; i < 10; i++)
            //{
            //    ObjetoPlanoCartesiano opc = new ObjetoPlanoCartesiano();
            //    objs.Add(opc);
            //}

            //objs.ForEach(obj => Console.WriteLine(obj));


            /*6) Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário (double), a data de entrada no banco (String), seu RG (String) 
             * e um valor booleano que indique se o funcionário ainda está ativa na empresa no momento ou se já foi mandado embora. Você deve criar alguns métodos de acordo com sua necessidade. 
             * Além deles, crie um método bonifica que aumenta o salario do funcionário de acordo com o parâmetro passado como argumento. Crie, também, um método demite, que não recebe parâmetro 
             * algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui. Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e 
             * consultar todos os funcionários cadastratos.Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho". Haverá duas implementações 
             * da classe Funcionario chamada de Gerente e Operador. Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada 
             * pelo funcionário */

            /*Funcionario() abstrata
            _nome
            _departamento
            _salario
            _dataEntrada
            _rg
            _possuiVinculo
            +Bonifica(arg)
            +Demite()
            ListaFuncionarios
            menu interativo (1-Inserir, 2-Consultar, 3-Sair)
            Metodo abstrato (classe abstrata) Executa trabalho
            2 impl nas classes Gerente e operador mostrando função desempenhada
            */

            List<Funcionario> funcionarios = new List<Funcionario>();
            string nome = "", data = "", departamento = "", rg = "";
            double salario;
            Funcionario funcionario;

            int op = 0;

            while (true)
            {
                Console.WriteLine("Digite a operação que deseja executar");
                Console.WriteLine("1- Inserir;\n 2- Consultar Funcionário;\n 3- Listar Funcionários;\n 0- SAIR");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("-----Inserir Funcionário-----");
                        Console.WriteLine("Qual cargo do funcionário? 1- Gerente; 2- Operador;");
                        int cargo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nome:");
                        nome = Console.ReadLine();

                        Console.WriteLine("Departamento:");
                        departamento = Console.ReadLine();

                        Console.WriteLine("Salário:");
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Data de entrada (yyyy/mm/dd):");
                        data = Console.ReadLine();
                        //DateTime dt = DateTime.Parse(data);
                        DateTime dt = Convert.ToDateTime(data);

                        Console.WriteLine("RG:");
                        rg = Console.ReadLine();
                        if (cargo == 1)
                        {
                            funcionarios.Add(new Gerente(nome, departamento, salario, dt, rg));
                        }
                        else if (cargo == 2)
                        {
                            funcionarios.Add(new Operador(nome, departamento, salario, dt, rg));
                        }

                        Console.WriteLine("Funcionário de cargo {0} cadastrado com sucesso!!!", funcionarios.Last().GetType());
                        break;

                    case 2:
                        Console.WriteLine("-----Consultar Funcionário-----");
                        break;

                    case 3:
                        Console.WriteLine("-----Listar Funcionários-----");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }
            }













        }
    }
}