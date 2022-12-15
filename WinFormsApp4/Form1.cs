using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp4
{
    public partial class FormPrincipal : Form
    {
        List<Jogador> listaJogadores = new List<Jogador>();
        string nomeArquivo = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jogadores.csv");
        public FormPrincipal()
        {
            InitializeComponent();
            Modelo.LerArquivo(listaJogadores, nomeArquivo);
            AtualizarTextBoxListaNomes();

        }

        private void AtualizarTextBoxListaNomes()
        {
            textBox_listaJogadores.Clear();
            listaJogadores.ForEach(jogador => textBox_listaJogadores.AppendText(jogador.Nome + Environment.NewLine));
        }

        private void button_trocar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá!!!!", "Alerta");
            label_titulo.Text = "Troquei o texto!!!!";
            label_titulo.BackColor = Color.Yellow;
        }

        private void button_paraMaiusculo_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomeJogador.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("AH vah", "Alert!!!");
            }

            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nomeJogador.Clear();

        }

        private void button_inserir_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomeJogador.Text.ToUpper();


            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("AH vah", "Alert!!!");
            }
            else
            {
                string email = CriaEmail(nome);
                Jogador jogador = new Jogador(nome, email);

                if (listaJogadores.Contains(jogador))
                {
                    MessageBox.Show("oh really???", "Alert!!!");
                }
                else
                {
                    listaJogadores.Add(jogador);
                    listaJogadores.Sort();

                    //textBox_listaJogadores.AppendText(nome + Environment.NewLine);

                    AtualizarTextBoxListaNomes();

                    Modelo.GravarLista(listaJogadores, nomeArquivo);

                    textBox_nomeJogador.Clear();
                    label_totalNomes.Text = "Total: " + listaJogadores.Count;

                }
                textBox_nomeJogador.Clear();
                textBox_nomeJogador.Focus();
            }
        }

        private void button_limparLista_Click(object sender, EventArgs e)
        {
            textBox_listaJogadores.Clear();
            listaJogadores.Clear();
            label_totalNomes.Text = "Total: " + 0;
        }

        private static string CriaEmail(string nome)
        {
            string sufix = "@ufn.edu.br";
            string[] dados = nome.ToLower().Split(" ");

            string email = dados[dados.Length - 1] + "." + dados[0] + sufix;

            return email;
        }
    }
}