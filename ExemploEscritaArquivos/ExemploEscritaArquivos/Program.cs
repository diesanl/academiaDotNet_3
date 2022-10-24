using System.Runtime.ConstrainedExecution;
using System;

namespace ExemploEscritaArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exemplos escrita de arquivo
            //StreamWriter sw = new StreamWriter(@"C:\Users\diesa\Desktop\atosUfn.txt"); or
            //StreamWriter sw = new StreamWriter("C:\\Users\\diesa\\Desktop\\atosUfn.txt");
            //StreamWriter sw = new StreamWriter("C:\\Users\\diesa\\OneDrive\\Área de Trabalho\\atosUfn.txt"); //C:\Users\diesa\OneDrive "C:\Users\diesa\OneDrive\Área de Trabalho"
            //try
            //{
            //    sw.WriteLine("Segundou");
            //    sw.WriteLine("Aula Atos-UFN");
            //    sw.WriteLine("17-10-22");
            //}
            //finally
            //{
            //    sw.Close();
            //}


            //Nome, idade, sexo, email, telefone, estado civil, casa própria ou não, valor aluguel
            //Gerar arquivo utilizando o ; como caractere delimitador para cada uma dessas infos
            //Tds infos ficam na msm linha
            //apenas nome, idade e casa própria são campos obrigatórios

            //StreamWriter sw;
            //sw = new StreamWriter("C:\\Users\\diesa\\OneDrive\\Área de Trabalho\\exemploArquivo.txt");

            //try
            //{
            //    //StreamWriter sw = new StreamWriter(@"C:\Users\diesa\OneDrive\Área de Trabalho\exemploArquivo.txt");
            //    Console.WriteLine("Digite o nome");
            //    String nome = Console.ReadLine();

            //    Console.WriteLine("Digite idade");
            //    int idade = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite sexo");
            //    String sexo = Console.ReadLine();

            //    Console.WriteLine("Digite email");
            //    String email = Console.ReadLine();

            //    Console.WriteLine("Digite telefone");
            //    String telefone = Console.ReadLine();

            //    Console.WriteLine("Digite estado civil");
            //    String estadoCivil = Console.ReadLine();

            //    Console.WriteLine("Possui casa própria? (1-SIM, 2-NÃO)");
            //    int casa = int.Parse(Console.ReadLine());

            //    double aluguel = 0;

            //    if (casa == 2)
            //    {
            //        Console.WriteLine("Digite o valor do aluguel");
            //        aluguel = double.Parse(Console.ReadLine());
            //    }

            //sw.Write(nome + ";" + idade + ";" + sexo + ";" + email + ";" + telefone + ";" + estadoCivil + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel + ";" + Environment.NewLine);
            //    sw.Write("\n");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    sw.Close();
            //}

            //---------Exemplos leitura de arquivo----------------------

            //StreamReader reader = new StreamReader(@"C:\Users\diesa\OneDrive\Área de Trabalho\exemploArquivo.txt");
            //try
            //{

            //    string linha = "";
            //    Console.WriteLine("-------------------------------------");
            //    linha = reader.ReadLine();

            //    while (linha != null)
            //    {
            //        Console.WriteLine(linha);

            //        linha = reader.ReadLine();
            //    }
            //    Console.WriteLine("-------------------------------------");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //    throw;
            //}
            //finally
            //{
            //    reader.Close();
            //}

            //----------------Exercício---------------------------//
            //receber inputs do user,
            //verificar se o arquivo existe e
            //ler o arquivo, caso exista, para criar um novo com os dados anteriores e os novos inseridos


            StreamReader reader;
            StreamWriter writer;

            List<string> registros = new List<String>();

            Console.WriteLine("Digite o nome");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sexo");
            String sexo = Console.ReadLine();

            Console.WriteLine("Digite email");
            String email = Console.ReadLine();

            Console.WriteLine("Digite telefone");
            String telefone = Console.ReadLine();

            Console.WriteLine("Digite estado civil");
            String estadoCivil = Console.ReadLine();

            Console.WriteLine("Possui casa própria? (1-SIM, 2-NÃO)");
            int casa = int.Parse(Console.ReadLine());

            double aluguel = 0;

            if (casa == 2)
            {
                Console.WriteLine("Digite o valor do aluguel");
                aluguel = double.Parse(Console.ReadLine());
            }

            if (File.Exists(@"C:\Users\diesa\OneDrive\Área de Trabalho\exercicioArquivo.txt"))
            {
                try
                {
                    reader = new StreamReader(@"C:\Users\diesa\OneDrive\Área de Trabalho\exercicioArquivo.txt");
                    string linha = reader.ReadLine();

                    //pega os registros existentes no file e joga na lista de registros 
                    //desse jeito o arquivo eh atualizado e, n sobrescrito
                    while (linha != null)
                    {
                        registros.Add(linha);
                        linha = reader.ReadLine();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                //add os inputs numa lista de registros (stream à ser escrito no file => kd linha eh 1 registro)
                registros.Add(nome + ";" + idade + ";" + sexo + ";" + email + ";" + telefone + ";" + estadoCivil + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel + ";");

                writer = new StreamWriter(@"C:\Users\diesa\OneDrive\Área de Trabalho\exercicioArquivo.txt");

                registros.ForEach(reg => writer.WriteLine(reg)); //writer.WriteLine(reg)

                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }









        }
    }
}