using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSQLInjection
{
    internal class Banco
    {
        //string de conexão
        private string stringConexao = "Data Source=localhost; Initial Catalog=aula;" +
                               "User ID=usuarioAtos; password=admin123; language=Portuguese";

        private SqlConnection conn;

        private void Conexao()
        {
            conn = new SqlConnection(stringConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable ExecutaConsulta(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                //preenche dt
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
