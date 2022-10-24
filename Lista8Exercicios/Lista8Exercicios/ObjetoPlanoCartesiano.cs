namespace Lista8Exercicios
{
    public class ObjetoPlanoCartesiano
    {

        private int _posX;

        public int PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }

        private int _posY;


        public int PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }

        public ObjetoPlanoCartesiano(int posX, int posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public ObjetoPlanoCartesiano()
        {
            _posX = new Random().Next(1, 1000);
            _posY = new Random().Next(1, 1000);
        }

        public override string? ToString()
        {
            return "Objeto " + this.GetHashCode() + "\nPosição X: " + this._posX + " Posição Y: " + this._posY;
        }
    }
}