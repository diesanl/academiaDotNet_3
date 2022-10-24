using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Livro
    {

        private String isbn;
        private String titulo;
        private String editora;
        private int numPaginas;
        private double preco;

        public Livro(string isbn, string titulo, string editora, int numPaginas, double preco)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.editora = editora;
            this.numPaginas = numPaginas;
            this.preco = preco;
        }

        public Livro()
        {
        }

        public override string ToString()
        {
            return "ISBN: " + isbn + "\n" +
                   "Título: " + titulo + "\n" +
                   "Editora: " + editora + "\n" +
                   "Número de páginas: " + numPaginas + "\n" +
                   "Preço: " + preco + "\n";
        }
    }
}
