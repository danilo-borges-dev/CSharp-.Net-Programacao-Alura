namespace ByteBank.Funcionarios
{
    internal abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        protected double Salario;
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        public double GetSalario()
        {
            return Salario;
        }
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
