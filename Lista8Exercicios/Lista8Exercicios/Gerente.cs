namespace Lista8Exercicios
{
    public class Gerente : Funcionario
    {
        public Gerente()
        {
            this.PossuiVinculo = true;
        }
        public Gerente(string nome, string departamento, double salario, DateTime data, string rg)
        {
            this.PossuiVinculo = true;
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataEntrada = data;
            this.Rg = rg;
        }

        public override void ExecutaTrabalho()
        {
            Console.WriteLine("O trabalho est´sendo executado por um Gerente");
        }
    }
}