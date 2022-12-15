namespace WinFormsADONet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.abrirConexao();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento(textBoxNome.Text, textBoxLocalizacao.Text, textBoxOrcamento.Text);

            if (dep.GravarDepartamento())
            {
                MessageBox.Show("Adicionado com sucesso!!!!", "Atenção");
            }
            else
            {
                MessageBox.Show("Não Rolou!!!", "Atenção");
            }


        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            Empregado empregado = new Empregado(textBoxNomeFuncionario.Text, textBoxIdGerente.Text, textBoxFuncao.Text,
                int.Parse(textBoxIdDepartamento.Text), textBoxDataAdmissao.Text, int.Parse(textBoxSalario.Text), int.Parse(textBoxComissao.Text));

            if (empregado.GravarFuncionario())
            {
                MessageBox.Show("Adicionado com sucesso!!!!", "Atenção");
            }
            else
            {
                MessageBox.Show("Deu ruim pai!!!", "Atenção");
            }
        }
    }
}