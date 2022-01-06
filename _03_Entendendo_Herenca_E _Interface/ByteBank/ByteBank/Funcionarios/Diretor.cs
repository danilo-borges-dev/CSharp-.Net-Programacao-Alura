using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    internal class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
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
