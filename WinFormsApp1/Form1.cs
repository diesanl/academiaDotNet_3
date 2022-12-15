namespace WinFormsApp1
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }
        private List<string> listNomes = new List<string>();

        //metodo q trata evento do componente
        private void btnInserir_MouseClick(object sender, MouseEventArgs e)
        {
            inserirtxtListaNomes();
        }


        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirtxtListaNomes();
            }
        }
        private void inserirtxtListaNomes()
        {
            //listNomes = preencheListaFromTxtListaNomes();
            string nome = txtNomeCompleto.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("É preciso digitar algo para inserir na lista");
            }
            else
            {
                if (null != listNomes)
                {
                    if (!listNomes.Contains(nome))
                    {
                        listNomes.Add(nome);
                        listNomes.Sort();
                        atualizarTxtListaNomes();
                        txtNomeCompleto.Text = String.Empty;
                    }
                    else if (listNomes.Contains(nome))
                    {
                        MessageBox.Show("Nome já cadastrado", "ATENÇÂO");
                    }
                }

            }
        }

        private void atualizarTxtListaNomes()
        {
            txtListaNomes.Text = String.Empty;
            foreach (var item in listNomes)
            {
                txtListaNomes.Text += item + Environment.NewLine;
            }
        }

        //private List<string> preencheListaFromTxtListaNomes()
        //{
        //    foreach (var item in txtListaNomes.Lines)
        //    {
        //        listNomes.Add((string)item);
        //    }
        //    return listNomes;
        //}


    }
}