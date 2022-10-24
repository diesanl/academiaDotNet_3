using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    public class TelevisaoInterface : IEletronico
    {
        private ControleRemoto _controle;
        private int _volume;
        private int _canal;
        private bool _ligado;

        public int Volume { get => _volume; set => _volume = value; }
        public int Canal { get => _canal; set => _canal = value; }
        public bool Ligado { get => _ligado; set => _ligado = value; }
        internal ControleRemoto Controle { get => _controle; set => _controle = value; }

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando equipamento.....");
        }

        public void Ligar()
        {
            Console.WriteLine("WebOs iniciando....");
            //_ligado = true;
            this.Ligado = true;
        }

    }
}
