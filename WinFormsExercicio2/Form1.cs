namespace WinFormsExercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pessoa> listaPessoas = new List<Pessoa>();

        private void btnInserir_KeyPress(object sender, KeyPressEventArgs e)
        {
            CadastrarPessoa();
        }

        private void CadastrarPessoa()
        {
            string nome = txtNome.Text, email = txtEmail.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Favor não deixar campo em branco!!!", "ATENÇÃO!!!!");
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Favor informar email num formato válido!!!", "ATENÇÃO!!!!");
            }
            else
            {
                Pessoa pessoa = new Pessoa(nome, email);
                listaPessoas.Add(pessoa);

                atualizaListaPessoas();
                LimpaNomeEmail();
            }
        }

        private void atualizaListaPessoas()
        {
            txtListaPessoas.Clear();
            listaPessoas.Sort();

            foreach (var pessoa in listaPessoas)
            {
                txtListaPessoas.Text += pessoa.Nome + Environment.NewLine;
            }
        }

        private void LimpaNomeEmail()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void LimpaTodosCampos()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastrarPessoa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LimpaNomeEmail();
            LimpaTodosCampos();
        }

        private void btnLimpar_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpaTodosCampos();
            //LimpaNomeEmail();
        }

        private void btnListarEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizaListaEmail();
        }

        private void btnListarEmail_Click(object sender, EventArgs e)
        {
            AtualizaListaEmail();
        }

        private void AtualizaListaEmail()
        {
            if (listaPessoas.Count > 0)
            {
                string email = txtEmail.Text;
                //txtEmail.Clear();

                foreach (var pessoa in listaPessoas)
                {
                    txtListaEmails.Text += pessoa.Email + Environment.NewLine;
                }
            }
        }
        private void AtualizaListaDominio()
        {
            if (listaPessoas.Count > 0)
            {
                string email = txtListaDominios.Text;
                //txtEmail.Clear();

                foreach (var pessoa in listaPessoas)
                {
                    string[] dominios = email.Split("@");
                    txtListaEmails.Text += dominios[1] + Environment.NewLine;
                }
            }
        }
    }
}