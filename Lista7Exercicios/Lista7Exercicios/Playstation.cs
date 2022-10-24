using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Playstation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o PS");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
