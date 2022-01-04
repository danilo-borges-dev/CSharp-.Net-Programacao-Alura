namespace ByteBank.Funcionarios
{
    internal class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public override double GetBonificacao()
        {
            return _salario * 0.20;
        }
    }
}
