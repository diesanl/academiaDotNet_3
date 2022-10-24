namespace Lista8Exercicios
{
    /** descrição (string), data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
      * altura (float). */
    public class ItemCenario
    {

        private string _desc;

        private DateTime _dataCriacao;

        private float _altura;

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }


        public DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }


        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        public ItemCenario()
        {
            _dataCriacao = DateTime.Now;
        }

        public ItemCenario(string desc, DateTime dataCriacao, float altura)
        {
            Desc = desc;
            DataCriacao = dataCriacao;
            Altura = altura;
        }

        public override string ToString()
        {
            return "Descrição: " + _desc + "\n" +
                   "Data de criação: " + _dataCriacao + "\n" +
                   "Altura: " + _altura + "\n";
        }

        private double calculaIdadeItem(DateTime dataCriacao)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(dataCriacao);
            double totalDays = timeSpan.TotalDays;

            DateTime dt = DateTimeOffset.FromUnixTimeSeconds((long)timeSpan.TotalSeconds).DateTime;
            //DateTimeOffset.FromUnixTimeSeconds((long)timeSpan.TotalSeconds).DateTime;

            Console.WriteLine(dt.Date);


            return totalDays;
        }

        public String mostraIdadeItem()
        {
            double days = calculaIdadeItem(_dataCriacao);

            return "O item tem " + days.ToString("F") + " dias de existência";
        }
    }
}