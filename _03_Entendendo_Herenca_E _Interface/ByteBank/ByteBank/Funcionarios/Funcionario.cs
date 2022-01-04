namespace ByteBank.Funcionarios
{
    internal abstract class Funcionario
    {
        private string _nome;
        private string _cpf;
        protected double _salario;
        public Funcionario(string nome, string cpf, double salario)
        {
            _nome = nome;
            _cpf = cpf;
            _salario = salario;
        }
        public abstract double GetBonificacao();
    }
}
