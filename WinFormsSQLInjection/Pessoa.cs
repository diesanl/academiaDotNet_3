using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSQLInjection
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public float Peso { get; set; }


        public bool Gravar()
        {
            Banco bd = new Banco();
            SqlConnection conn = bd.AbrirConexao();

            SqlTransaction transaction = conn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into pessoas values(@nome, @peso)";
            command.Parameters.AddWithValue("@nome", Nome);
            command.Parameters.AddWithValue("@peso", Peso.ToString());
            



            //command.Parameters.Add("@nome", SqlDbType.VarChar);
            //command.Parameters.Add("@peso", SqlDbType.VarChar);
            //command.Parameters[0].Value = Nome;
            //command.Parameters[1].Value = Peso;

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }

            finally
            {
                bd.FecharConexao();
            }
        }


    }
}
