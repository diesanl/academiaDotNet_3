namespace Lista8Exercicios
{
    public class Operador : Funcionario
    {
        public Operador()
        {
            this.PossuiVinculo = true;
        }

        public Operador(string nome, string departamento, double salario, object dt, string rg)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            Dt = dt;
            Rg = rg;
        }

        public object Dt { get; }

        public override void ExecutaTrabalho()
        {
            Console.WriteLine("O trabalho est´sendo executado por um Operador");
        }
    }
}