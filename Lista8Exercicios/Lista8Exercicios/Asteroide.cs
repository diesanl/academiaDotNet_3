namespace Lista8Exercicios
{
    /* Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
        uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
        um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os métodos de acesso
        (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
        terceiro que constrói um asteroide com posição x e posição y. 
     */
    public class Asteroide
    {
        private int _posX;
        private int _posY;
        private int _tamanho;
        private int _velocidade;
        private int _energia;

        public int Energia
        {
            get { return _energia; }
            set { _energia = value; }
        }


        public int Velocidade
        {
            get { return _velocidade; }
            set { _velocidade = value; }
        }


        public int Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }


        public int PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }


        public int PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }


        public Asteroide()
        {
        }

        public Asteroide(int posX, int posY, int tamanho, int velocidade, int energia)
        {
            _posX = posX;
            _posY = posY;
            _tamanho = tamanho;
            _velocidade = velocidade;
            _energia = energia;
        }

        public Asteroide(int posX, int posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public override string ToString()
        {
            return "Posição X: " + _posX +
                   "\nPosição Y: " + _posY +
                   "\nTamanho: " + _tamanho +
                   "\nVelocidade X: " + _velocidade +
                   "\nEnergia: " + _energia + "\n";
        }
    }
}