using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Android Iniciando....");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
