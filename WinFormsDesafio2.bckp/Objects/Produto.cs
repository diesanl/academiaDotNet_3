using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDesafio2.DataBase;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WinFormsDesafio2.Objects
{
    internal class Produto
    {
        public Produto()
        {
            Fornecedor fornecedor = new Fornecedor();
        }

        public Produto(int id, string descricao, double valor, int idFornecedor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Fornecedor = new Fornecedor(idFornecedor);
        }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public DataTable LoadProdutos()
        {
            Banco banco = new Banco();
            List<Produto> listaProdutos = new List<Produto>();

            try
            {
                SqlConnection conn = banco.AbrirConexao();
                SqlCommand command = new SqlCommand("SELECT TOP (1000) [idProduto], [descricao], [valor], [idFornecedor] FROM [Produto]", conn);
                command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //Fill listaProdutos
                //[idProduto], [descricao], [valor], [idFornecedor]
                listaProdutos = dt.AsEnumerable().Select(line => new Produto
                {

                    Id = line.Field<Int32>("idProduto"),
                    Descricao = line.Field<string>("descricao"),
                    Valor = (double)line.Field<decimal>("valor"),
                    Fornecedor = new Fornecedor(Id = line.Field<Int32>("idFornecedor"))

                }).ToList();

                return dt;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                return null;

            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool addProduct()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.AbrirConexao();
            SqlTransaction transaction = conn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Produto VALUES " +
                                  "(@descricao, @valor, @idFornecedor)";

            command.Parameters.AddWithValue("@descricao", Descricao);
            command.Parameters.AddWithValue("@valor", Valor);
            command.Parameters.AddWithValue("@idFornecedor", Fornecedor.Id);

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                string errorMessage = ex.Message;
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool deleteProduct()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.AbrirConexao();
            SqlTransaction transaction = conn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Produto where idProduto = @idProduto";

            command.Parameters.AddWithValue("@idProduto", Id);

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                string errorMessage = ex.Message;
                return false;
            }
            finally { banco.FecharConexao(); }
        }

        public bool updateProduct()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.AbrirConexao();
            SqlTransaction transaction = conn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = CommandType.Text;

            try
            {
                command.CommandText = "update Produto set descricao = @descricao, valor = @valor, " +
                                      "idFornecedor = @idFornecedor where idProduto = @idProduto";

                command.Parameters.AddWithValue("@descricao", Descricao);
                command.Parameters.AddWithValue("@valor", Valor);
                command.Parameters.AddWithValue("@idFornecedor", Fornecedor.Id);
                command.Parameters.AddWithValue("@idProduto", Id);

                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                string errorMessage = ex.Message;
                return false;
            }
            finally { banco.FecharConexao(); }
        }

        public Produto searchProduct()
        {
            Banco banco = new Banco();
            try
            {
                SqlConnection conn = banco.AbrirConexao();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;

                command.CommandText = "select * from Produto where idProduto = @idProduto";
                command.Parameters.AddWithValue("@idProduto", Id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == Id)
                    {
                        Descricao = reader.GetString(1);
                        Valor = (double)reader.GetDecimal(2);
                        int idFornecedor = reader.GetInt32(3);

                        return new Produto(Id, Descricao, Valor, idFornecedor);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                return null;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
