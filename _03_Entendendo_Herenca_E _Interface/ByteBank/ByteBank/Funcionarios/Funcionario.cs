namespace ByteBank.Funcionarios
{
    internal class Funcionario
    {
        private string _nome;
        private string _cpf { get; set; }
        private double _salario { get; set; }
        public Funcionario(string nome, string cpf, double salario)
        {
            _nome = nome;
            _cpf = cpf;
            _salario = salario;
        }
        public double GetBonificacao()
        {
            return _salario * 0.10;
        }
    }
}
