namespace ByteBank.Funcionarios
{
    internal abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        protected double _salario;
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            _salario = salario;
            TotalDeFuncionarios++;
        }
        public abstract double GetBonificacao();
    }
}
