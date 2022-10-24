using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    public class Carro
    {

        public int id;
        public string modelo;
        public string cor;
        public string fabricante;
        public bool zeroKm;
        public double valorDiaria;

        public Carro()
        {
        }

        public Carro(int id, string modelo, string cor, string fabricante, bool zeroKm, double valorDiaria)
        {
            this.id = id;
            this.modelo = modelo;
            this.cor = cor;
            this.fabricante = fabricante;
            this.zeroKm = zeroKm;
            this.valorDiaria = valorDiaria;
        }
    }
}
