using System.Data;

namespace WinFormsSQLInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = textBoxNome.Text;
            pessoa.Peso = float.Parse(textBoxPeso.Text);

            if (pessoa.Gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!!!!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir pessoa");
            }

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            DataTable dt = new DataTable();

            dt = bd.ExecutaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            DataTable dt = new DataTable();
            string nome = textBoxFiltrar.Text;

            dt = bd.ExecutaConsulta("select * from pessoas where nome = '" + nome + "'");

            dataGridView1.DataSource = dt;
        }
    }
}