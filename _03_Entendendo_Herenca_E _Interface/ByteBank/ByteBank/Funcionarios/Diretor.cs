namespace ByteBank.Funcionarios
{
    internal class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; // Salario = Salario * 1.15;
        }
    }
}
