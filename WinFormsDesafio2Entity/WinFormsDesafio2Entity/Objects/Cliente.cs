using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Collections;

namespace WinFormsDesafio2Entity.Objects
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }

        public virtual ICollection<Pedido> listapedidos { get; set; }

        public Cliente()
        {
        }

        public Cliente(int idCLiente)
        {
            this.id = idCLiente;
        }

        public Cliente(int id, string nome, string cpf, string email)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }


        //    public DataTable LoadClientes()
        //    {
        //        Banco banco = new Banco();
        //        List<Cliente> listaClientes = new List<Cliente>();
        //        try
        //        {
        //            SqlConnection conn = banco.AbrirConexao();
        //            SqlCommand command = new SqlCommand("SELECT TOP (1000) [idCliente], [nome], [cpf], [email] FROM [Cliente];", conn);
        //            command.CommandType = CommandType.Text;

        //            SqlDataAdapter adapter = new SqlDataAdapter(command);

        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);

        //            //fill listaClientes
        //            listaClientes = dt.AsEnumerable().Select(line => new Cliente
        //            {
        //                //[idCliente], [nome], [cpf], [email]
        //                Id = line.Field<Int32>("idCliente"),
        //                Nome = line.Field<string>("nome"),
        //                Cpf = line.Field<string>("cpf"),
        //                Email = line.Field<string>("email"),

        //            }).ToList();

        //            return dt;
        //        }
        //        catch (Exception ex)
        //        {
        //            string errorMessage = ex.Message;
        //            return null;
        //        }
        //        finally
        //        {
        //            banco.FecharConexao();
        //        }
        //    }

        //    public bool addCustomer()
        //    {
        //        Banco banco = new Banco();

        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlTransaction transaction = conn.BeginTransaction();
        //        SqlCommand command = new SqlCommand();

        //        command.Connection = conn;
        //        command.Transaction = transaction;
        //        command.CommandType = CommandType.Text;

        //        command.CommandText = "INSERT INTO Cliente VALUES (@nome, @cpf, @email)";

        //        command.Parameters.Clear();
        //        command.Parameters.AddWithValue("@nome", Nome);
        //        command.Parameters.AddWithValue("@cpf", Cpf);
        //        command.Parameters.AddWithValue("@email", Email);

        //        try
        //        {
        //            command.ExecuteNonQuery();
        //            transaction.Commit();
        //            return true;

        //        }
        //        catch (Exception ex)
        //        {
        //            string errorMessage = ex.Message;
        //            transaction.Rollback();
        //            return false;
        //        }
        //        finally
        //        {
        //            banco.FecharConexao();
        //        }
        //    }

        //    public bool deleteCustomer()
        //    {
        //        Banco banco = new Banco();
        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlTransaction transaction = conn.BeginTransaction();
        //        SqlCommand command = new SqlCommand();

        //        command.Connection = conn;
        //        command.Transaction = transaction;
        //        command.CommandType = CommandType.Text;

        //        command.CommandText = "delete from Cliente where idCliente = @idCliente";

        //        command.Parameters.Clear();
        //        command.Parameters.AddWithValue("@idCliente", Id);

        //        try
        //        {
        //            command.ExecuteNonQuery();
        //            transaction.Commit();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            string errorMessage = ex.Message;
        //            return false;
        //        }
        //        finally
        //        {
        //            banco.FecharConexao();
        //        }
        //    }

        //    public bool updateCustomer()
        //    {
        //        Banco banco = new Banco();
        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlTransaction transaction = conn.BeginTransaction();
        //        SqlCommand command = new SqlCommand();

        //        command.Connection = conn;
        //        command.Transaction = transaction;
        //        command.CommandType = CommandType.Text;

        //        try
        //        {
        //            command.CommandText = "update Cliente set nome = @nome, cpf = @cpf, email = @email " +
        //                                  "where idCliente = @idCliente";

        //            command.Parameters.AddWithValue("@nome", Nome);
        //            command.Parameters.AddWithValue("@cpf", Cpf);
        //            command.Parameters.AddWithValue("@email", Email);
        //            command.Parameters.AddWithValue("@idCliente", Id);

        //            command.ExecuteNonQuery();
        //            transaction.Commit();

        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            string errorMessage = ex.Message;
        //            return false;
        //        }
        //        finally
        //        {
        //            banco.FecharConexao();
        //        }
        //    }

        //    public Cliente searchCustomer()
        //    {
        //        Banco banco = new Banco();
        //        try
        //        {
        //            SqlConnection conn = banco.AbrirConexao();
        //            SqlTransaction transaction = conn.BeginTransaction();

        //            SqlCommand commandId = new SqlCommand("select * from Cliente where idCliente = @id", conn);
        //            commandId.Connection = conn;
        //            commandId.Transaction = transaction;
        //            commandId.CommandType = CommandType.Text;

        //            commandId.Parameters.AddWithValue("@id", Id);

        //            //SqlCommand commandNome = new SqlCommand("select * from Cliente where nome like '%@nome%'", conn);
        //            //SqlCommand commandCpf = new SqlCommand("select * from Cliente where idCliente = '%@cpf%'", conn);

        //            SqlDataReader reader = commandId.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                if (reader.GetInt32(0) == Id)
        //                {
        //                    Nome = reader.GetString(1);
        //                    Cpf = reader.GetString(2);
        //                    Email = reader.GetString(3);

        //                    return this;
        //                }
        //            }
        //            return null;
        //        }
        //        catch (Exception ex)
        //        {
        //            string errorMessage = ex.Message;
        //            return null;
        //        }
        //        finally
        //        {
        //            banco.FecharConexao();
        //        }
        //    }
    }
}