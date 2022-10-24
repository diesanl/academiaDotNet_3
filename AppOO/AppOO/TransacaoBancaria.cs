using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class TransacaoBancaria
    {

        private String agencia;
        private String tipo;
        private double valor;
        private String conta;

        public void Sacar(double qtde)
        {
            Console.WriteLine(valor -= qtde);
        }

        public void Depositar(double qtde) { Console.WriteLine(valor += qtde); }

        public void ConsultarSaldo()
        {
            Console.WriteLine("O valor em conta eh de {0}", valor);
        }

        public void ExibirDados()
        {
            Console.WriteLine("Agência: {0} \n" +
                              "Tipo: {1} \n" +
                              "Valor: {2} \n" +
                              "Conta: {3} \n", agencia, tipo, valor, conta);
        }
    }
}
