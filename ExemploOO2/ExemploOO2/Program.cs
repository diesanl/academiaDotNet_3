namespace ExemploOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("Diego", 37));
            pessoas.Add(new Pessoa("Jefferson", 25));
            pessoas.Add(new Pessoa("Miriam", 45));
            pessoas.Add(new Pessoa("Ricardo", 40));

            //forma anterior
            foreach (var p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }

            //Console.ReadKey();


            Console.WriteLine("Lista não ordenada!!!");
            ListaNaoOrdenada(pessoas);

            Console.WriteLine("Lista Ordenada por Nome");
            ListaOrdenada(pessoas);

            Console.WriteLine("Lista Ordenada por Idade");
            ListaOrdenadaIdade(pessoas);

            Console.WriteLine("Inserir e imprimir lista");
            ListaInserirItemNaPosicao(pessoas);

            Console.WriteLine("Lista pessoas c idade < 45");
            ListaLocalizaPessoaMaisJovem(pessoas);
        }

        private static void ListaInserirItemNaPosicao(List<Pessoa> pessoas)
        {
            Console.WriteLine("Inserindo n pessoas nas posições 1 e 3 da lista");
            pessoas.Insert(1, new Pessoa() { Nome = "Bob Dylan", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "Jimmi Page", Idade = 81 });

            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
            Console.ReadKey();

        }

        private static void ListaLocalizaPessoaMaisJovem(List<Pessoa> pessoas)
        {
            List<Pessoa> jovens = pessoas.FindAll(delegate (Pessoa p)
            {
                return p.Idade < 45;
            });

            jovens.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
            Console.ReadKey();
        }

        private static void ListaOrdenadaIdade(List<Pessoa> pessoas)
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Idade.CompareTo(p2.Idade);
            }
            );

            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
            Console.ReadKey();
        }

        private static void ListaOrdenada(List<Pessoa> pessoas)
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            }
            );

            pessoas.ForEach(delegate (Pessoa p) { Console.WriteLine(p.Nome + " " + p.Idade); });
            Console.ReadKey();
        }

        private static void ListaNaoOrdenada(List<Pessoa> pessoas)
        {
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            }
            );
            Console.ReadKey();
        }



    }
}