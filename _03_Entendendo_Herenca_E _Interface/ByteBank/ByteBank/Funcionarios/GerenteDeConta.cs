namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
