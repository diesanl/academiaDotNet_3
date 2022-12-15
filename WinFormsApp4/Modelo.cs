using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Modelo
    {
        public static void GravarLista(List<Jogador> listaJogadores, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (var jogador in listaJogadores)
            {
                writer.WriteLine(jogador.Nome + ";" + jogador.Email);
            }

            writer.Close();
        }

        public static void LerArquivo(List<Jogador> listaJogadores, string nomeArquivo)
        {

            try
            {
                StreamReader reader = new StreamReader(nomeArquivo, Encoding.UTF8);

                while (!reader.EndOfStream)
                {
                    string nomeEmail = reader.ReadLine();
                    string[] dados = nomeEmail.Split(";");
                    listaJogadores.Add(new Jogador(dados[0], dados[1]));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
