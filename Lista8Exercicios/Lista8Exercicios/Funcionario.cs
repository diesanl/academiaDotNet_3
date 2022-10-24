namespace Lista8Exercicios
{
    public abstract class Funcionario
    {

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        private string _departamento;

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private double _salario;

        public double Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        private DateTime _dataEntrada;

        public DateTime DataEntrada
        {
            get { return _dataEntrada; }
            set { _dataEntrada = DateTime.Today; }
        }

        private string _rg;

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        private bool _possuiVinculo;

        public bool PossuiVinculo
        {
            get { return _possuiVinculo; }
            set { _possuiVinculo = value; }
        }

        public double Bonifica(double valor)
        {
            return _salario += valor;
        }

        public void Demite()
        {
            _possuiVinculo = false;
        }

        public abstract void ExecutaTrabalho();



    }
}