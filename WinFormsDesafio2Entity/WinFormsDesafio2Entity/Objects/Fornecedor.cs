using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsDesafio2Entity.Objects
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public string cnpj { get; set; }

        public string email { get; set; }

        public virtual ICollection<Produto> listaProdutos { get; set; }

        //public DataTable LoadFornecedores()
        //{
        //    Banco banco = new Banco();
        //    List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        //    try
        //    {
        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlCommand command = new SqlCommand("SELECT TOP (1000) [idFornecedor], [descricao], [cnpj], [email] FROM [Fornecedor]", conn);
        //        command.CommandType = CommandType.Text;

        //        SqlDataAdapter adapter = new SqlDataAdapter(command);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        //Fill listaFornecedores
        //        listaFornecedores = dt.AsEnumerable().Select(line => new Fornecedor
        //        {
        //            Id = line.Field<Int32>("idFornecedor"),
        //            Descricao = line.Field<string>("descricao"),
        //            Cnpj = line.Field<string>("cnpj"),
        //            Email = line.Field<string>("email")
        //        }).ToList();

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = ex.Message;
        //        return null;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }
        //}

        //public bool addSupplier()
        //{
        //    Banco banco = new Banco();

        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "INSERT INTO Fornecedor VALUES (@descricao, @cnpj, @email)";

        //    command.Parameters.Clear();
        //    command.Parameters.AddWithValue("@descricao", Descricao);
        //    command.Parameters.AddWithValue("@cnpj", Cnpj);
        //    command.Parameters.AddWithValue("@email", Email);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        transaction.Commit();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = ex.Message;
        //        return false;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }
        //}

        //public bool deleteSupplier()
        //{
        //    Banco banco = new Banco();
        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "delete from Fornecedor where idFornecedor = @idFornecedor";

        //    command.Parameters.Clear();
        //    command.Parameters.AddWithValue("@idFornecedor", Id);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        transaction.Commit();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        string errorMessage = ex.Message;
        //        return false;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }
        //}

        //public bool updateSupplier()
        //{
        //    Banco banco = new Banco();

        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "update Fornecedor set descricao = @descricao, cnpj = @cnpj, email = @email " +
        //                          "where idFornecedor = @idFornecedor";

        //    command.Parameters.Clear();
        //    command.Parameters.AddWithValue("@descricao", Descricao);
        //    command.Parameters.AddWithValue("@cnpj", Cnpj);
        //    command.Parameters.AddWithValue("@email", Email);
        //    command.Parameters.AddWithValue("@idFornecedor", Id);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        transaction.Commit();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        string errorMessage = ex.Message;
        //        return false;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }
        //}

        //public Fornecedor searchSupplier()
        //{
        //    Banco banco = new Banco();
        //    try
        //    {
        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlTransaction transaction = conn.BeginTransaction();

        //        SqlCommand command = new SqlCommand("select * from Fornecedor where idFornecedor = @idFornecedor", conn);
        //        command.Connection = conn;
        //        command.Transaction = transaction;
        //        command.CommandType = CommandType.Text;

        //        //command.Parameters.Clear();
        //        command.Parameters.AddWithValue("@idFornecedor", Id);

        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            if (reader.GetInt32(0) == Id)
        //            {
        //                Descricao = reader.GetString(1);
        //                Cnpj = reader.GetString(2);
        //                Email = reader.GetString(3);

        //                return this;
        //            }
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = ex.Message;
        //        return null;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }

        //}



    }
}
