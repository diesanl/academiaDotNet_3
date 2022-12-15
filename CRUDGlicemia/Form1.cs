using System.Configuration;
using System.Data.SqlClient;

namespace CRUDGlicemia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListViewMedidasGlicemia();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                MessageBox.Show(listViewMedidasGlicemia.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listViewMedidasGlicemia.SelectedItems[0].Text);

                string sql = "delete from MedidaGlicemia where idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@idMedidaGlicemia ", idMedidaGlicemia);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar!!! " + ex.Message, "Alert");
                throw;
            }
            finally
            {
                conn.Close();
                LoadListViewMedidasGlicemia();
            }
        }

        private void LoadListViewMedidasGlicemia()
        {
            //MessageBox.Show("oi");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                //string sql = "select * from MedidaGlicemia";
                string sql = "select m.idMedidaGlicemia, m.valorGlicemia, m.dataMedida, p.nome, m.idPaciente " +
                             "from MedidaGlicemia as m inner join Paciente as p on m.idPaciente = p.idPaciente";
                SqlCommand command = new SqlCommand(sql, conn);
                listViewMedidasGlicemia.Items.Clear();

                SqlDataReader reader = command.ExecuteReader();
                //command.

                //lines of result query
                int count = 0;

                while (reader.Read())
                {
                    listViewMedidasGlicemia.Items.Add(reader["idMedidaGlicemia"].ToString());
                    listViewMedidasGlicemia.Items[count].SubItems.Add(reader["valorGlicemia"].ToString());
                    listViewMedidasGlicemia.Items[count].SubItems.Add(reader["dataMedida"].ToString());
                    listViewMedidasGlicemia.Items[count].SubItems.Add(reader["nome"].ToString());
                    listViewMedidasGlicemia.Items[count].SubItems.Add(reader["idPaciente"].ToString());
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conex�o com o DB" + ex.ToString(), "Alerta");
            }
            finally
            {
                conn.Close();

                buttonConectar.Enabled = false;
            }
        }

        private void listViewMedidasGlicemia_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeletar.Enabled = true;
            buttonCadastrar.Enabled = false;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            panelCampos.Enabled = true;
            //pega �ltimo id da tabela e soma 1
            //textBoxIdGlicemia.Text = "" + (int.Parse(listViewMedidasGlicemia.Items[listViewMedidasGlicemia.Items.Count - 1].SubItems[0].Text) + 1); OR
            textBoxIdGlicemia.Text = "" + (int.Parse(listViewMedidasGlicemia.Items[^1].SubItems[0].Text) + 1);

        }

        private void ClearPanel()
        {
            foreach (Control item in panelCampos.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Enabled = false;
            ClearPanel();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                int idMedidaGlicemia = int.Parse(textBoxIdGlicemia.Text);
                int valorGlicemia = int.Parse(textBoxValorGlicemia.Text);
                string dataMedida = dateTimePickerDataMedicao.ToString();
                int idPaciente = int.Parse(textBoxIdPaciente.Text);

                //gerar updatesql
                string updateSql = "update MedidaGlicemia set valorGlicemia = @valorGlicemia, dataMedida = @dataMedida, idPaciente = @idPaciente where " +
                                   "idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand updateCommand = new SqlCommand(updateSql, conn);
                updateCommand.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                updateCommand.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                updateCommand.Parameters.AddWithValue("@dataMedida", dataMedida);
                updateCommand.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executa senten�a sql
                int countLines = updateCommand.ExecuteNonQuery();
                MessageBox.Show("Done");
                //verifica se o update foi executado, sen�o, faz o insert TODO
                if (countLines < 1)
                {
                    //gerar insertsql
                    string insertSql = "";
                    SqlCommand insertCommand = new SqlCommand(insertSql, conn);
                    insertCommand.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                    insertCommand.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    insertCommand.Parameters.AddWithValue("@dataMedida", dataMedida);
                    insertCommand.Parameters.AddWithValue("@idPaciente", idPaciente);

                    //executa insert sql
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert!!!");
                throw;
            }
            finally
            {
                conn.Close();
                LoadListViewMedidasGlicemia();
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            panelCampos.Enabled = true;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                MessageBox.Show(listViewMedidasGlicemia.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listViewMedidasGlicemia.SelectedItems[0].Text);

                //gerar selectSql
                string selectSql = "select * from MedidaGlicemia where idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand selectCommand = new SqlCommand(selectSql, conn);

                selectCommand.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sql
                SqlDataReader reader = selectCommand.ExecuteReader();

                reader.Read();
                textBoxIdGlicemia.Text = reader["idMedidaGlicemia"].ToString();
                textBoxValorGlicemia.Text = reader["valorGlicemia"].ToString();

                string[] vetorDados;
                vetorDados = reader["dataMedida"].ToString().Split();
                dateTimePickerDataMedicao.Text = vetorDados[0];
                textBoxIdPaciente.Text = reader["idPaciente"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
                LoadListViewMedidasGlicemia();
            }
        }
    }
}