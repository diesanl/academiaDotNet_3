using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsADONet
{
    /*
        create login usuario with password='senha';
        create user usuario from login usuario;
        exec sp_addrolemember 'DB_DATAREADER', 'usuario';
        exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

    create database aula;

use aula;

create table programadores  (
id INT NOT NULL IDENTITY,
  nome VARCHAR(45) NOT NULL,
  linguagem VARCHAR(45) NOT NULL,
  banco VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (id)
);


     */
    public class Banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=aula; User ID=sa; password=1234;language=Portuguese";

        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
