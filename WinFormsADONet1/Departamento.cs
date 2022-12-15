using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsADONet1
{
    internal class Departamento
    {
        public Departamento(string nome, string localizacao, string orcamento)
        {
            Nome = nome;
            Localizacao = localizacao;
            Orcamento = orcamento;
        }

        public string Nome { get; set; }
        public string Localizacao { get; set; }

        public string Orcamento { get; set; }


        public bool GravarDepartamento()
        {
            Banco banco = new Banco();
            System.Data.SqlClient.SqlConnection conn = banco.abrirConexao();

            System.Data.SqlClient.SqlTransaction transaction = conn.BeginTransaction();

            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = CommandType.Text;



            command.CommandText = "insert into departamento values(@nome, @localizacao, @orcamento)";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Localizacao", SqlDbType.VarChar);
            command.Parameters.Add("@Orcamento", SqlDbType.VarChar);

            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Localizacao;
            command.Parameters[2].Value = Orcamento;

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }


        }
    }
}
