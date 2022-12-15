using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsADONet1
{
    public class Empregado
    {

        public string Nome { get; set; }
        public string IdGerente { get; set; }

        public string Funcao { get; set; }

        public int IdDepartamento { get; set; }

        public string DataAdmissao { get; set; }

        public int Salario { get; set; }

        public int Comissao { get; set; }
        public Empregado(string nome, string idGerente, string funcao, int idDepartamento, string dataAdmissao, int salario, int comissao)
        {
            Nome = nome;
            IdGerente = idGerente;
            Funcao = funcao;
            IdDepartamento = idDepartamento;
            DataAdmissao = dataAdmissao;
            Salario = salario;
            Comissao = comissao;
        }

        public bool GravarFuncionario()
        {
            Banco banco = new Banco();

            System.Data.SqlClient.SqlConnection conn = banco.abrirConexao();

            System.Data.SqlClient.SqlTransaction transaction = conn.BeginTransaction();

            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.Transaction = transaction;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into empregado values(@nome, @idGerente, @funcao, @idDepartamento, @dataAdmissao, @salario,@comissao)";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@IdGerente", SqlDbType.VarChar);
            command.Parameters.Add("@Funcao", SqlDbType.VarChar);
            command.Parameters.Add("@IdDepartamento", SqlDbType.Int);
            command.Parameters.Add("@DataAdmissao", SqlDbType.VarChar);
            command.Parameters.Add("@Salario", SqlDbType.Int);
            command.Parameters.Add("@Comissao", SqlDbType.Int);

            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = IdGerente;
            command.Parameters[2].Value = Funcao;
            command.Parameters[3].Value = IdDepartamento;
            command.Parameters[4].Value = DataAdmissao;
            command.Parameters[5].Value = Salario;
            command.Parameters[6].Value = Comissao;

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

            return false;
        }



    }
}
