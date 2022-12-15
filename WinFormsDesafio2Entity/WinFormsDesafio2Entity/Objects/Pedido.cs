using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;

namespace WinFormsDesafio2Entity.Objects
{
    public class Pedido
    {
        public int id { get; set; }

        public virtual Cliente cliente { get; set; }


        public DateTime data { get; set; }

        public virtual ICollection<Produto> listaProdutos { get; set; }


        //public DataTable LoadPedidos()
        //{

        //    Banco banco = new Banco();
        //    List<Pedido> ListaPedidos = new List<Pedido>();

        //    try
        //    {
        //        SqlConnection conn = banco.AbrirConexao();
        //        SqlCommand command = new SqlCommand("SELECT TOP (1000) [idPedido], [idCliente], [data] FROM [Pedido]", conn);
        //        command.CommandType = CommandType.Text;

        //        SqlDataAdapter adapter = new SqlDataAdapter(command);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        //fill listaPedidos
        //        //funcionou
        //        //foreach (DataRow line in dt.Rows)
        //        //{
        //        //    Id = Convert.ToInt32(line["IdPedido"]);
        //        //    Cliente.Id = Convert.ToInt32(line["IdCliente"]);
        //        //    Data = Convert.ToDateTime(line["data"]);

        //        //    ListaPedidos.Add(new Pedido(Id, Cliente.Id, Data));
        //        //}

        //        ListaPedidos = dt.AsEnumerable().Select(line => new Pedido
        //        {
        //            Id = Convert.ToInt32(line["idPedido"]),
        //            Cliente = new Cliente(Convert.ToInt32(line["idCliente"])),
        //            Data = Convert.ToDateTime(line["data"])
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

        //public bool addOrder()
        //{
        //    Banco banco = new Banco();

        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "INSERT INTO Pedido VALUES @idCliente";

        //    command.Parameters.AddWithValue("@idCliente", Cliente.Id);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        transaction.Commit();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = ex.Message;
        //        transaction.Rollback();
        //        return false;
        //    }
        //    finally
        //    {
        //        banco.FecharConexao();
        //    }
        //}

        //public bool deleteOrder()
        //{
        //    Banco banco = new Banco();
        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    command.CommandText = "delete from Pedido where idPedido = @idPedido";

        //    command.Parameters.AddWithValue("@idPedido", Id);

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

        //public bool updateOrder()
        //{
        //    Banco banco = new Banco();

        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();
        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    try
        //    {
        //        command.CommandText = "update Pedido set idCliente = @idCliente " +
        //                              "where idPedido = @idPedido";

        //        command.Parameters.AddWithValue("@idPedido", Id);

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
        //    finally { transaction.Rollback(); }
        //}

        //public Pedido searchOrder()
        //{
        //    Banco banco = new Banco();
        //    SqlConnection conn = banco.AbrirConexao();
        //    SqlTransaction transaction = conn.BeginTransaction();

        //    SqlCommand command = new SqlCommand();

        //    command.Connection = conn;
        //    command.Transaction = transaction;
        //    command.CommandType = CommandType.Text;

        //    try
        //    {
        //        command.CommandText = "select * from Pedido where " +
        //                              "idPedido = @idPedido";
        //        command.Parameters.AddWithValue("@idPedido", Id);

        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            if (reader.GetInt32(0) == Id)
        //            {
        //                Cliente.Id = reader.GetInt32(1);

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
