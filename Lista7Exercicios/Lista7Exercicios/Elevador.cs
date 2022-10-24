using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lista7Exercicios
{

    /*7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), 
        * total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
        Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
            Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
            Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
            Sobe : para subir um andar (não deve subir se já estiver no último andar);
            Desce : para descer um andar (não deve descer se já estiver no térreo);
            Encapsular todos os atributos da classe (criar os métodos set e get).
     */
    internal class Elevador
    {

        private int andarAtual;
        private int totalAndaresPredio;
        private int capacElevador;
        private int qtdePessoasPresentes;

        public Elevador()
        {
        }

        public Elevador(int capacElevador, int totalAndares)
        {
            AndarAtual = 0;
            QtdePessoasPresentes = 0;
            CapacElevador = capacElevador;
            TotalAndaresPredio = totalAndares;
        }

        public int AndarAtual { get => andarAtual; set => andarAtual = value; }
        public int TotalAndaresPredio { get => totalAndaresPredio; set => totalAndaresPredio = value; }
        public int CapacElevador { get => capacElevador; set => capacElevador = value; }
        public int QtdePessoasPresentes { get => qtdePessoasPresentes; set => qtdePessoasPresentes = value; }


        //Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
        public void AdicionaPessoa()
        {
            if (qtdePessoasPresentes < capacElevador)
            {
                qtdePessoasPresentes++;
                Console.WriteLine("Pessoa add c sucesso!!!" +
                                  "{0} pessoas estão no elevador agora.", qtdePessoasPresentes);
            }
            else
            {
                Console.WriteLine("Não foi possível add pessoa no elevador, \n" +
                                  "pois atingiu o limite de {0} pessoas", qtdePessoasPresentes);
            }

        }

        //Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);

        public void RemovePessoa()
        {
            if (qtdePessoasPresentes > 0)
            {
                qtdePessoasPresentes--;
                Console.WriteLine("Pessoa removida c sucesso. {0} pessoas estão no elevador agora.", qtdePessoasPresentes);
            }
            else
            {
                Console.WriteLine("Não foi possível remover pois o elevador está vazio");
            }
        }

        //  Sobe : para subir um andar (não deve subir se já estiver no último andar);
        public void Subir()
        {
            if (andarAtual < TotalAndaresPredio)
            {
                andarAtual++;
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
            else
            {
                Console.WriteLine("Não é possível subir, pois o elevador está no andar {0} e, " +
                                  "o prédio tem {1} andar(es)", andarAtual, TotalAndaresPredio);
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
        }

        //Desce : para descer um andar(não deve descer se já estiver no térreo);
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
            else
            {
                Console.WriteLine("Não foi possível descer, pois o elevador está no térreo");
                Console.WriteLine("Andar atual: {0}", andarAtual);
            }
        }





    }
}
