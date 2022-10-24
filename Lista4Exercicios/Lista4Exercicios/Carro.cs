using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4Exercicios
{
    public class Carro
    {
        //property - to lower
        private String placa;
        private String fabricante;
        private bool ligado;
        private String cor;
        private double velocidadeMax;
        private String modelo;

        public Carro(string placa, string fabricante, bool ligado, string cor, double velocidadeMax, string modelo)
        {
            this.placa = placa ?? throw new ArgumentNullException(nameof(placa));
            this.fabricante = fabricante ?? throw new ArgumentNullException(nameof(fabricante));
            this.ligado = ligado;
            this.cor = cor ?? throw new ArgumentNullException(nameof(cor));
            this.velocidadeMax = velocidadeMax;
            this.modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
        }

        public Carro()
        {
        }

        public String getPlaca()
        {
            return placa;
        }

        public void setPlaca(String placa)
        {
            this.placa = placa;
        }

        public String getFabricante()
        {
            return fabricante;
        }

        public void setFabricante(String fabricante)
        {
            this.fabricante = fabricante;
        }


        public bool isLigado() { return ligado; }
        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }
        public String getCor()
        {
            return cor;
        }

        public void SetCor(String cor)
        {
            this.cor = cor;
        }

        public double getVelocidadeMax()
        {
            return velocidadeMax;
        }
        public void setVelocidadeMax(double velocidade)
        {
            velocidadeMax = velocidade;
        }
        //private String modelo;private String cor;
        public String getModelo()
        {
            return modelo;
        }
        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
