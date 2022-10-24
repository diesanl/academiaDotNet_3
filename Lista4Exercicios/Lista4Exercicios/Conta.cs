using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4Exercicios
{
    public class Conta
    {

        public Cliente cliente;
        public double saldo = 0;
        public String tipo = "corrente";

        public Conta(Cliente cliente, double saldo, string tipo)
        {
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            this.saldo = saldo;
            this.tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
        }

        public void Creditar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Creditado valor {0}", valor);
        }

        public void Debitar(double valor)
        {
            saldo -= valor;
            Console.WriteLine("Debitado valor {0}", valor);
        }

        public double getSaldo()
        {
            return saldo;
        }
    }
}
