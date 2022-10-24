using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class ControleRemoto
    {
        

        private Televisao tv;

        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private int canal;

        public ControleRemoto(int volume, int canal, Televisao tv)
        {
            Volume = tv.Volume;
            Canal = tv.Canal;
            Tv = tv; 
        }

        public ControleRemoto()
        {
        }

        public int Canal
        {
            get { return canal; }
            set { canal = value; }
        }


        public Televisao Tv
        {
            get { return tv; }
            set { tv = value; }
        }

        public void aumentaVolume()
        {
            Console.WriteLine("");
        }


    }
}
