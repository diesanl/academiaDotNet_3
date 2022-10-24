using System.Linq;

namespace ExemploDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tem mais formas de inicializar um dictionary
            IDictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "Maria");
            dict1.Add(2, "Paulo");
            dict1.Add(3, "Pedro");
            dict1.Add(4, "Diego");

            foreach (KeyValuePair<int, String> item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //2nd vez
            //containsValue soh existe na implementação, não na interface
            Dictionary<int, string> dictFrutas = new Dictionary<int, string>()
            {
                {1, "Banana" }, {2, "Laranja" }, {3, "Manga" }, {4, "Abacate" }, {5, "Maçã" }
            };

            foreach (KeyValuePair<int, string> item in dictFrutas)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            //devolve booleano
            bool v = dictFrutas.ContainsValue("Melancia");

            //Exception
            //Console.WriteLine(dictFrutas[6]);

            string resultado;
            if (dictFrutas.TryGetValue(60, out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Não foi possível achar a chave especificada ");
            }

            //criando dictionary ordenado

            SortedDictionary<string, int> dict3 = new SortedDictionary<string, int>();

            dict3.Add("zebra", 5);
            dict3.Add("cachorro", 2);
            dict3.Add("gato", 9);
            dict3.Add("pardal", 4);
            dict3.Add("C#", 100);

            //verifica se gato existe no dict3
            if (dict3.ContainsKey("gato"))
            {
                Console.WriteLine("Tem gato aih...");
            }

            //verifica se tem zebra
            if (dict3.ContainsKey("zebra"))
            {
                Console.WriteLine("Deu zebra aih....");
            }

            //verifica se tem C# e se tiver pega o valor

            if (dict3.TryGetValue("C#", out int y))
            {
                Console.WriteLine(y);
            }

            if (dict3.TryGetValue("teste", out int z))
            {
                Console.WriteLine(z);
            }

            //imprime SortedDictionary em ordem alfabética
            foreach (KeyValuePair<string, int> item in dict3)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}