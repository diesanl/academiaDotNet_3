using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    abstract class Eletronico
    {

        private int _volts;
        private int _potencia;
        private bool _ligado;

        public int Volts { get => _volts; set => _volts = value; }
        public int Potencia { get => _potencia; set => _potencia = value; }
        public bool Ligado { get => _ligado; set => _ligado = value; }

        public abstract void Ligar();

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando equipamento.....");
        }


    }
}
