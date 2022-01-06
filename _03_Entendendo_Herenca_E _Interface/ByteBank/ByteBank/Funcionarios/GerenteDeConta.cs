using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
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
