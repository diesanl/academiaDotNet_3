using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4Exercicios
{
    public class Temperatura
    {
        private double celsius = 0;

        public double getCelsius()
        {
            //converte p Fahrenheit
            return (((celsius * 9) / 5) + 32);
        }

        public void setCelsius(double fahrenheit)
        {
            //converte p celsius
            celsius = (((fahrenheit - 32) * 5) / 9);
        }

    }
}
