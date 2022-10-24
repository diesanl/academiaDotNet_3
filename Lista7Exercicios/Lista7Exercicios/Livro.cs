using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    public class Livro
    {
        private string isbn;
        private string titulo;
        private int numPaginas;
        private double preco;
        private bool emEstoque;

        public Livro()
        {
        }

        public Livro(string isbn, string titulo, int numPaginas, double preco, bool emEstoque)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.numPaginas = numPaginas;
            this.preco = preco;
            this.emEstoque = emEstoque;
        }

        public void setIsbn(String isbn)
        {
            this.isbn = isbn;
        }

        public String getIsbn()
        {
            return isbn;

        }
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public void setNumPaginas(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }

        public int getNumPaginas()
        {
            return numPaginas;

        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public void temEstoque(bool estoque)
        {
            this.emEstoque = estoque;
        }
        public bool getIsBN()
        {
            return emEstoque;

        }

        public double getPreco()
        {
            return preco;
        }
    }
}
