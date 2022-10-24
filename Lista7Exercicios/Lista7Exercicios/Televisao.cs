using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Televisao : Eletronico
    {
        private ControleRemoto controle;
        private int volume;
        private int canal;

        public int Canal
        {
            get { return canal; }
            set { canal = value; }
        }


        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }


        public Televisao()
        {
            Controle = new ControleRemoto();
            this.volume = 01;
            this.canal = 01;
        }

        public ControleRemoto Controle
        {
            get { return controle; }
            set { controle = value; }
        }

        public override void Ligar()
        {
            Console.WriteLine("WebOs iniciando....");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
