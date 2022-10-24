using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Aviao
    {
        private String modelo;
        private double velocidade;
        private double altitude;
        private String marca;


        public double Reduzir()
        {
            return velocidade--;
        }

        public double Acelerar()
        {
            return velocidade++;
        }

        public double Subir()
        {
            return altitude++;
        }

        public double Descer() { return altitude--; }
    }
}
