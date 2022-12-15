using AtosEntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace AtosEntityCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" +
                              "1 para criar uma pessoa \n" +
                              "2 Para alterar o nome da pessoa\n" +
                              "3 Para excluir uma pessoa\n" +
                              "4 oara excluir uma pessoa\n" +
                              "5 para consultar tudo\n" +
                              "6 parar consultar pelo ID\n");

            int op = int.Parse(Console.ReadLine());
            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Inserir nome da pessoa:");
                        Pessoa pessoa = new Pessoa();
                        pessoa.nome = Console.ReadLine();

                        Console.WriteLine("Informe email:");
                        string emailTemp = Console.ReadLine();

                        pessoa.listaEmails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        //delete-create
                        contexto.Pessoas.Add(pessoa);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? pAlterada = contexto.Pessoas.Find(id);
                        Console.WriteLine("Informe o nome correto");

                        pAlterada.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlterada);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;

                case 3:
                    try
                    {
                        Console.WriteLine("Informe ID da Pessoa");
                        int idEmail = int.Parse(Console.ReadLine());

                        Pessoa? pessoaEmail = contexto.Pessoas.Find(idEmail);

                        Console.WriteLine("Informe o novo email:");
                        string? emailTemp = Console.ReadLine();

                        pessoaEmail.listaEmails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Update(pessoaEmail);
                        contexto.SaveChanges();
                        Console.WriteLine("Alterado com sucesso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 4:
                    try
                    {
                        Console.WriteLine("Informe ID da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa? pessoa = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + pessoa.nome);
                        Console.WriteLine("E dos seus emails?");

                        foreach (Email item in pessoa.listaEmails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }
                        Console.WriteLine("1 para SIM ou outra tecla para NÃO");

                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(pessoa);
                            contexto.SaveChanges();
                            Console.WriteLine(pessoa.nome + "excluída com sucesso!!!!");
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 5:
                    try
                    {
                        List<Pessoa> lista = (from Pessoa p in contexto.Pessoas
                                              select p).Include(pessoa => pessoa.listaEmails).ToList();

                        foreach (Pessoa pessoa in lista)
                        {
                            Console.WriteLine(pessoa.nome);

                            foreach (Email email in pessoa.listaEmails)
                            {
                                Console.WriteLine("\t" + email.email);
                            }
                            Console.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 6:
                    try
                    {
                        Console.WriteLine("Informe ID da Pessoa: ");
                        int idFiltro = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.listaEmails)
                            .FirstOrDefault(pessoa => pessoa.id == idFiltro);

                        Console.WriteLine("Nome: " + p.nome);

                        if (p.listaEmails != null)
                        {
                            foreach (Email item in p.listaEmails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}