using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    public class Aluguel
    {
        public Cliente cliente;
        public Carro carro;
        public int qtdeDias;
        public double valorLocacao;

        public Aluguel()
        {
        }

        public Aluguel(Cliente cliente, Carro carro)
        {
            this.cliente = cliente;
            this.carro = carro;
        }

    }
}
